namespace DBP_관리 {
	partial class FormAdmin_User_Pri {
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
			this.label_Pri_Title = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.직원보기권한ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.대화권한ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listBox_Pri = new System.Windows.Forms.ListBox();
			this.label_Pri_Listbox = new System.Windows.Forms.Label();
			this.button_Pri_Udt = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label_Pri_Title
			// 
			this.label_Pri_Title.AutoSize = true;
			this.label_Pri_Title.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_Pri_Title.ForeColor = System.Drawing.Color.White;
			this.label_Pri_Title.Location = new System.Drawing.Point(58, 32);
			this.label_Pri_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label_Pri_Title.Name = "label_Pri_Title";
			this.label_Pri_Title.Size = new System.Drawing.Size(180, 28);
			this.label_Pri_Title.TabIndex = 0;
			this.label_Pri_Title.Text = "[사용자] 권한 조정";
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.직원보기권한ToolStripMenuItem,
            this.대화권한ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(289, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 직원보기권한ToolStripMenuItem
			// 
			this.직원보기권한ToolStripMenuItem.Name = "직원보기권한ToolStripMenuItem";
			this.직원보기권한ToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
			this.직원보기권한ToolStripMenuItem.Text = "직원 보기 권한";
			// 
			// 대화권한ToolStripMenuItem
			// 
			this.대화권한ToolStripMenuItem.Name = "대화권한ToolStripMenuItem";
			this.대화권한ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.대화권한ToolStripMenuItem.Text = "대화 권한";
			// 
			// listBox_Pri
			// 
			this.listBox_Pri.FormattingEnabled = true;
			this.listBox_Pri.ItemHeight = 15;
			this.listBox_Pri.Location = new System.Drawing.Point(33, 89);
			this.listBox_Pri.Margin = new System.Windows.Forms.Padding(2);
			this.listBox_Pri.Name = "listBox_Pri";
			this.listBox_Pri.Size = new System.Drawing.Size(223, 244);
			this.listBox_Pri.TabIndex = 2;
			// 
			// label_Pri_Listbox
			// 
			this.label_Pri_Listbox.AutoSize = true;
			this.label_Pri_Listbox.ForeColor = System.Drawing.Color.White;
			this.label_Pri_Listbox.Location = new System.Drawing.Point(33, 72);
			this.label_Pri_Listbox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label_Pri_Listbox.Name = "label_Pri_Listbox";
			this.label_Pri_Listbox.Size = new System.Drawing.Size(99, 15);
			this.label_Pri_Listbox.TabIndex = 3;
			this.label_Pri_Listbox.Text = "다른 사용자 목록";
			// 
			// button_Pri_Udt
			// 
			this.button_Pri_Udt.BackColor = System.Drawing.Color.White;
			this.button_Pri_Udt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_Pri_Udt.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_Pri_Udt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_Pri_Udt.Location = new System.Drawing.Point(33, 341);
			this.button_Pri_Udt.Margin = new System.Windows.Forms.Padding(2);
			this.button_Pri_Udt.Name = "button_Pri_Udt";
			this.button_Pri_Udt.Size = new System.Drawing.Size(222, 23);
			this.button_Pri_Udt.TabIndex = 4;
			this.button_Pri_Udt.Text = "적용하기";
			this.button_Pri_Udt.UseVisualStyleBackColor = false;
			this.button_Pri_Udt.Click += new System.EventHandler(this.button_Pri_Udt_Click);
			// 
			// FormAdmin_User_Pri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(289, 383);
			this.Controls.Add(this.button_Pri_Udt);
			this.Controls.Add(this.label_Pri_Listbox);
			this.Controls.Add(this.listBox_Pri);
			this.Controls.Add(this.label_Pri_Title);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormAdmin_User_Pri";
			this.Text = "사용자 권한 조정";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label_Pri_Title;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem 직원보기권한ToolStripMenuItem;
		private ToolStripMenuItem 대화권한ToolStripMenuItem;
		private ListBox listBox_Pri;
		private Label label_Pri_Listbox;
		private Button button_Pri_Udt;
	}
}