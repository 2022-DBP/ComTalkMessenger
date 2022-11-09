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
			this.부서관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.사용자관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button_Dpt_Search = new System.Windows.Forms.Button();
			this.button_Dpt_Plus = new System.Windows.Forms.Button();
			this.label_Dpt_Title = new System.Windows.Forms.Label();
			this.button_Dpt_Udt = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.부서관리ToolStripMenuItem,
            this.사용자관리ToolStripMenuItem,
            this.로그아웃ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 464);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(534, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 부서관리ToolStripMenuItem
			// 
			this.부서관리ToolStripMenuItem.Name = "부서관리ToolStripMenuItem";
			this.부서관리ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.부서관리ToolStripMenuItem.Text = "부서 관리";
			this.부서관리ToolStripMenuItem.Click += new System.EventHandler(this.부서관리ToolStripMenuItem_Click);
			// 
			// 사용자관리ToolStripMenuItem
			// 
			this.사용자관리ToolStripMenuItem.Name = "사용자관리ToolStripMenuItem";
			this.사용자관리ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
			this.사용자관리ToolStripMenuItem.Text = "사용자 관리";
			this.사용자관리ToolStripMenuItem.Click += new System.EventHandler(this.사용자관리ToolStripMenuItem_Click);
			// 
			// 로그아웃ToolStripMenuItem
			// 
			this.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
			this.로그아웃ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.로그아웃ToolStripMenuItem.Text = "로그아웃";
			this.로그아웃ToolStripMenuItem.Click += new System.EventHandler(this.로그아웃ToolStripMenuItem_Click);
			// 
			// button_Dpt_Search
			// 
			this.button_Dpt_Search.BackColor = System.Drawing.Color.White;
			this.button_Dpt_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_Dpt_Search.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_Dpt_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_Dpt_Search.Location = new System.Drawing.Point(290, 23);
			this.button_Dpt_Search.Margin = new System.Windows.Forms.Padding(2);
			this.button_Dpt_Search.Name = "button_Dpt_Search";
			this.button_Dpt_Search.Size = new System.Drawing.Size(51, 43);
			this.button_Dpt_Search.TabIndex = 6;
			this.button_Dpt_Search.Text = "검색";
			this.button_Dpt_Search.UseVisualStyleBackColor = false;
			this.button_Dpt_Search.Click += new System.EventHandler(this.button_Dpt_Search_Click);
			// 
			// button_Dpt_Plus
			// 
			this.button_Dpt_Plus.BackColor = System.Drawing.Color.White;
			this.button_Dpt_Plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_Dpt_Plus.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_Dpt_Plus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_Dpt_Plus.Location = new System.Drawing.Point(317, 42);
			this.button_Dpt_Plus.Margin = new System.Windows.Forms.Padding(2);
			this.button_Dpt_Plus.Name = "button_Dpt_Plus";
			this.button_Dpt_Plus.Size = new System.Drawing.Size(75, 22);
			this.button_Dpt_Plus.TabIndex = 7;
			this.button_Dpt_Plus.Text = "부서 추가";
			this.button_Dpt_Plus.UseVisualStyleBackColor = false;
			this.button_Dpt_Plus.Click += new System.EventHandler(this.button_Dpt_Plus_Click);
			// 
			// label_Dpt_Title
			// 
			this.label_Dpt_Title.AutoSize = true;
			this.label_Dpt_Title.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_Dpt_Title.ForeColor = System.Drawing.Color.White;
			this.label_Dpt_Title.Location = new System.Drawing.Point(29, 14);
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
			this.button_Dpt_Udt.Location = new System.Drawing.Point(410, 42);
			this.button_Dpt_Udt.Margin = new System.Windows.Forms.Padding(2);
			this.button_Dpt_Udt.Name = "button_Dpt_Udt";
			this.button_Dpt_Udt.Size = new System.Drawing.Size(75, 22);
			this.button_Dpt_Udt.TabIndex = 10;
			this.button_Dpt_Udt.Text = "부서 수정";
			this.button_Dpt_Udt.UseVisualStyleBackColor = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.treeView1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.button_Dpt_Search);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(29, 68);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(456, 386);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "조회";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(37, 56);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 19);
			this.label2.TabIndex = 15;
			this.label2.Text = "확장";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(37, 23);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 19);
			this.label1.TabIndex = 14;
			this.label1.Text = "부서명";
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(37, 75);
			this.treeView1.Margin = new System.Windows.Forms.Padding(2);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(304, 289);
			this.treeView1.TabIndex = 13;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox1.Location = new System.Drawing.Point(89, 23);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(197, 26);
			this.textBox1.TabIndex = 12;
			// 
			// FormAdmin_Dpt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(534, 488);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label_Dpt_Title);
			this.Controls.Add(this.button_Dpt_Udt);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.button_Dpt_Plus);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormAdmin_Dpt";
			this.Text = "부서 관리";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MenuStrip menuStrip1;
		private ToolStripMenuItem 부서관리ToolStripMenuItem;
		private Button button_Dpt_Search;
		private Button button_Dpt_Plus;
		private ToolStripMenuItem 사용자관리ToolStripMenuItem;
		private ToolStripMenuItem 로그아웃ToolStripMenuItem;
		private Label label_Dpt_Title;
		private Button button_Dpt_Udt;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private TreeView treeView1;
        private Label label1;
        private Label label2;
    }
}