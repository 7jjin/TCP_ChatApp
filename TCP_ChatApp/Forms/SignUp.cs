using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
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

        IdCheckPacket idCheckPacket = null;
        public SignUp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 중복 ID 체크
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_idCheck_Click(object sender, EventArgs e)
        {
            try
            {
                Program.callback.Add(PacketType.IdCheck, ReceiveIdCheck);
                Program.Send(new IdCheckPacket(txt_id.Text));
            }
            catch (FormatException) { }
        }

        /// <summary>
        /// 중복 ID 체크 메서드
        /// </summary>
        /// <param name="str"></param>
        void ReceiveIdCheck(string str)
        {
            Program.callback.Remove(PacketType.IdCheck);
            idCheckPacket = JsonSerializer.Deserialize<IdCheckPacket>(str);

            Invoke(new MethodInvoker(() =>
            {
                if (idCheckPacket.success)
                {
                    MessageBox.Show(this, "사용 가능한 ID 입니다.", "회원 등록", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "중복된 아이디 입니다.", "회원 등록", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }));
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
                // 아이디 중복 체크를 안했을 때
                if (idCheckPacket == null)
                {
                    MessageBox.Show(this, "아이디 중복 체크를 해주세요.", "회원 등록", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // 
                else if (!idCheckPacket.success)
                {
                    MessageBox.Show(this, "중복된 아이디 입니다. \n아이디 중복 체크를 확인해주세요.", "회원 등록", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Program.callback.Add(PacketType.Register, ReceiveChat);
                    Program.Send(new RegisterPacket(new User(txt_id.Text, txt_name.Text, PasswordHasher.HashPassword(txt_pw.Text), txt_phoneNumber.Text)));
                }
            }
            catch (FormatException) { }
        }


        /// <summary>
        /// 회원가입 메서드
        /// </summary>
        /// <param name="str"></param>
        void ReceiveChat(String str)
        {
            Program.callback.Remove(PacketType.Register);
            RegisterPacket registerPacket = JsonSerializer.Deserialize<RegisterPacket>(str);

            Invoke(new MethodInvoker(() =>
            {
                if(registerPacket.success)
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
