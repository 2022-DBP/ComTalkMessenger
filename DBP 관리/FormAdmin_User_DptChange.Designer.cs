namespace DBP_관리 {
	partial class FormAdmin_User_DptChange {
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
			this.label_DptChange_Title = new System.Windows.Forms.Label();
			this.button_DptChange_Udt = new System.Windows.Forms.Button();
			this.listBox_DptChange = new System.Windows.Forms.ListBox();
			this.label_DptChange_Name = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label_DptChange_Title
			// 
			this.label_DptChange_Title.AutoSize = true;
			this.label_DptChange_Title.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_DptChange_Title.ForeColor = System.Drawing.Color.White;
			this.label_DptChange_Title.Location = new System.Drawing.Point(76, 28);
			this.label_DptChange_Title.Name = "label_DptChange_Title";
			this.label_DptChange_Title.Size = new System.Drawing.Size(226, 35);
			this.label_DptChange_Title.TabIndex = 7;
			this.label_DptChange_Title.Text = "[사용자] 부서 변경";
			// 
			// button_DptChange_Udt
			// 
			this.button_DptChange_Udt.BackColor = System.Drawing.Color.White;
			this.button_DptChange_Udt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_DptChange_Udt.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_DptChange_Udt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_DptChange_Udt.Location = new System.Drawing.Point(43, 455);
			this.button_DptChange_Udt.Name = "button_DptChange_Udt";
			this.button_DptChange_Udt.Size = new System.Drawing.Size(285, 31);
			this.button_DptChange_Udt.TabIndex = 8;
			this.button_DptChange_Udt.Text = "변경하기";
			this.button_DptChange_Udt.UseVisualStyleBackColor = false;
			// 
			// listBox_DptChange
			// 
			this.listBox_DptChange.FormattingEnabled = true;
			this.listBox_DptChange.ItemHeight = 20;
			this.listBox_DptChange.Location = new System.Drawing.Point(43, 119);
			this.listBox_DptChange.Name = "listBox_DptChange";
			this.listBox_DptChange.Size = new System.Drawing.Size(285, 324);
			this.listBox_DptChange.TabIndex = 2;
			// 
			// label_DptChange_Name
			// 
			this.label_DptChange_Name.AutoSize = true;
			this.label_DptChange_Name.ForeColor = System.Drawing.Color.White;
			this.label_DptChange_Name.Location = new System.Drawing.Point(110, 78);
			this.label_DptChange_Name.Name = "label_DptChange_Name";
			this.label_DptChange_Name.Size = new System.Drawing.Size(142, 20);
			this.label_DptChange_Name.TabIndex = 9;
			this.label_DptChange_Name.Text = "현재 부서명 : [부서]";
			// 
			// FormAdmin_User_DptChange
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(371, 511);
			this.Controls.Add(this.label_DptChange_Name);
			this.Controls.Add(this.button_DptChange_Udt);
			this.Controls.Add(this.label_DptChange_Title);
			this.Controls.Add(this.listBox_DptChange);
			this.Name = "FormAdmin_User_DptChange";
			this.Text = "사용자 부서 변경";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Label label_DptChange_Title;
		private Button button_DptChange_Udt;
		private ListBox listBox_DptChange;
		private Label label_DptChange_Name;
	}
}