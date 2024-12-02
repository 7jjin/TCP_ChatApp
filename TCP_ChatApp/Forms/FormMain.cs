using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void label5_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
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

    }
}
