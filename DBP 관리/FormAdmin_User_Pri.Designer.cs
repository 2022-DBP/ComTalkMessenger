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
			this.label_Pri_Listbox = new System.Windows.Forms.Label();
			this.button_Pri_Udt = new System.Windows.Forms.Button();
			this.checkBox_Pri_User = new System.Windows.Forms.CheckBox();
			this.checkBox_Pri_Chat = new System.Windows.Forms.CheckBox();
			this.treeView_Pri = new System.Windows.Forms.TreeView();
			this.SuspendLayout();
			// 
			// label_Pri_Title
			// 
			this.label_Pri_Title.AutoSize = true;
			this.label_Pri_Title.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_Pri_Title.ForeColor = System.Drawing.Color.White;
			this.label_Pri_Title.Location = new System.Drawing.Point(75, 43);
			this.label_Pri_Title.Name = "label_Pri_Title";
			this.label_Pri_Title.Size = new System.Drawing.Size(226, 35);
			this.label_Pri_Title.TabIndex = 0;
			this.label_Pri_Title.Text = "[사용자] 권한 조정";
			// 
			// label_Pri_Listbox
			// 
			this.label_Pri_Listbox.AutoSize = true;
			this.label_Pri_Listbox.ForeColor = System.Drawing.Color.White;
			this.label_Pri_Listbox.Location = new System.Drawing.Point(42, 136);
			this.label_Pri_Listbox.Name = "label_Pri_Listbox";
			this.label_Pri_Listbox.Size = new System.Drawing.Size(124, 20);
			this.label_Pri_Listbox.TabIndex = 3;
			this.label_Pri_Listbox.Text = "다른 사용자 목록";
			// 
			// button_Pri_Udt
			// 
			this.button_Pri_Udt.BackColor = System.Drawing.Color.White;
			this.button_Pri_Udt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_Pri_Udt.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_Pri_Udt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_Pri_Udt.Location = new System.Drawing.Point(42, 455);
			this.button_Pri_Udt.Name = "button_Pri_Udt";
			this.button_Pri_Udt.Size = new System.Drawing.Size(285, 31);
			this.button_Pri_Udt.TabIndex = 4;
			this.button_Pri_Udt.Text = "적용하기";
			this.button_Pri_Udt.UseVisualStyleBackColor = false;
			this.button_Pri_Udt.Click += new System.EventHandler(this.button_Pri_Udt_Click);
			// 
			// checkBox_Pri_User
			// 
			this.checkBox_Pri_User.AutoSize = true;
			this.checkBox_Pri_User.ForeColor = System.Drawing.Color.White;
			this.checkBox_Pri_User.Location = new System.Drawing.Point(42, 95);
			this.checkBox_Pri_User.Name = "checkBox_Pri_User";
			this.checkBox_Pri_User.Size = new System.Drawing.Size(131, 24);
			this.checkBox_Pri_User.TabIndex = 5;
			this.checkBox_Pri_User.Text = "직원 보기 권한";
			this.checkBox_Pri_User.UseVisualStyleBackColor = true;
			// 
			// checkBox_Pri_Chat
			// 
			this.checkBox_Pri_Chat.AutoSize = true;
			this.checkBox_Pri_Chat.ForeColor = System.Drawing.Color.White;
			this.checkBox_Pri_Chat.Location = new System.Drawing.Point(196, 95);
			this.checkBox_Pri_Chat.Name = "checkBox_Pri_Chat";
			this.checkBox_Pri_Chat.Size = new System.Drawing.Size(131, 24);
			this.checkBox_Pri_Chat.TabIndex = 6;
			this.checkBox_Pri_Chat.Text = "직원 대화 권한";
			this.checkBox_Pri_Chat.UseVisualStyleBackColor = true;
			// 
			// treeView_Pri
			// 
			this.treeView_Pri.Location = new System.Drawing.Point(42, 159);
			this.treeView_Pri.Name = "treeView_Pri";
			this.treeView_Pri.Size = new System.Drawing.Size(286, 284);
			this.treeView_Pri.TabIndex = 7;
			// 
			// FormAdmin_User_Pri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(372, 511);
			this.Controls.Add(this.treeView_Pri);
			this.Controls.Add(this.checkBox_Pri_Chat);
			this.Controls.Add(this.checkBox_Pri_User);
			this.Controls.Add(this.button_Pri_Udt);
			this.Controls.Add(this.label_Pri_Listbox);
			this.Controls.Add(this.label_Pri_Title);
			this.Name = "FormAdmin_User_Pri";
			this.Text = "사용자 권한 조정";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label_Pri_Title;
		private Label label_Pri_Listbox;
		private Button button_Pri_Udt;
		private CheckBox checkBox_Pri_User;
		private CheckBox checkBox_Pri_Chat;
		private TreeView treeView_Pri;
	}
}