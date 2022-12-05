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
            this.groupBox1.SuspendLayout();
            this.group_profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Location = new System.Drawing.Point(15, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(624, 565);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "대화방생성";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(30, 39);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(547, 485);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Chatting);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 45;
            this.listBox1.Location = new System.Drawing.Point(661, 57);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 454);
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
            this.group_profile.Location = new System.Drawing.Point(982, 19);
            this.group_profile.Name = "group_profile";
            this.group_profile.Size = new System.Drawing.Size(303, 541);
            this.group_profile.TabIndex = 2;
            this.group_profile.TabStop = false;
            this.group_profile.Text = "프로필";
            // 
            // txt_team
            // 
            this.txt_team.AutoSize = true;
            this.txt_team.Location = new System.Drawing.Point(163, 421);
            this.txt_team.Name = "txt_team";
            this.txt_team.Size = new System.Drawing.Size(48, 25);
            this.txt_team.TabIndex = 9;
            this.txt_team.Text = "Null";
            // 
            // label_team
            // 
            this.label_team.AutoSize = true;
            this.label_team.Location = new System.Drawing.Point(60, 421);
            this.label_team.Name = "label_team";
            this.label_team.Size = new System.Drawing.Size(31, 25);
            this.label_team.TabIndex = 8;
            this.label_team.Text = "팀";
            // 
            // txt_department
            // 
            this.txt_department.AutoSize = true;
            this.txt_department.Location = new System.Drawing.Point(163, 377);
            this.txt_department.Name = "txt_department";
            this.txt_department.Size = new System.Drawing.Size(48, 25);
            this.txt_department.TabIndex = 7;
            this.txt_department.Text = "Null";
            // 
            // label_dapartment
            // 
            this.label_dapartment.AutoSize = true;
            this.label_dapartment.Location = new System.Drawing.Point(60, 377);
            this.label_dapartment.Name = "label_dapartment";
            this.label_dapartment.Size = new System.Drawing.Size(50, 25);
            this.label_dapartment.TabIndex = 6;
            this.label_dapartment.Text = "부서";
            // 
            // txt_nick
            // 
            this.txt_nick.AutoSize = true;
            this.txt_nick.Location = new System.Drawing.Point(163, 328);
            this.txt_nick.Name = "txt_nick";
            this.txt_nick.Size = new System.Drawing.Size(48, 25);
            this.txt_nick.TabIndex = 5;
            this.txt_nick.Text = "Null";
            // 
            // btn_main_logout
            // 
            this.btn_main_logout.ForeColor = System.Drawing.Color.Black;
            this.btn_main_logout.Location = new System.Drawing.Point(33, 471);
            this.btn_main_logout.Name = "btn_main_logout";
            this.btn_main_logout.Size = new System.Drawing.Size(230, 43);
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
            this.label_alterProfile.Location = new System.Drawing.Point(163, 28);
            this.label_alterProfile.Name = "label_alterProfile";
            this.label_alterProfile.Size = new System.Drawing.Size(101, 23);
            this.label_alterProfile.TabIndex = 2;
            this.label_alterProfile.Text = "프로필 변경";
            this.label_alterProfile.Click += new System.EventHandler(this.label_profile_click);
            // 
            // profile_nick
            // 
            this.profile_nick.AutoSize = true;
            this.profile_nick.Location = new System.Drawing.Point(60, 328);
            this.profile_nick.Name = "profile_nick";
            this.profile_nick.Size = new System.Drawing.Size(69, 25);
            this.profile_nick.TabIndex = 1;
            this.profile_nick.Text = "닉네임";
            // 
            // main_profile
            // 
            this.main_profile.Location = new System.Drawing.Point(33, 67);
            this.main_profile.Name = "main_profile";
            this.main_profile.Size = new System.Drawing.Size(230, 229);
            this.main_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.main_profile.TabIndex = 0;
            this.main_profile.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(921, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 44);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxMyID
            // 
            this.textBoxMyID.Location = new System.Drawing.Point(1310, 57);
            this.textBoxMyID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMyID.Name = "textBoxMyID";
            this.textBoxMyID.Size = new System.Drawing.Size(138, 27);
            this.textBoxMyID.TabIndex = 4;
            // 
            // textBoxIPAdress
            // 
            this.textBoxIPAdress.Location = new System.Drawing.Point(1489, 57);
            this.textBoxIPAdress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIPAdress.Name = "textBoxIPAdress";
            this.textBoxIPAdress.Size = new System.Drawing.Size(138, 27);
            this.textBoxIPAdress.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1322, 503);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 57);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1328, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.ForeColor = System.Drawing.Color.White;
            this.Info.Location = new System.Drawing.Point(1421, 25);
            this.Info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(50, 20);
            this.Info.TabIndex = 10;
            this.Info.Text = "label2";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1679, 600);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxIPAdress);
            this.Controls.Add(this.textBoxMyID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.group_profile);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}