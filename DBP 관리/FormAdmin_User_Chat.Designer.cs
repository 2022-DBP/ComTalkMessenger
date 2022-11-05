namespace DBP_관리 {
	partial class FormAdmin_User_Chat
	{
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
			this.listBox_Chat = new System.Windows.Forms.ListBox();
			this.label_Chat_Title = new System.Windows.Forms.Label();
			this.button_Chat_Search = new System.Windows.Forms.Button();
			this.textBox_Chat_Search = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// listBox_Chat
			// 
			this.listBox_Chat.FormattingEnabled = true;
			this.listBox_Chat.ItemHeight = 20;
			this.listBox_Chat.Location = new System.Drawing.Point(43, 142);
			this.listBox_Chat.Name = "listBox_Chat";
			this.listBox_Chat.Size = new System.Drawing.Size(282, 344);
			this.listBox_Chat.TabIndex = 2;
			// 
			// label_Chat_Title
			// 
			this.label_Chat_Title.AutoSize = true;
			this.label_Chat_Title.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_Chat_Title.ForeColor = System.Drawing.Color.White;
			this.label_Chat_Title.Location = new System.Drawing.Point(76, 28);
			this.label_Chat_Title.Name = "label_Chat_Title";
			this.label_Chat_Title.Size = new System.Drawing.Size(226, 35);
			this.label_Chat_Title.TabIndex = 7;
			this.label_Chat_Title.Text = "[사용자] 로그 검색";
			// 
			// button_Chat_Search
			// 
			this.button_Chat_Search.BackColor = System.Drawing.Color.White;
			this.button_Chat_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_Chat_Search.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_Chat_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_Chat_Search.Location = new System.Drawing.Point(231, 92);
			this.button_Chat_Search.Name = "button_Chat_Search";
			this.button_Chat_Search.Size = new System.Drawing.Size(94, 29);
			this.button_Chat_Search.TabIndex = 0;
			this.button_Chat_Search.Text = "로그 검색";
			this.button_Chat_Search.UseVisualStyleBackColor = false;
			// 
			// textBox_Chat_Search
			// 
			this.textBox_Chat_Search.Location = new System.Drawing.Point(43, 94);
			this.textBox_Chat_Search.Name = "textBox_Chat_Search";
			this.textBox_Chat_Search.Size = new System.Drawing.Size(182, 27);
			this.textBox_Chat_Search.TabIndex = 1;
			// 
			// FormAdmin_User_Chat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(371, 511);
			this.Controls.Add(this.label_Chat_Title);
			this.Controls.Add(this.listBox_Chat);
			this.Controls.Add(this.textBox_Chat_Search);
			this.Controls.Add(this.button_Chat_Search);
			this.Name = "FormAdmin_User_Chat";
			this.Text = "사용자 로그 검색";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private ListBox listBox_Chat;
		private Label label_Chat_Title;
		private Button button_Chat_Search;
		private TextBox textBox_Chat_Search;
	}
}