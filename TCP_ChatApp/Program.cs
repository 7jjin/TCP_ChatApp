using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCP_ChatApp.Forms;
using TCP_ChatApp.Models;
using TCP_ChatApp.Packets;
using TCP_ChatApp.Utils;
using System.Text.Json;

namespace TCP_ChatApp
{

    static class Program
    {
        public static object locker = new object();                     // 송신 뮤택스
        public static TcpClient client;                                 // 서버와 연결된 TCP 소켓
        public static NetworkStream ns;                                 // 네트워크 스트림
        public static string hostname;                                  // 접속할 서버 주소
        public static readonly ushort port = 5000;                      // 접속할 서버 포트
        public static Thread recvThread;                                // 서버로부터 수신을 대기하는 스레드
        public static Dictionary<PacketType, Action<String>> callback;  // 타입에 따른 콜백 메서드

        public static User user;                                        // 나의 사원 정보
        public static Dictionary<string,User> users;                    // 사원들 정보
        private static FormMain formMain;                               // 시작 폼

        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            client = new TcpClient();
            recvThread = new Thread(new ThreadStart(Recieve));
            callback = new Dictionary<PacketType,Action<String>>();

            string[] args = Environment.GetCommandLineArgs();
            hostname = args.Length > 1 ? args[1] : "127.0.0.1";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(formMain = new FormMain());


            // 프로그램이 종료되면 서버 연결 끊기
            if (client.Connected)
            {
                Send(new Packet(PacketType.Close));
                if(recvThread.IsAlive)
                {
                    recvThread.Abort();
                }
                client.Close();
            }
        }

        static void Recieve()
        {
            byte[] readBuffer = null, lengthBuffer = new byte[4];
            while (client.Connected)
            {
                // 패킷 읽기
                try
                {
                    // 패킷 길이 먼저 읽기
                    if (ns.Read(lengthBuffer, 0, 4) < 4)
                    {
                        formMain.Invoke(new MethodInvoker(() =>
                            MessageBox.Show(formMain, "패킷 길이를 읽지 못하였습니다.", "Recieve",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)));

                        // 수신 버퍼 리셋
                        while (ns.ReadByte() != -1) ;
                    }
                    readBuffer = new byte[BitConverter.ToInt32(lengthBuffer, 0)];
                    int position = 0;

                    // 길이를 토대로 데이터 읽기, 잘려서 와도 끝까지 읽음
                    while (position < readBuffer.Length)
                        position += ns.Read(readBuffer, position, readBuffer.Length - position);
                }
                catch (ThreadAbortException)
                {
                    return;
                }catch(Exception ex)
                {
                    formMain.Invoke(new MethodInvoker(() =>
                       MessageBox.Show(formMain, ex.ToString(), "Recieve",
                       MessageBoxButtons.OK, MessageBoxIcon.Error)));

                    // 패킷 받는 도중 예외가 발생했을 때
                    // 서버와 연결이 종료되었다면 재시작 후 접속 시도
                    break;
                }


                // AES256 해독 후 JSON 기반 역직렬화
                string decryptedJson = Encoding.UTF8.GetString(AES256.Decrypt(readBuffer));
                Packet packet = null;
                try
                {
                    packet = JsonSerializer.Deserialize<Packet>(decryptedJson);
                }
                catch(Exception ex)
                {
                    formMain.Invoke(new MethodInvoker(() =>
                        MessageBox.Show(formMain, ex.ToString(), "Deserialize",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)));
                    break;
                }

                if (callback.ContainsKey(packet.type))
                    callback[packet.type].Invoke(decryptedJson);
            }

            Application.Exit();
            Process.Start(Application.ExecutablePath);
        }


        public static void Send(Packet packet)
        {
            lock (locker)
            {
                byte[] sendBuffer = AES256.Encrypt(packet.Serialize());
                byte[] lengthBuffer = BitConverter.GetBytes(sendBuffer.Length);

                ns.Write(lengthBuffer, 0, 4);
                ns.Write(sendBuffer, 0, sendBuffer.Length);
                ns.Flush();
            }
        }
    }
}
