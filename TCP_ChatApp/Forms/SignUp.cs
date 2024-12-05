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
        /// 중복 ID 체크 이벤트
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
        /// 회원가입 등록 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                // 입력 필드 유효성 검사
                if (!IsFormValid())
                {
                    return; // 유효성 검사 실패 시 회원가입 로직 중단
                }

                // 아이디 중복 체크를 안 했을 때
                if (idCheckPacket == null)
                {
                    MessageBox.Show(this, "아이디 중복 체크를 해주세요.", "회원 등록", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // 아이디 중복인 상태에서 회원가입 버튼 클릭
                else if (!idCheckPacket.success)
                {
                    MessageBox.Show(this, "중복된 아이디입니다. \n아이디 중복 체크를 확인해주세요.", "회원 등록", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // 정상적인 경우
                else
                {
                    Program.callback.Add(PacketType.Register, ReceiveChat);
                    Program.Send(new RegisterPacket(new User(txt_id.Text, txt_name.Text, PasswordHasher.HashPassword(txt_pw.Text), txt_phoneNumber.Text)));
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "입력 형식이 잘못되었습니다.", "회원 등록", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 취소하기 버튼 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    MessageBox.Show(this,"성공적으로 회원가입이 되었습니다.","회원 등록",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this,"실패","회원 등록",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }));
        }

        /// <summary>
        /// 유효성 검사 로직
        /// </summary>
        /// <returns></returns>
        private bool IsFormValid()
        {
            // 모든 입력란 확인
            if (string.IsNullOrWhiteSpace(txt_id.Text) ||
                string.IsNullOrWhiteSpace(txt_name.Text) ||
                string.IsNullOrWhiteSpace(txt_pw.Text) ||
                string.IsNullOrWhiteSpace(txt_rePw.Text) ||
                string.IsNullOrWhiteSpace(txt_phoneNumber.Text))
            {
                MessageBox.Show(this, "모든 입력란을 채워주세요.", "회원 등록", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 비밀번호와 비밀번호 확인 값 비교
            if (txt_pw.Text != txt_rePw.Text)
            {
                MessageBox.Show(this, "비밀번호가 일치하지 않습니다.", "회원 등록", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 핸드폰 번호 형식 확인
            if (!IsValidPhoneNumber(txt_phoneNumber.Text))
            {
                MessageBox.Show(this, "핸드폰 번호 형식이 잘못되었습니다. '000-0000-0000' 형태로 입력해주세요.", "회원 등록", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /// <summary>
        /// 전화번호 형식 로직
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // 정규식: "000-0000-0000" 형식 검사
            string pattern = @"^\d{3}-\d{4}-\d{4}$";
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, pattern);
        }

       

        
    }
}
