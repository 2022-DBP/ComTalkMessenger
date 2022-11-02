namespace DBP_관리 {
	partial class FormAdmin_Dpt {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.메인화면ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.사용자관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listBox_Dpt = new System.Windows.Forms.ListBox();
			this.textBox_Dpt_Search = new System.Windows.Forms.TextBox();
			this.button_Dpt_Search = new System.Windows.Forms.Button();
			this.button_Dpt_Plus = new System.Windows.Forms.Button();
			this.label_Dpt_Title = new System.Windows.Forms.Label();
			this.button_Dpt_Udt = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메인화면ToolStripMenuItem,
            this.사용자관리ToolStripMenuItem,
            this.로그아웃ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 404);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(366, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 메인화면ToolStripMenuItem
			// 
			this.메인화면ToolStripMenuItem.Name = "메인화면ToolStripMenuItem";
			this.메인화면ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.메인화면ToolStripMenuItem.Text = "부서 관리";
			this.메인화면ToolStripMenuItem.Click += new System.EventHandler(this.메인화면ToolStripMenuItem_Click);
			// 
			// 사용자관리ToolStripMenuItem
			// 
			this.사용자관리ToolStripMenuItem.Name = "사용자관리ToolStripMenuItem";
			this.사용자관리ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
			this.사용자관리ToolStripMenuItem.Text = "사용자 관리";
			// 
			// 로그아웃ToolStripMenuItem
			// 
			this.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
			this.로그아웃ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.로그아웃ToolStripMenuItem.Text = "로그아웃";
			// 
			// listBox_Dpt
			// 
			this.listBox_Dpt.FormattingEnabled = true;
			this.listBox_Dpt.ItemHeight = 15;
			this.listBox_Dpt.Location = new System.Drawing.Point(29, 97);
			this.listBox_Dpt.Margin = new System.Windows.Forms.Padding(2);
			this.listBox_Dpt.Name = "listBox_Dpt";
			this.listBox_Dpt.Size = new System.Drawing.Size(311, 259);
			this.listBox_Dpt.TabIndex = 4;
			// 
			// textBox_Dpt_Search
			// 
			this.textBox_Dpt_Search.Location = new System.Drawing.Point(29, 65);
			this.textBox_Dpt_Search.Margin = new System.Windows.Forms.Padding(2);
			this.textBox_Dpt_Search.Name = "textBox_Dpt_Search";
			this.textBox_Dpt_Search.Size = new System.Drawing.Size(220, 23);
			this.textBox_Dpt_Search.TabIndex = 5;
			// 
			// button_Dpt_Search
			// 
			this.button_Dpt_Search.BackColor = System.Drawing.Color.White;
			this.button_Dpt_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_Dpt_Search.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_Dpt_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_Dpt_Search.Location = new System.Drawing.Point(266, 64);
			this.button_Dpt_Search.Margin = new System.Windows.Forms.Padding(2);
			this.button_Dpt_Search.Name = "button_Dpt_Search";
			this.button_Dpt_Search.Size = new System.Drawing.Size(73, 22);
			this.button_Dpt_Search.TabIndex = 6;
			this.button_Dpt_Search.Text = "검색";
			this.button_Dpt_Search.UseVisualStyleBackColor = false;
			// 
			// button_Dpt_Plus
			// 
			this.button_Dpt_Plus.BackColor = System.Drawing.Color.White;
			this.button_Dpt_Plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_Dpt_Plus.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_Dpt_Plus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_Dpt_Plus.Location = new System.Drawing.Point(42, 370);
			this.button_Dpt_Plus.Margin = new System.Windows.Forms.Padding(2);
			this.button_Dpt_Plus.Name = "button_Dpt_Plus";
			this.button_Dpt_Plus.Size = new System.Drawing.Size(124, 22);
			this.button_Dpt_Plus.TabIndex = 7;
			this.button_Dpt_Plus.Text = "등록";
			this.button_Dpt_Plus.UseVisualStyleBackColor = false;
			// 
			// label_Dpt_Title
			// 
			this.label_Dpt_Title.AutoSize = true;
			this.label_Dpt_Title.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_Dpt_Title.ForeColor = System.Drawing.Color.White;
			this.label_Dpt_Title.Location = new System.Drawing.Point(120, 17);
			this.label_Dpt_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label_Dpt_Title.Name = "label_Dpt_Title";
			this.label_Dpt_Title.Size = new System.Drawing.Size(134, 37);
			this.label_Dpt_Title.TabIndex = 9;
			this.label_Dpt_Title.Text = "부서 관리";
			// 
			// button_Dpt_Udt
			// 
			this.button_Dpt_Udt.BackColor = System.Drawing.Color.White;
			this.button_Dpt_Udt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_Dpt_Udt.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_Dpt_Udt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_Dpt_Udt.Location = new System.Drawing.Point(194, 370);
			this.button_Dpt_Udt.Margin = new System.Windows.Forms.Padding(2);
			this.button_Dpt_Udt.Name = "button_Dpt_Udt";
			this.button_Dpt_Udt.Size = new System.Drawing.Size(124, 22);
			this.button_Dpt_Udt.TabIndex = 10;
			this.button_Dpt_Udt.Text = "수정";
			this.button_Dpt_Udt.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(11, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 37);
			this.label1.TabIndex = 11;
			this.label1.Text = "test";
			// 
			// FormAdmin_Dpt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(366, 428);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button_Dpt_Udt);
			this.Controls.Add(this.label_Dpt_Title);
			this.Controls.Add(this.button_Dpt_Plus);
			this.Controls.Add(this.button_Dpt_Search);
			this.Controls.Add(this.textBox_Dpt_Search);
			this.Controls.Add(this.listBox_Dpt);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormAdmin_Dpt";
			this.Text = "부서 관리";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MenuStrip menuStrip1;
		private ToolStripMenuItem 메인화면ToolStripMenuItem;
		private ListBox listBox_Dpt;
		private TextBox textBox_Dpt_Search;
		private Button button_Dpt_Search;
		private Button button_Dpt_Plus;
		private ToolStripMenuItem 사용자관리ToolStripMenuItem;
		private ToolStripMenuItem 로그아웃ToolStripMenuItem;
		private Label label_Dpt_Title;
		private Button button_Dpt_Udt;
		private Label label1;
	}
}