namespace DBP_관리 {
	partial class FormAdmin_User {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.treeView_User = new System.Windows.Forms.TreeView();
			this.button_User_DptChange = new System.Windows.Forms.Button();
			this.button_User_Chat = new System.Windows.Forms.Button();
			this.label_User_Name = new System.Windows.Forms.Label();
			this.button_User_Pri = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.메인화면ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.사용자관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label_User_Title = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// treeView_User
			// 
			this.treeView_User.Location = new System.Drawing.Point(35, 91);
			this.treeView_User.Name = "treeView_User";
			this.treeView_User.Size = new System.Drawing.Size(399, 371);
			this.treeView_User.TabIndex = 0;
			// 
			// button_User_DptChange
			// 
			this.button_User_DptChange.BackColor = System.Drawing.Color.White;
			this.button_User_DptChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_User_DptChange.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_User_DptChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_User_DptChange.Location = new System.Drawing.Point(122, 485);
			this.button_User_DptChange.Name = "button_User_DptChange";
			this.button_User_DptChange.Size = new System.Drawing.Size(94, 29);
			this.button_User_DptChange.TabIndex = 1;
			this.button_User_DptChange.Text = "부서 변경";
			this.button_User_DptChange.UseVisualStyleBackColor = false;
			// 
			// button_User_Chat
			// 
			this.button_User_Chat.BackColor = System.Drawing.Color.White;
			this.button_User_Chat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_User_Chat.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_User_Chat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_User_Chat.Location = new System.Drawing.Point(234, 485);
			this.button_User_Chat.Name = "button_User_Chat";
			this.button_User_Chat.Size = new System.Drawing.Size(94, 29);
			this.button_User_Chat.TabIndex = 2;
			this.button_User_Chat.Text = "로그 검색";
			this.button_User_Chat.UseVisualStyleBackColor = false;
			// 
			// label_User_Name
			// 
			this.label_User_Name.AutoSize = true;
			this.label_User_Name.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_User_Name.ForeColor = System.Drawing.Color.White;
			this.label_User_Name.Location = new System.Drawing.Point(35, 486);
			this.label_User_Name.Name = "label_User_Name";
			this.label_User_Name.Size = new System.Drawing.Size(73, 23);
			this.label_User_Name.TabIndex = 3;
			this.label_User_Name.Text = "[사용자]";
			// 
			// button_User_Pri
			// 
			this.button_User_Pri.BackColor = System.Drawing.Color.White;
			this.button_User_Pri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_User_Pri.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_User_Pri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_User_Pri.Location = new System.Drawing.Point(339, 485);
			this.button_User_Pri.Name = "button_User_Pri";
			this.button_User_Pri.Size = new System.Drawing.Size(94, 29);
			this.button_User_Pri.TabIndex = 4;
			this.button_User_Pri.Text = "권한 조정";
			this.button_User_Pri.UseVisualStyleBackColor = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메인화면ToolStripMenuItem,
            this.사용자관리ToolStripMenuItem,
            this.로그아웃ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 542);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(471, 28);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 메인화면ToolStripMenuItem
			// 
			this.메인화면ToolStripMenuItem.Name = "메인화면ToolStripMenuItem";
			this.메인화면ToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
			this.메인화면ToolStripMenuItem.Text = "부서 관리";
			// 
			// 사용자관리ToolStripMenuItem
			// 
			this.사용자관리ToolStripMenuItem.Name = "사용자관리ToolStripMenuItem";
			this.사용자관리ToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
			this.사용자관리ToolStripMenuItem.Text = "사용자 관리";
			// 
			// 로그아웃ToolStripMenuItem
			// 
			this.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
			this.로그아웃ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
			this.로그아웃ToolStripMenuItem.Text = "로그아웃";
			// 
			// label_User_Title
			// 
			this.label_User_Title.AutoSize = true;
			this.label_User_Title.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_User_Title.ForeColor = System.Drawing.Color.White;
			this.label_User_Title.Location = new System.Drawing.Point(134, 23);
			this.label_User_Title.Name = "label_User_Title";
			this.label_User_Title.Size = new System.Drawing.Size(202, 46);
			this.label_User_Title.TabIndex = 6;
			this.label_User_Title.Text = "사용자 관리";
			// 
			// FormAdmin_User
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(471, 570);
			this.Controls.Add(this.label_User_Title);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.button_User_Pri);
			this.Controls.Add(this.label_User_Name);
			this.Controls.Add(this.button_User_Chat);
			this.Controls.Add(this.button_User_DptChange);
			this.Controls.Add(this.treeView_User);
			this.Name = "FormAdmin_User";
			this.Text = "사용자 관리";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TreeView treeView_User;
		private Button button_User_DptChange;
		private Button button_User_Chat;
		private Label label_User_Name;
		private Button button_User_Pri;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem 메인화면ToolStripMenuItem;
		private ToolStripMenuItem 사용자관리ToolStripMenuItem;
		private ToolStripMenuItem 로그아웃ToolStripMenuItem;
		private Label label_User_Title;
	}
}