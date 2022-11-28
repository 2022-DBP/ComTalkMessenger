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
			this.label_Pri_Visible = new System.Windows.Forms.Label();
			this.button_Pri_Visible = new System.Windows.Forms.Button();
			this.groupBox_Pri_Visible = new System.Windows.Forms.GroupBox();
			this.treeView_Pri_Visible = new System.Windows.Forms.TreeView();
			this.groupBox_Pri_Chat = new System.Windows.Forms.GroupBox();
			this.treeView_Pri_Chat = new System.Windows.Forms.TreeView();
			this.button_Pri_Chat = new System.Windows.Forms.Button();
			this.label_Pri_Chat = new System.Windows.Forms.Label();
			this.groupBox_Pri_Visible.SuspendLayout();
			this.groupBox_Pri_Chat.SuspendLayout();
			this.SuspendLayout();
			// 
			// label_Pri_Title
			// 
			this.label_Pri_Title.AutoSize = true;
			this.label_Pri_Title.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_Pri_Title.ForeColor = System.Drawing.Color.White;
			this.label_Pri_Title.Location = new System.Drawing.Point(29, 14);
			this.label_Pri_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label_Pri_Title.Name = "label_Pri_Title";
			this.label_Pri_Title.Size = new System.Drawing.Size(244, 37);
			this.label_Pri_Title.TabIndex = 0;
			this.label_Pri_Title.Text = "[사용자] 권한 조정";
			// 
			// label_Pri_Visible
			// 
			this.label_Pri_Visible.AutoSize = true;
			this.label_Pri_Visible.ForeColor = System.Drawing.Color.White;
			this.label_Pri_Visible.Location = new System.Drawing.Point(21, 28);
			this.label_Pri_Visible.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label_Pri_Visible.Name = "label_Pri_Visible";
			this.label_Pri_Visible.Size = new System.Drawing.Size(167, 15);
			this.label_Pri_Visible.TabIndex = 3;
			this.label_Pri_Visible.Text = "보기 제한할 다른 사용자 목록";
			// 
			// button_Pri_Visible
			// 
			this.button_Pri_Visible.BackColor = System.Drawing.Color.White;
			this.button_Pri_Visible.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_Pri_Visible.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_Pri_Visible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_Pri_Visible.Location = new System.Drawing.Point(21, 396);
			this.button_Pri_Visible.Margin = new System.Windows.Forms.Padding(2);
			this.button_Pri_Visible.Name = "button_Pri_Visible";
			this.button_Pri_Visible.Size = new System.Drawing.Size(361, 23);
			this.button_Pri_Visible.TabIndex = 4;
			this.button_Pri_Visible.Text = "적용하기";
			this.button_Pri_Visible.UseVisualStyleBackColor = false;
			// 
			// groupBox_Pri_Visible
			// 
			this.groupBox_Pri_Visible.Controls.Add(this.treeView_Pri_Visible);
			this.groupBox_Pri_Visible.Controls.Add(this.button_Pri_Visible);
			this.groupBox_Pri_Visible.Controls.Add(this.label_Pri_Visible);
			this.groupBox_Pri_Visible.ForeColor = System.Drawing.Color.White;
			this.groupBox_Pri_Visible.Location = new System.Drawing.Point(29, 68);
			this.groupBox_Pri_Visible.Name = "groupBox_Pri_Visible";
			this.groupBox_Pri_Visible.Size = new System.Drawing.Size(409, 435);
			this.groupBox_Pri_Visible.TabIndex = 9;
			this.groupBox_Pri_Visible.TabStop = false;
			this.groupBox_Pri_Visible.Text = "직원 보기 권한 조정";
			// 
			// treeView_Pri_Visible
			// 
			this.treeView_Pri_Visible.Location = new System.Drawing.Point(21, 45);
			this.treeView_Pri_Visible.Margin = new System.Windows.Forms.Padding(2);
			this.treeView_Pri_Visible.Name = "treeView_Pri_Visible";
			this.treeView_Pri_Visible.Size = new System.Drawing.Size(361, 341);
			this.treeView_Pri_Visible.TabIndex = 8;
			// 
			// groupBox_Pri_Chat
			// 
			this.groupBox_Pri_Chat.Controls.Add(this.treeView_Pri_Chat);
			this.groupBox_Pri_Chat.Controls.Add(this.button_Pri_Chat);
			this.groupBox_Pri_Chat.Controls.Add(this.label_Pri_Chat);
			this.groupBox_Pri_Chat.ForeColor = System.Drawing.Color.White;
			this.groupBox_Pri_Chat.Location = new System.Drawing.Point(456, 68);
			this.groupBox_Pri_Chat.Name = "groupBox_Pri_Chat";
			this.groupBox_Pri_Chat.Size = new System.Drawing.Size(409, 435);
			this.groupBox_Pri_Chat.TabIndex = 10;
			this.groupBox_Pri_Chat.TabStop = false;
			this.groupBox_Pri_Chat.Text = "직원 대화 권한 조정";
			// 
			// treeView_Pri_Chat
			// 
			this.treeView_Pri_Chat.Location = new System.Drawing.Point(21, 45);
			this.treeView_Pri_Chat.Margin = new System.Windows.Forms.Padding(2);
			this.treeView_Pri_Chat.Name = "treeView_Pri_Chat";
			this.treeView_Pri_Chat.Size = new System.Drawing.Size(361, 341);
			this.treeView_Pri_Chat.TabIndex = 8;
			// 
			// button_Pri_Chat
			// 
			this.button_Pri_Chat.BackColor = System.Drawing.Color.White;
			this.button_Pri_Chat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_Pri_Chat.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_Pri_Chat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_Pri_Chat.Location = new System.Drawing.Point(21, 396);
			this.button_Pri_Chat.Margin = new System.Windows.Forms.Padding(2);
			this.button_Pri_Chat.Name = "button_Pri_Chat";
			this.button_Pri_Chat.Size = new System.Drawing.Size(361, 23);
			this.button_Pri_Chat.TabIndex = 4;
			this.button_Pri_Chat.Text = "적용하기";
			this.button_Pri_Chat.UseVisualStyleBackColor = false;
			// 
			// label_Pri_Chat
			// 
			this.label_Pri_Chat.AutoSize = true;
			this.label_Pri_Chat.ForeColor = System.Drawing.Color.White;
			this.label_Pri_Chat.Location = new System.Drawing.Point(21, 28);
			this.label_Pri_Chat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label_Pri_Chat.Name = "label_Pri_Chat";
			this.label_Pri_Chat.Size = new System.Drawing.Size(167, 15);
			this.label_Pri_Chat.TabIndex = 3;
			this.label_Pri_Chat.Text = "대화 제한할 다른 사용자 목록";
			// 
			// FormAdmin_User_Pri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(899, 547);
			this.Controls.Add(this.groupBox_Pri_Chat);
			this.Controls.Add(this.groupBox_Pri_Visible);
			this.Controls.Add(this.label_Pri_Title);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormAdmin_User_Pri";
			this.Text = "사용자 권한 조정";
			this.groupBox_Pri_Visible.ResumeLayout(false);
			this.groupBox_Pri_Visible.PerformLayout();
			this.groupBox_Pri_Chat.ResumeLayout(false);
			this.groupBox_Pri_Chat.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label_Pri_Title;
		private Label label_Pri_Visible;
		private Button button_Pri_Visible;
		private GroupBox groupBox_Pri_Visible;
		private TreeView treeView_Pri_Visible;
		private GroupBox groupBox_Pri_Chat;
		private TreeView treeView_Pri_Chat;
		private Button button_Pri_Chat;
		private Label label_Pri_Chat;
	}
}