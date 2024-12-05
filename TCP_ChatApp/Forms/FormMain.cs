using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCP_ChatApp.Models;
using TCP_ChatApp.Packets;
using TCP_ChatApp.Utils;

namespace TCP_ChatApp.Forms
{

    public partial class FormMain : Form
    {
        bool loginable = false;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            if (Program.client.Connected)
            {
                loginable = true;
            }
            else
            {
                lbl_result.Text = $"서버에 연결 중입니다.\n{Program.hostname}:{Program.port}";
                Program.client.BeginConnect(Program.hostname, Program.port, EndConnect, null);
            }
        }

        public void EndConnect(IAsyncResult result)
        {
            string resultText = Program.client.Connected ? "" : "기본 서버 연결 실패";
            try
            {
                Program.client.EndConnect(result);
            }catch(Exception ex)
            {
                resultText = ex.Message;
            }

            // 연결 도중 폼을 닫으면 함수 실행 안함
            if (this == null) return;

            // 연결에 따른 결과 메세지 설정 및 연결 성공 시 수신 스레드 시작
            if(Program.client.Connected)
            {
                Program.ns = Program.client.GetStream();
                Program.recvThread.Start();
                resultText = "서버와 연결되었습니다";
            }
            else
            {
                resultText += "\n5초 뒤 연결을 재시도 합니다.";
            }

            // 연결에 따른 컨트롤 변화
            loginable = true;
            Invoke(new MethodInvoker(() =>
            {
                lbl_result.Text = resultText;
            }));

            if (!Program.client.Connected)
            {
                Thread.Sleep(5000);
                FormMain_Shown(null,new EventArgs());
            }
        }

        /// <summary>
        /// 회원가입 폼 Open 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbl_signUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!loginable) return;

            // 로그인이 끝나면 실행하도록 콜백 메서드 전달
            if (!Program.callback.ContainsKey(PacketType.Login))
                Program.callback.Add(PacketType.Login, EndLogin);

            // 서버가 연결되어 있으면 계정 정보를 서버로 전송하여 로그인 시도
            if (Program.client.Connected)
            {
                lbl_result.Text = "로그인 중...";
                Program.user = new User(txt_id.Text, PasswordHasher.HashPassword(txt_pw.Text));
                Program.Send(new LoginPacket(txt_id.Text,txt_pw.Text));
            }
            else
            {
                lbl_result.Text = "서버와 연결 되어있지 않습니다.";
            }
        }


        public void EndLogin(string str)
        {
            Program.callback.Remove(PacketType.Login);
            LoginPacket loginPacket = JsonSerializer.Deserialize<LoginPacket>(str);

            if (loginPacket.success)
            {
                DialogResult = DialogResult.OK;

                // 받은 로그이 패킷에서 내 정보 찾기
                foreach(User user in loginPacket.users.Values)
                {
                    if(user.id == Program.user.id)
                    {
                        Program.user = user;
                        break;
                    }
                }

                // 로그인 창 닫기
                BeginInvoke(new MethodInvoker(() => MessageBox.Show(this, "성공적으로 로그인이 되었습니다.", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Information)));
            }
            else
            {
                Invoke(new MethodInvoker(() =>
                {
                    loginable = true;
                    lbl_result.ForeColor = Color.Red;
                    lbl_result.Text = "아이디 또는 비밀번호를 다시 확인해주세요";
                }));
            }
        }
    }
}
