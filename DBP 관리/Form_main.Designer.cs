namespace DBP_관리
{
    partial class Form_main
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.group_profile = new System.Windows.Forms.GroupBox();
			this.txt_team = new System.Windows.Forms.Label();
			this.label_team = new System.Windows.Forms.Label();
			this.txt_department = new System.Windows.Forms.Label();
			this.label_dapartment = new System.Windows.Forms.Label();
			this.txt_nick = new System.Windows.Forms.Label();
			this.btn_main_logout = new System.Windows.Forms.Button();
			this.label_alterProfile = new System.Windows.Forms.Label();
			this.profile_nick = new System.Windows.Forms.Label();
			this.main_profile = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.textBoxMyID = new System.Windows.Forms.TextBox();
			this.textBoxIPAdress = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Info = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.생일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.테마변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.뉴스검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			this.group_profile.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.main_profile)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.treeView1);
			this.groupBox1.Location = new System.Drawing.Point(12, 14);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(485, 424);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "대화방생성";
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(23, 29);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(426, 365);
			this.treeView1.TabIndex = 0;
			this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Chatting);
			// 
			// listBox1
			// 
			this.listBox1.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 37;
			this.listBox1.Location = new System.Drawing.Point(514, 43);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(190, 337);
			this.listBox1.TabIndex = 1;
			// 
			// group_profile
			// 
			this.group_profile.Controls.Add(this.txt_team);
			this.group_profile.Controls.Add(this.label_team);
			this.group_profile.Controls.Add(this.txt_department);
			this.group_profile.Controls.Add(this.label_dapartment);
			this.group_profile.Controls.Add(this.txt_nick);
			this.group_profile.Controls.Add(this.btn_main_logout);
			this.group_profile.Controls.Add(this.label_alterProfile);
			this.group_profile.Controls.Add(this.profile_nick);
			this.group_profile.Controls.Add(this.main_profile);
			this.group_profile.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.group_profile.ForeColor = System.Drawing.Color.White;
			this.group_profile.Location = new System.Drawing.Point(764, 14);
			this.group_profile.Margin = new System.Windows.Forms.Padding(2);
			this.group_profile.Name = "group_profile";
			this.group_profile.Padding = new System.Windows.Forms.Padding(2);
			this.group_profile.Size = new System.Drawing.Size(236, 406);
			this.group_profile.TabIndex = 2;
			this.group_profile.TabStop = false;
			this.group_profile.Text = "프로필";
			// 
			// txt_team
			// 
			this.txt_team.AutoSize = true;
			this.txt_team.Location = new System.Drawing.Point(127, 316);
			this.txt_team.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.txt_team.Name = "txt_team";
			this.txt_team.Size = new System.Drawing.Size(37, 20);
			this.txt_team.TabIndex = 9;
			this.txt_team.Text = "Null";
			// 
			// label_team
			// 
			this.label_team.AutoSize = true;
			this.label_team.Location = new System.Drawing.Point(47, 316);
			this.label_team.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label_team.Name = "label_team";
			this.label_team.Size = new System.Drawing.Size(24, 20);
			this.label_team.TabIndex = 8;
			this.label_team.Text = "팀";
			// 
			// txt_department
			// 
			this.txt_department.AutoSize = true;
			this.txt_department.Location = new System.Drawing.Point(127, 283);
			this.txt_department.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.txt_department.Name = "txt_department";
			this.txt_department.Size = new System.Drawing.Size(37, 20);
			this.txt_department.TabIndex = 7;
			this.txt_department.Text = "Null";
			// 
			// label_dapartment
			// 
			this.label_dapartment.AutoSize = true;
			this.label_dapartment.Location = new System.Drawing.Point(47, 283);
			this.label_dapartment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label_dapartment.Name = "label_dapartment";
			this.label_dapartment.Size = new System.Drawing.Size(39, 20);
			this.label_dapartment.TabIndex = 6;
			this.label_dapartment.Text = "부서";
			// 
			// txt_nick
			// 
			this.txt_nick.AutoSize = true;
			this.txt_nick.Location = new System.Drawing.Point(127, 246);
			this.txt_nick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.txt_nick.Name = "txt_nick";
			this.txt_nick.Size = new System.Drawing.Size(37, 20);
			this.txt_nick.TabIndex = 5;
			this.txt_nick.Text = "Null";
			// 
			// btn_main_logout
			// 
			this.btn_main_logout.ForeColor = System.Drawing.Color.Black;
			this.btn_main_logout.Location = new System.Drawing.Point(26, 353);
			this.btn_main_logout.Margin = new System.Windows.Forms.Padding(2);
			this.btn_main_logout.Name = "btn_main_logout";
			this.btn_main_logout.Size = new System.Drawing.Size(179, 32);
			this.btn_main_logout.TabIndex = 4;
			this.btn_main_logout.Text = "로그아웃";
			this.btn_main_logout.UseVisualStyleBackColor = true;
			this.btn_main_logout.Click += new System.EventHandler(this.btn_main_logout_Click);
			// 
			// label_alterProfile
			// 
			this.label_alterProfile.AutoSize = true;
			this.label_alterProfile.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label_alterProfile.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label_alterProfile.Location = new System.Drawing.Point(127, 21);
			this.label_alterProfile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label_alterProfile.Name = "label_alterProfile";
			this.label_alterProfile.Size = new System.Drawing.Size(84, 19);
			this.label_alterProfile.TabIndex = 2;
			this.label_alterProfile.Text = "프로필 변경";
			this.label_alterProfile.Click += new System.EventHandler(this.label_profile_click);
			// 
			// profile_nick
			// 
			this.profile_nick.AutoSize = true;
			this.profile_nick.Location = new System.Drawing.Point(47, 246);
			this.profile_nick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.profile_nick.Name = "profile_nick";
			this.profile_nick.Size = new System.Drawing.Size(54, 20);
			this.profile_nick.TabIndex = 1;
			this.profile_nick.Text = "닉네임";
			// 
			// main_profile
			// 
			this.main_profile.Location = new System.Drawing.Point(26, 50);
			this.main_profile.Margin = new System.Windows.Forms.Padding(2);
			this.main_profile.Name = "main_profile";
			this.main_profile.Size = new System.Drawing.Size(179, 172);
			this.main_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.main_profile.TabIndex = 0;
			this.main_profile.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(716, 225);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(34, 33);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// textBoxMyID
			// 
			this.textBoxMyID.Location = new System.Drawing.Point(1019, 43);
			this.textBoxMyID.Name = "textBoxMyID";
			this.textBoxMyID.Size = new System.Drawing.Size(108, 23);
			this.textBoxMyID.TabIndex = 4;
			// 
			// textBoxIPAdress
			// 
			this.textBoxIPAdress.Location = new System.Drawing.Point(1158, 43);
			this.textBoxIPAdress.Name = "textBoxIPAdress";
			this.textBoxIPAdress.Size = new System.Drawing.Size(108, 23);
			this.textBoxIPAdress.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1028, 377);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(134, 43);
			this.button1.TabIndex = 7;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(1033, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 15);
			this.label1.TabIndex = 9;
			this.label1.Text = "label1";
			// 
			// Info
			// 
			this.Info.AutoSize = true;
			this.Info.ForeColor = System.Drawing.Color.White;
			this.Info.Location = new System.Drawing.Point(1105, 19);
			this.Info.Name = "Info";
			this.Info.Size = new System.Drawing.Size(39, 15);
			this.Info.TabIndex = 10;
			this.Info.Text = "label2";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.생일ToolStripMenuItem,
            this.테마변경ToolStripMenuItem,
            this.뉴스검색ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 465);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1306, 24);
			this.menuStrip1.TabIndex = 11;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 생일ToolStripMenuItem
			// 
			this.생일ToolStripMenuItem.Name = "생일ToolStripMenuItem";
			this.생일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.생일ToolStripMenuItem.Text = "생일";
			this.생일ToolStripMenuItem.Click += new System.EventHandler(this.생일ToolStripMenuItem_Click);
			// 
			// 테마변경ToolStripMenuItem
			// 
			this.테마변경ToolStripMenuItem.Name = "테마변경ToolStripMenuItem";
			this.테마변경ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.테마변경ToolStripMenuItem.Text = "테마 변경";
			this.테마변경ToolStripMenuItem.Click += new System.EventHandler(this.테마변경ToolStripMenuItem_Click);
			// 
			// 뉴스검색ToolStripMenuItem
			// 
			this.뉴스검색ToolStripMenuItem.Name = "뉴스검색ToolStripMenuItem";
			this.뉴스검색ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.뉴스검색ToolStripMenuItem.Text = "뉴스 검색";
			this.뉴스검색ToolStripMenuItem.Click += new System.EventHandler(this.뉴스검색ToolStripMenuItem_Click);
			// 
			// Form_main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(1306, 489);
			this.Controls.Add(this.Info);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBoxIPAdress);
			this.Controls.Add(this.textBoxMyID);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.group_profile);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form_main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Form_main";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_main_FormClosing);
			this.Load += new System.EventHandler(this.Form_main_Load_1);
			this.groupBox1.ResumeLayout(false);
			this.group_profile.ResumeLayout(false);
			this.group_profile.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.main_profile)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TreeView treeView1;
        private ListBox listBox1;
        private GroupBox group_profile;
        private Label profile_nick;
        private PictureBox main_profile;
        private PictureBox pictureBox1;
        private Label label_alterProfile;
        private Label txt_team;
        private Label label_team;
        private Label txt_department;
        private Label label_dapartment;
        private Label txt_nick;
        private Button btn_main_logout;
        private OpenFileDialog openFileDialog1;
        private TextBox textBoxMyID;
        private TextBox textBoxIPAdress;
        private Button button1;
        private Label label1;
        private Label Info;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 생일ToolStripMenuItem;
        private ToolStripMenuItem 테마변경ToolStripMenuItem;
        private ToolStripMenuItem 뉴스검색ToolStripMenuItem;
    }
}