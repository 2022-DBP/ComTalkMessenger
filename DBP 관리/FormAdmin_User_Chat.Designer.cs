namespace DBP_관리
{
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
			this.label_Chat_Title = new System.Windows.Forms.Label();
			this.listBox_Chat = new System.Windows.Forms.ListBox();
			this.textBox_Chat_Search = new System.Windows.Forms.TextBox();
			this.button_Chat_Search = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label_Chat_Title
			// 
			this.label_Chat_Title.AutoSize = true;
			this.label_Chat_Title.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_Chat_Title.ForeColor = System.Drawing.Color.White;
			this.label_Chat_Title.Location = new System.Drawing.Point(60, 19);
			this.label_Chat_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label_Chat_Title.Name = "label_Chat_Title";
			this.label_Chat_Title.Size = new System.Drawing.Size(180, 28);
			this.label_Chat_Title.TabIndex = 11;
			this.label_Chat_Title.Text = "[사용자] 로그 검색";
			// 
			// listBox_Chat
			// 
			this.listBox_Chat.FormattingEnabled = true;
			this.listBox_Chat.ItemHeight = 15;
			this.listBox_Chat.Location = new System.Drawing.Point(34, 104);
			this.listBox_Chat.Margin = new System.Windows.Forms.Padding(2);
			this.listBox_Chat.Name = "listBox_Chat";
			this.listBox_Chat.Size = new System.Drawing.Size(220, 259);
			this.listBox_Chat.TabIndex = 10;
			// 
			// textBox_Chat_Search
			// 
			this.textBox_Chat_Search.Location = new System.Drawing.Point(34, 68);
			this.textBox_Chat_Search.Margin = new System.Windows.Forms.Padding(2);
			this.textBox_Chat_Search.Name = "textBox_Chat_Search";
			this.textBox_Chat_Search.Size = new System.Drawing.Size(142, 23);
			this.textBox_Chat_Search.TabIndex = 9;
			// 
			// button_Chat_Search
			// 
			this.button_Chat_Search.BackColor = System.Drawing.Color.White;
			this.button_Chat_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_Chat_Search.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_Chat_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_Chat_Search.Location = new System.Drawing.Point(181, 67);
			this.button_Chat_Search.Margin = new System.Windows.Forms.Padding(2);
			this.button_Chat_Search.Name = "button_Chat_Search";
			this.button_Chat_Search.Size = new System.Drawing.Size(73, 22);
			this.button_Chat_Search.TabIndex = 8;
			this.button_Chat_Search.Text = "로그 검색";
			this.button_Chat_Search.UseVisualStyleBackColor = false;
			this.button_Chat_Search.Click += new System.EventHandler(this.button_Chat_Search_Click);
			// 
			// FormAdmin_User_Chat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(289, 383);
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

        private Label label_Chat_Title;
        private ListBox listBox_Chat;
        private TextBox textBox_Chat_Search;
        private Button button_Chat_Search;
    }
}