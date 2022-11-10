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
			this.부서관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.사용자관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label_User_Title = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox_User_DptChange = new System.Windows.Forms.GroupBox();
			this.label_User_DptChange_Name2 = new System.Windows.Forms.Label();
			this.label_User_DptChange_Name1 = new System.Windows.Forms.Label();
			this.treeView_User_DptChange = new System.Windows.Forms.TreeView();
			this.groupBox_User_Chat = new System.Windows.Forms.GroupBox();
			this.textBox_User_Chat = new System.Windows.Forms.TextBox();
			this.dataGridView_User_Chat = new System.Windows.Forms.DataGridView();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox_User_DptChange.SuspendLayout();
			this.groupBox_User_Chat.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_User_Chat)).BeginInit();
			this.SuspendLayout();
			// 
			// treeView_User
			// 
			this.treeView_User.Location = new System.Drawing.Point(14, 36);
			this.treeView_User.Margin = new System.Windows.Forms.Padding(2);
			this.treeView_User.Name = "treeView_User";
			this.treeView_User.Size = new System.Drawing.Size(333, 384);
			this.treeView_User.TabIndex = 0;
			this.treeView_User.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_User_AfterSelect);
			// 
			// button_User_DptChange
			// 
			this.button_User_DptChange.BackColor = System.Drawing.Color.White;
			this.button_User_DptChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_User_DptChange.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_User_DptChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_User_DptChange.Location = new System.Drawing.Point(238, 134);
			this.button_User_DptChange.Margin = new System.Windows.Forms.Padding(2);
			this.button_User_DptChange.Name = "button_User_DptChange";
			this.button_User_DptChange.Size = new System.Drawing.Size(223, 22);
			this.button_User_DptChange.TabIndex = 1;
			this.button_User_DptChange.Text = "부서 변경";
			this.button_User_DptChange.UseVisualStyleBackColor = false;
			this.button_User_DptChange.Click += new System.EventHandler(this.button_User_DptChange_Click);
			// 
			// button_User_Chat
			// 
			this.button_User_Chat.BackColor = System.Drawing.Color.White;
			this.button_User_Chat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_User_Chat.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_User_Chat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_User_Chat.Location = new System.Drawing.Point(345, 22);
			this.button_User_Chat.Margin = new System.Windows.Forms.Padding(2);
			this.button_User_Chat.Name = "button_User_Chat";
			this.button_User_Chat.Size = new System.Drawing.Size(116, 22);
			this.button_User_Chat.TabIndex = 2;
			this.button_User_Chat.Text = "로그 검색";
			this.button_User_Chat.UseVisualStyleBackColor = false;
			this.button_User_Chat.Click += new System.EventHandler(this.button_User_Chat_Click);
			// 
			// label_User_Name
			// 
			this.label_User_Name.AutoSize = true;
			this.label_User_Name.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_User_Name.ForeColor = System.Drawing.Color.White;
			this.label_User_Name.Location = new System.Drawing.Point(406, 68);
			this.label_User_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label_User_Name.Name = "label_User_Name";
			this.label_User_Name.Size = new System.Drawing.Size(164, 19);
			this.label_User_Name.TabIndex = 3;
			this.label_User_Name.Text = "관리할 사용자 : [사용자]";
			// 
			// button_User_Pri
			// 
			this.button_User_Pri.BackColor = System.Drawing.Color.White;
			this.button_User_Pri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_User_Pri.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_User_Pri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_User_Pri.Location = new System.Drawing.Point(574, 65);
			this.button_User_Pri.Margin = new System.Windows.Forms.Padding(2);
			this.button_User_Pri.Name = "button_User_Pri";
			this.button_User_Pri.Size = new System.Drawing.Size(73, 22);
			this.button_User_Pri.TabIndex = 4;
			this.button_User_Pri.Text = "권한 조정";
			this.button_User_Pri.UseVisualStyleBackColor = false;
			this.button_User_Pri.Click += new System.EventHandler(this.button_User_Pri_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.부서관리ToolStripMenuItem,
            this.사용자관리ToolStripMenuItem,
            this.로그아웃ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 523);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(899, 24);
			this.menuStrip1.TabIndex = 5;
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
			// label_User_Title
			// 
			this.label_User_Title.AutoSize = true;
			this.label_User_Title.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_User_Title.ForeColor = System.Drawing.Color.White;
			this.label_User_Title.Location = new System.Drawing.Point(29, 14);
			this.label_User_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label_User_Title.Name = "label_User_Title";
			this.label_User_Title.Size = new System.Drawing.Size(161, 37);
			this.label_User_Title.TabIndex = 6;
			this.label_User_Title.Text = "사용자 관리";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.treeView_User);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(29, 68);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(363, 435);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "조회";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "부서별 사용자 목록";
			// 
			// groupBox_User_DptChange
			// 
			this.groupBox_User_DptChange.Controls.Add(this.label_User_DptChange_Name2);
			this.groupBox_User_DptChange.Controls.Add(this.label_User_DptChange_Name1);
			this.groupBox_User_DptChange.Controls.Add(this.treeView_User_DptChange);
			this.groupBox_User_DptChange.Controls.Add(this.button_User_DptChange);
			this.groupBox_User_DptChange.ForeColor = System.Drawing.Color.White;
			this.groupBox_User_DptChange.Location = new System.Drawing.Point(406, 91);
			this.groupBox_User_DptChange.Name = "groupBox_User_DptChange";
			this.groupBox_User_DptChange.Size = new System.Drawing.Size(471, 203);
			this.groupBox_User_DptChange.TabIndex = 8;
			this.groupBox_User_DptChange.TabStop = false;
			this.groupBox_User_DptChange.Text = "부서 변경";
			// 
			// label_User_DptChange_Name2
			// 
			this.label_User_DptChange_Name2.AutoSize = true;
			this.label_User_DptChange_Name2.Location = new System.Drawing.Point(238, 92);
			this.label_User_DptChange_Name2.Name = "label_User_DptChange_Name2";
			this.label_User_DptChange_Name2.Size = new System.Drawing.Size(126, 15);
			this.label_User_DptChange_Name2.TabIndex = 2;
			this.label_User_DptChange_Name2.Text = "변경 소속 : [부서] [팀]";
			// 
			// label_User_DptChange_Name1
			// 
			this.label_User_DptChange_Name1.AutoSize = true;
			this.label_User_DptChange_Name1.Location = new System.Drawing.Point(238, 55);
			this.label_User_DptChange_Name1.Name = "label_User_DptChange_Name1";
			this.label_User_DptChange_Name1.Size = new System.Drawing.Size(126, 15);
			this.label_User_DptChange_Name1.TabIndex = 1;
			this.label_User_DptChange_Name1.Text = "현재 소속 : [부서] [팀]";
			// 
			// treeView_User_DptChange
			// 
			this.treeView_User_DptChange.Location = new System.Drawing.Point(10, 24);
			this.treeView_User_DptChange.Name = "treeView_User_DptChange";
			this.treeView_User_DptChange.Size = new System.Drawing.Size(222, 162);
			this.treeView_User_DptChange.TabIndex = 0;
			this.treeView_User_DptChange.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_User_DptChange_AfterSelect);
			// 
			// groupBox_User_Chat
			// 
			this.groupBox_User_Chat.Controls.Add(this.textBox_User_Chat);
			this.groupBox_User_Chat.Controls.Add(this.dataGridView_User_Chat);
			this.groupBox_User_Chat.Controls.Add(this.button_User_Chat);
			this.groupBox_User_Chat.ForeColor = System.Drawing.Color.White;
			this.groupBox_User_Chat.Location = new System.Drawing.Point(406, 300);
			this.groupBox_User_Chat.Name = "groupBox_User_Chat";
			this.groupBox_User_Chat.Size = new System.Drawing.Size(471, 203);
			this.groupBox_User_Chat.TabIndex = 9;
			this.groupBox_User_Chat.TabStop = false;
			this.groupBox_User_Chat.Text = "로그 검색";
			// 
			// textBox_User_Chat
			// 
			this.textBox_User_Chat.Location = new System.Drawing.Point(10, 22);
			this.textBox_User_Chat.Name = "textBox_User_Chat";
			this.textBox_User_Chat.Size = new System.Drawing.Size(330, 23);
			this.textBox_User_Chat.TabIndex = 1;
			// 
			// dataGridView_User_Chat
			// 
			this.dataGridView_User_Chat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_User_Chat.Location = new System.Drawing.Point(10, 51);
			this.dataGridView_User_Chat.Name = "dataGridView_User_Chat";
			this.dataGridView_User_Chat.RowTemplate.Height = 25;
			this.dataGridView_User_Chat.Size = new System.Drawing.Size(451, 137);
			this.dataGridView_User_Chat.TabIndex = 0;
			// 
			// FormAdmin_User
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(899, 547);
			this.Controls.Add(this.groupBox_User_Chat);
			this.Controls.Add(this.groupBox_User_DptChange);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label_User_Title);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.button_User_Pri);
			this.Controls.Add(this.label_User_Name);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormAdmin_User";
			this.Text = "사용자 관리";
			this.Load += new System.EventHandler(this.FormAdmin_User_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox_User_DptChange.ResumeLayout(false);
			this.groupBox_User_DptChange.PerformLayout();
			this.groupBox_User_Chat.ResumeLayout(false);
			this.groupBox_User_Chat.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_User_Chat)).EndInit();
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
		private ToolStripMenuItem 부서관리ToolStripMenuItem;
		private ToolStripMenuItem 사용자관리ToolStripMenuItem;
		private ToolStripMenuItem 로그아웃ToolStripMenuItem;
		private Label label_User_Title;
		private GroupBox groupBox1;
		private GroupBox groupBox_User_DptChange;
		private TreeView treeView_User_DptChange;
		private Label label_User_DptChange_Name1;
		private GroupBox groupBox_User_Chat;
		private Label label2;
		private DataGridView dataGridView_User_Chat;
		private Label label_User_DptChange_Name2;
		private TextBox textBox_User_Chat;
	}
}