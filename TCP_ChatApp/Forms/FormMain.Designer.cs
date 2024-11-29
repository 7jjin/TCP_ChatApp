namespace TCP_ChatApp.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pic_loginMain = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_loginTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.lbl_pw = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_resetPw = new System.Windows.Forms.Label();
            this.lbl_signUp = new System.Windows.Forms.Label();
            this.loginTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_loginMain)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTableLayoutPanel
            // 
            this.loginTableLayoutPanel.AutoSize = true;
            this.loginTableLayoutPanel.ColumnCount = 2;
            this.loginTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.82475F));
            this.loginTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.17525F));
            this.loginTableLayoutPanel.Controls.Add(this.pic_loginMain, 0, 0);
            this.loginTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.loginTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.loginTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.loginTableLayoutPanel.Name = "loginTableLayoutPanel";
            this.loginTableLayoutPanel.RowCount = 1;
            this.loginTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.64372F));
            this.loginTableLayoutPanel.Size = new System.Drawing.Size(1250, 650);
            this.loginTableLayoutPanel.TabIndex = 0;
            // 
            // pic_loginMain
            // 
            this.pic_loginMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_loginMain.Image = global::TCP_ChatApp.Properties.Resources.LoginPicture;
            this.pic_loginMain.Location = new System.Drawing.Point(3, 3);
            this.pic_loginMain.Name = "pic_loginMain";
            this.pic_loginMain.Size = new System.Drawing.Size(516, 644);
            this.pic_loginMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_loginMain.TabIndex = 0;
            this.pic_loginMain.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_loginTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(525, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.90062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.86335F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.23602F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(722, 644);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lbl_loginTitle
            // 
            this.lbl_loginTitle.AutoSize = true;
            this.lbl_loginTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_loginTitle.Font = new System.Drawing.Font("돋움", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_loginTitle.Location = new System.Drawing.Point(3, 0);
            this.lbl_loginTitle.Name = "lbl_loginTitle";
            this.lbl_loginTitle.Size = new System.Drawing.Size(716, 199);
            this.lbl_loginTitle.TabIndex = 0;
            this.lbl_loginTitle.Text = "LOGI SYSTEM";
            this.lbl_loginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_pw);
            this.panel1.Controls.Add(this.lbl_resetPw);
            this.panel1.Controls.Add(this.lbl_pw);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.lbl_id);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 328);
            this.panel1.TabIndex = 1;
            // 
            // lbl_id
            // 
            this.lbl_id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(153, 54);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(52, 15);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "아이디";
            // 
            // txt_id
            // 
            this.txt_id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_id.Font = new System.Drawing.Font("돋움", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_id.Location = new System.Drawing.Point(156, 82);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(383, 39);
            this.txt_id.TabIndex = 1;
            // 
            // txt_pw
            // 
            this.txt_pw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pw.Font = new System.Drawing.Font("돋움", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_pw.Location = new System.Drawing.Point(156, 167);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.Size = new System.Drawing.Size(383, 39);
            this.txt_pw.TabIndex = 2;
            // 
            // lbl_pw
            // 
            this.lbl_pw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pw.AutoSize = true;
            this.lbl_pw.Location = new System.Drawing.Point(153, 139);
            this.lbl_pw.Name = "lbl_pw";
            this.lbl_pw.Size = new System.Drawing.Size(67, 15);
            this.lbl_pw.TabIndex = 2;
            this.lbl_pw.Text = "비밀번호";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogin.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLogin.Location = new System.Drawing.Point(156, 269);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(383, 59);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_signUp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 536);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 105);
            this.panel2.TabIndex = 2;
            // 
            // lbl_resetPw
            // 
            this.lbl_resetPw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_resetPw.AutoSize = true;
            this.lbl_resetPw.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_resetPw.ForeColor = System.Drawing.Color.Gray;
            this.lbl_resetPw.Location = new System.Drawing.Point(422, 221);
            this.lbl_resetPw.Name = "lbl_resetPw";
            this.lbl_resetPw.Size = new System.Drawing.Size(117, 15);
            this.lbl_resetPw.TabIndex = 0;
            this.lbl_resetPw.Text = "비밀번호 재설정";
            // 
            // lbl_signUp
            // 
            this.lbl_signUp.AutoSize = true;
            this.lbl_signUp.ForeColor = System.Drawing.Color.Gray;
            this.lbl_signUp.Location = new System.Drawing.Point(316, 31);
            this.lbl_signUp.Name = "lbl_signUp";
            this.lbl_signUp.Size = new System.Drawing.Size(67, 15);
            this.lbl_signUp.TabIndex = 1;
            this.lbl_signUp.Text = "회원가입";
            this.lbl_signUp.Click += new System.EventHandler(this.label5_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 650);
            this.Controls.Add(this.loginTableLayoutPanel);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.loginTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_loginMain)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel loginTableLayoutPanel;
        private System.Windows.Forms.PictureBox pic_loginMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_loginTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.Label lbl_pw;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_resetPw;
        private System.Windows.Forms.Label lbl_signUp;
    }
}