namespace DBP_관리 {
	partial class Form_Birthday {
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
			this.label_Birthday_Title = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.listBox_Birthday_Month = new System.Windows.Forms.ListBox();
			this.groupBox_Birthday_Today = new System.Windows.Forms.GroupBox();
			this.listBox_Birthday_Today = new System.Windows.Forms.ListBox();
			this.groupBox2.SuspendLayout();
			this.groupBox_Birthday_Today.SuspendLayout();
			this.SuspendLayout();
			// 
			// label_Birthday_Title
			// 
			this.label_Birthday_Title.AutoSize = true;
			this.label_Birthday_Title.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_Birthday_Title.Location = new System.Drawing.Point(104, 45);
			this.label_Birthday_Title.Name = "label_Birthday_Title";
			this.label_Birthday_Title.Size = new System.Drawing.Size(254, 46);
			this.label_Birthday_Title.TabIndex = 3;
			this.label_Birthday_Title.Text = "00월 생일 목록";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.listBox_Birthday_Month);
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(30, 259);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(403, 276);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "이번달 생일";
			// 
			// listBox_Birthday_Month
			// 
			this.listBox_Birthday_Month.FormattingEnabled = true;
			this.listBox_Birthday_Month.ItemHeight = 20;
			this.listBox_Birthday_Month.Location = new System.Drawing.Point(18, 36);
			this.listBox_Birthday_Month.Name = "listBox_Birthday_Month";
			this.listBox_Birthday_Month.Size = new System.Drawing.Size(366, 224);
			this.listBox_Birthday_Month.TabIndex = 1;
			// 
			// groupBox_Birthday_Today
			// 
			this.groupBox_Birthday_Today.Controls.Add(this.listBox_Birthday_Today);
			this.groupBox_Birthday_Today.ForeColor = System.Drawing.Color.White;
			this.groupBox_Birthday_Today.Location = new System.Drawing.Point(30, 114);
			this.groupBox_Birthday_Today.Name = "groupBox_Birthday_Today";
			this.groupBox_Birthday_Today.Size = new System.Drawing.Size(403, 123);
			this.groupBox_Birthday_Today.TabIndex = 7;
			this.groupBox_Birthday_Today.TabStop = false;
			this.groupBox_Birthday_Today.Text = "오늘 생일";
			// 
			// listBox_Birthday_Today
			// 
			this.listBox_Birthday_Today.FormattingEnabled = true;
			this.listBox_Birthday_Today.ItemHeight = 20;
			this.listBox_Birthday_Today.Location = new System.Drawing.Point(18, 25);
			this.listBox_Birthday_Today.Name = "listBox_Birthday_Today";
			this.listBox_Birthday_Today.Size = new System.Drawing.Size(366, 84);
			this.listBox_Birthday_Today.TabIndex = 1;
			// 
			// Form_Birthday
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(462, 553);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox_Birthday_Today);
			this.Controls.Add(this.label_Birthday_Title);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "Form_Birthday";
			this.Text = "생일 목록";
			this.groupBox2.ResumeLayout(false);
			this.groupBox_Birthday_Today.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label_Birthday_Title;
		private GroupBox groupBox2;
		private GroupBox groupBox_Birthday_Today;
		private ListBox listBox_Birthday_Month;
		private ListBox listBox_Birthday_Today;
	}
}