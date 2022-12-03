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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.profile_nick = new System.Windows.Forms.Label();
            this.label_alterProfile = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.group_profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(661, 57);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 504);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBoxChattingList_SelectedIndexChanged);
            // 
            // group_profile
            // 
            this.group_profile.Controls.Add(this.label_alterProfile);
            this.group_profile.Controls.Add(this.profile_nick);
            this.group_profile.Controls.Add(this.pictureBox2);
            this.group_profile.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group_profile.ForeColor = System.Drawing.Color.White;
            this.group_profile.Location = new System.Drawing.Point(982, 19);
            this.group_profile.Name = "group_profile";
            this.group_profile.Size = new System.Drawing.Size(303, 542);
            this.group_profile.TabIndex = 2;
            this.group_profile.TabStop = false;
            this.group_profile.Text = "프로필";
            this.group_profile.Enter += new System.EventHandler(this.group_profile_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(920, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 44);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(34, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(230, 230);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // profile_nick
            // 
            this.profile_nick.AutoSize = true;
            this.profile_nick.Location = new System.Drawing.Point(34, 313);
            this.profile_nick.Name = "profile_nick";
            this.profile_nick.Size = new System.Drawing.Size(69, 25);
            this.profile_nick.TabIndex = 1;
            this.profile_nick.Text = "닉네임";
            this.profile_nick.Click += new System.EventHandler(this.label1_Click);
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
            this.label_alterProfile.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1346, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.group_profile);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_main";
            this.Text = "Form_main";
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.groupBox1.ResumeLayout(false);
            this.group_profile.ResumeLayout(false);
            this.group_profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TreeView treeView1;
        private ListBox listBox1;
        private GroupBox group_profile;
        private Label profile_nick;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label_alterProfile;
    }
}