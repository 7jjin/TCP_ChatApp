using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCP_ChatApp.Models;
using TCP_ChatApp.Packets;
using TCP_ChatApp.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TCP_ChatApp.Forms
{
    public partial class SignUp : Form
    {
       
        public SignUp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 회원가입 등록
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                Program.callback.Add(PacketType.Register, ReceiveChat);
                Program.Send(new RegisterPacket(new User(txt_id.Text, txt_name.Text, txt_pw.Text, txt_phoneNumber.Text)));
            }
            catch (FormatException) { }
        }


        void ReceiveChat(Packet p)
        {
            Program.callback.Remove(PacketType.Register);

            Invoke(new MethodInvoker(() =>
            {
                if((p as RegisterPacket).success)
                {
                    MessageBox.Show(this,"성공","회원 등록",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this,"실패","회원 등록",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }));
        }


        /// <summary>
        /// 취소하기 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
