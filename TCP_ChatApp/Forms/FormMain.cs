using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCP_ChatApp.Packets;

namespace TCP_ChatApp.Forms
{
    public partial class FormMain : Form
    {
        private Form activeForm = null;
        public FormMain()
        {
            InitializeComponent();
            openChildForm(new FormFriendList());
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            Hide();
            Opacity = 1;

            FormLogin form = new FormLogin();
            if (form.ShowDialog() == DialogResult.OK) Show();
            else
            {
                Close();
                return;
            }
            Console.WriteLine(Program.user);
            lbl_name.Text = Program.user.name;
        }

        
        /// <summary>
        /// 버튼 클릭 시 원하는 폼으로 전환
        /// </summary>
        /// <param name="childForm"></param>
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_childForm.Controls.Add(childForm);
            pnl_childForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_friendList_Click(object sender, EventArgs e)
        {
            openChildForm(new FormFriendList());
        }

        private void btn_chatList_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChatList());
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Program.Send(new Packet(PacketType.Close));

            // 로그아웃 후 로그인 화면으로 이동
            Application.Exit();
            Process.Start(Application.ExecutablePath);
        }
    }
}
