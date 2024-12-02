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
using TCP_ChatApp.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TCP_ChatApp.Forms
{
    public partial class SignUp : Form
    {
        // DB 연결 
        private string _connectionString = "Server='DESKTOP-B46DJQ2';Database='chatapp';User Id='jin';Password='chatapp123';";
        private Boolean checked_id;
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
            RegisterUser(txt_id.Text, txt_name.Text, txt_pw.Text, txt_phoneNumber.Text);
        }

        /// <summary>
        /// 회원가입 등록 메서드
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        private string RegisterUser(string id, string name, string password, string phoneNumber)
        {
            // 1. 입력값 유효성 검사
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(phoneNumber))
            {
                return "ERROR|All fields are required";
            }

            // 2. 중복 ID 체크
            if (!checked_id)
            {
                return "ERROR|Duplicated ID";
            }

            // 전화번호 형식 검사 (숫자만 포함)
            if (!System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d+$"))
            {
                return "ERROR|Invalid phone number format";
            }

            // 비밀번호 강도 체크 (예: 6자 이상, 숫자, 대문자 포함)
            if (password.Length < 6  || !password.Any(char.IsDigit))
            {
                return "ERROR|Password must be at least 6 characters long, contain an uppercase letter and a number";
            }

            // 3. 비밀번호 해시화
            string hashedPassword = PasswordHasher.HashPassword(password);

            // 4. 데이터베이스에 회원 정보 저장
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    // SQL Insert Command
                    var command = new SqlCommand("INSERT INTO users (id, name, password, phoneNumber) VALUES (@id, @name, @password, @phoneNumber)", connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@password", hashedPassword);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("회원가입 성공","회원가입", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return "SUCCESS|User Registered";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("회원가입 실패","회원가입",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return $"ERROR|Database error: {ex.Message}";
            }
        }



        /// <summary>
        /// 중복 ID 체크 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_idCheck_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT COUNT(*) FROM users WHERE id = @id", connection);
                command.Parameters.AddWithValue("@id", txt_id.Text);

                int count = (int)command.ExecuteScalar();
                if(count > 0)
                {
                    checked_id = false;
                    MessageBox.Show("중복된 ID 입니다.");
                }
                else
                {
                    checked_id = true;
                    MessageBox.Show("사용가능한 ID 입니다.");
                    
                }
            }
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
