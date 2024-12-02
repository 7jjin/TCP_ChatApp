using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_ChatApp.Forms
{

    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txt_id.Text;
            string password = txt_pw.Text;

            string response = SendRequest($"LOGIN|{username}|{password}");
            if (response.StartsWith("SUCCESS"))
            {
                MessageBox.Show("Login successful!");
                // 이후 1:1 채팅 화면으로 이동
            }
            else
            {
                MessageBox.Show(response.Split('|')[1]);
            }
        }

        private string SendRequest(string message)
        {
            try
            {
                using (TcpClient client = new TcpClient("127.0.0.1", 5000))
                using (NetworkStream stream = client.GetStream())
                {
                    byte[] buffer = Encoding.UTF8.GetBytes(message);
                    stream.Write(buffer, 0, buffer.Length);

                    buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    return Encoding.UTF8.GetString(buffer, 0, bytesRead);
                }
            }
            catch
            {
                return "ERROR|Failed to connect to server";
            }
        }
    }
}
