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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tlp_topTobuttom = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_leftToright = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_navbar = new System.Windows.Forms.Panel();
            this.pnl_chatList = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pic_chatList = new System.Windows.Forms.PictureBox();
            this.btn_chatList = new System.Windows.Forms.Button();
            this.pnl_friendList = new System.Windows.Forms.Panel();
            this.tlp_friendList = new System.Windows.Forms.TableLayoutPanel();
            this.pic_friendList = new System.Windows.Forms.PictureBox();
            this.btn_friendList = new System.Windows.Forms.Button();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.pnl_childForm = new System.Windows.Forms.Panel();
            this.pnl_logout = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pic_logout = new System.Windows.Forms.PictureBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.tlp_topTobuttom.SuspendLayout();
            this.tlp_leftToright.SuspendLayout();
            this.pnl_navbar.SuspendLayout();
            this.pnl_chatList.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_chatList)).BeginInit();
            this.pnl_friendList.SuspendLayout();
            this.tlp_friendList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_friendList)).BeginInit();
            this.pnl_header.SuspendLayout();
            this.pnl_logout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logout)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_topTobuttom
            // 
            this.tlp_topTobuttom.ColumnCount = 1;
            this.tlp_topTobuttom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_topTobuttom.Controls.Add(this.tlp_leftToright, 0, 1);
            this.tlp_topTobuttom.Controls.Add(this.pnl_header, 0, 0);
            this.tlp_topTobuttom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_topTobuttom.Location = new System.Drawing.Point(0, 0);
            this.tlp_topTobuttom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlp_topTobuttom.Name = "tlp_topTobuttom";
            this.tlp_topTobuttom.RowCount = 2;
            this.tlp_topTobuttom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.230958F));
            this.tlp_topTobuttom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.76904F));
            this.tlp_topTobuttom.Size = new System.Drawing.Size(1037, 495);
            this.tlp_topTobuttom.TabIndex = 0;
            // 
            // tlp_leftToright
            // 
            this.tlp_leftToright.ColumnCount = 2;
            this.tlp_leftToright.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.47243F));
            this.tlp_leftToright.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.52757F));
            this.tlp_leftToright.Controls.Add(this.pnl_navbar, 0, 0);
            this.tlp_leftToright.Controls.Add(this.pnl_childForm, 1, 0);
            this.tlp_leftToright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_leftToright.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tlp_leftToright.Location = new System.Drawing.Point(0, 40);
            this.tlp_leftToright.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_leftToright.Name = "tlp_leftToright";
            this.tlp_leftToright.RowCount = 1;
            this.tlp_leftToright.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_leftToright.Size = new System.Drawing.Size(1037, 455);
            this.tlp_leftToright.TabIndex = 0;
            // 
            // pnl_navbar
            // 
            this.pnl_navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(100)))), ((int)(((byte)(140)))));
            this.pnl_navbar.Controls.Add(this.pnl_logout);
            this.pnl_navbar.Controls.Add(this.pnl_chatList);
            this.pnl_navbar.Controls.Add(this.pnl_friendList);
            this.pnl_navbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_navbar.Location = new System.Drawing.Point(0, 0);
            this.pnl_navbar.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_navbar.Name = "pnl_navbar";
            this.pnl_navbar.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.pnl_navbar.Size = new System.Drawing.Size(181, 455);
            this.pnl_navbar.TabIndex = 0;
            // 
            // pnl_chatList
            // 
            this.pnl_chatList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(100)))), ((int)(((byte)(140)))));
            this.pnl_chatList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_chatList.Controls.Add(this.tableLayoutPanel1);
            this.pnl_chatList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_chatList.Location = new System.Drawing.Point(0, 126);
            this.pnl_chatList.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_chatList.Name = "pnl_chatList";
            this.pnl_chatList.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.pnl_chatList.Size = new System.Drawing.Size(181, 46);
            this.pnl_chatList.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.71084F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.28915F));
            this.tableLayoutPanel1.Controls.Add(this.pic_chatList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_chatList, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(161, 34);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pic_chatList
            // 
            this.pic_chatList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_chatList.Image = ((System.Drawing.Image)(resources.GetObject("pic_chatList.Image")));
            this.pic_chatList.Location = new System.Drawing.Point(3, 2);
            this.pic_chatList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_chatList.Name = "pic_chatList";
            this.pic_chatList.Size = new System.Drawing.Size(38, 30);
            this.pic_chatList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_chatList.TabIndex = 0;
            this.pic_chatList.TabStop = false;
            // 
            // btn_chatList
            // 
            this.btn_chatList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(100)))), ((int)(((byte)(140)))));
            this.btn_chatList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_chatList.FlatAppearance.BorderSize = 0;
            this.btn_chatList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chatList.Location = new System.Drawing.Point(44, 0);
            this.btn_chatList.Margin = new System.Windows.Forms.Padding(0);
            this.btn_chatList.Name = "btn_chatList";
            this.btn_chatList.Size = new System.Drawing.Size(117, 34);
            this.btn_chatList.TabIndex = 1;
            this.btn_chatList.Text = "채팅 목록";
            this.btn_chatList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_chatList.UseVisualStyleBackColor = false;
            this.btn_chatList.Click += new System.EventHandler(this.btn_chatList_Click);
            // 
            // pnl_friendList
            // 
            this.pnl_friendList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(100)))), ((int)(((byte)(140)))));
            this.pnl_friendList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_friendList.Controls.Add(this.tlp_friendList);
            this.pnl_friendList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_friendList.Location = new System.Drawing.Point(0, 80);
            this.pnl_friendList.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_friendList.Name = "pnl_friendList";
            this.pnl_friendList.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.pnl_friendList.Size = new System.Drawing.Size(181, 46);
            this.pnl_friendList.TabIndex = 0;
            // 
            // tlp_friendList
            // 
            this.tlp_friendList.ColumnCount = 2;
            this.tlp_friendList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.71084F));
            this.tlp_friendList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.28915F));
            this.tlp_friendList.Controls.Add(this.pic_friendList, 0, 0);
            this.tlp_friendList.Controls.Add(this.btn_friendList, 1, 0);
            this.tlp_friendList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_friendList.Location = new System.Drawing.Point(9, 5);
            this.tlp_friendList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlp_friendList.Name = "tlp_friendList";
            this.tlp_friendList.RowCount = 1;
            this.tlp_friendList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_friendList.Size = new System.Drawing.Size(161, 34);
            this.tlp_friendList.TabIndex = 0;
            // 
            // pic_friendList
            // 
            this.pic_friendList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_friendList.Image = ((System.Drawing.Image)(resources.GetObject("pic_friendList.Image")));
            this.pic_friendList.Location = new System.Drawing.Point(3, 2);
            this.pic_friendList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_friendList.Name = "pic_friendList";
            this.pic_friendList.Size = new System.Drawing.Size(38, 30);
            this.pic_friendList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_friendList.TabIndex = 0;
            this.pic_friendList.TabStop = false;
            // 
            // btn_friendList
            // 
            this.btn_friendList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(100)))), ((int)(((byte)(140)))));
            this.btn_friendList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_friendList.FlatAppearance.BorderSize = 0;
            this.btn_friendList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_friendList.Location = new System.Drawing.Point(44, 0);
            this.btn_friendList.Margin = new System.Windows.Forms.Padding(0);
            this.btn_friendList.Name = "btn_friendList";
            this.btn_friendList.Size = new System.Drawing.Size(117, 34);
            this.btn_friendList.TabIndex = 1;
            this.btn_friendList.Text = "친구 목록";
            this.btn_friendList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_friendList.UseVisualStyleBackColor = false;
            this.btn_friendList.Click += new System.EventHandler(this.btn_friendList_Click);
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(100)))), ((int)(((byte)(140)))));
            this.pnl_header.Controls.Add(this.lbl_name);
            this.pnl_header.Controls.Add(this.lbl_logo);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1037, 40);
            this.pnl_header.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_name.Location = new System.Drawing.Point(934, 12);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lbl_name.Size = new System.Drawing.Size(8, 19);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_logo
            // 
            this.lbl_logo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_logo.Location = new System.Drawing.Point(36, 15);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(114, 15);
            this.lbl_logo.TabIndex = 0;
            this.lbl_logo.Text = "LOGI SYSTEM";
            // 
            // pnl_childForm
            // 
            this.pnl_childForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_childForm.Location = new System.Drawing.Point(184, 3);
            this.pnl_childForm.Name = "pnl_childForm";
            this.pnl_childForm.Size = new System.Drawing.Size(850, 449);
            this.pnl_childForm.TabIndex = 1;
            // 
            // pnl_logout
            // 
            this.pnl_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(100)))), ((int)(((byte)(140)))));
            this.pnl_logout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_logout.Controls.Add(this.tableLayoutPanel2);
            this.pnl_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_logout.Location = new System.Drawing.Point(0, 409);
            this.pnl_logout.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_logout.Name = "pnl_logout";
            this.pnl_logout.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.pnl_logout.Size = new System.Drawing.Size(181, 46);
            this.pnl_logout.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.71084F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.28915F));
            this.tableLayoutPanel2.Controls.Add(this.pic_logout, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_logout, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(161, 34);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pic_logout
            // 
            this.pic_logout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_logout.Image = ((System.Drawing.Image)(resources.GetObject("pic_logout.Image")));
            this.pic_logout.Location = new System.Drawing.Point(3, 2);
            this.pic_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_logout.Name = "pic_logout";
            this.pic_logout.Size = new System.Drawing.Size(38, 30);
            this.pic_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_logout.TabIndex = 0;
            this.pic_logout.TabStop = false;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(100)))), ((int)(((byte)(140)))));
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Location = new System.Drawing.Point(44, 0);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(0);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(117, 34);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "로그아웃";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 495);
            this.Controls.Add(this.tlp_topTobuttom);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.tlp_topTobuttom.ResumeLayout(false);
            this.tlp_leftToright.ResumeLayout(false);
            this.pnl_navbar.ResumeLayout(false);
            this.pnl_chatList.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_chatList)).EndInit();
            this.pnl_friendList.ResumeLayout(false);
            this.tlp_friendList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_friendList)).EndInit();
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.pnl_logout.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_topTobuttom;
        private System.Windows.Forms.TableLayoutPanel tlp_leftToright;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Panel pnl_navbar;
        private System.Windows.Forms.Panel pnl_friendList;
        private System.Windows.Forms.TableLayoutPanel tlp_friendList;
        private System.Windows.Forms.PictureBox pic_friendList;
        private System.Windows.Forms.Button btn_friendList;
        private System.Windows.Forms.Panel pnl_chatList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pic_chatList;
        private System.Windows.Forms.Button btn_chatList;
        private System.Windows.Forms.Panel pnl_childForm;
        private System.Windows.Forms.Panel pnl_logout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pic_logout;
        private System.Windows.Forms.Button btn_logout;
    }
}