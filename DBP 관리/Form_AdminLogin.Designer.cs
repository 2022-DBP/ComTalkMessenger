namespace DBP_관리
{
    partial class Form_AdminLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Back = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.label_Back);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 300);
            this.panel1.TabIndex = 0;
            // 
            // label_Back
            // 
            this.label_Back.AutoSize = true;
            this.label_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Back.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Back.ForeColor = System.Drawing.Color.White;
            this.label_Back.Location = new System.Drawing.Point(500, 23);
            this.label_Back.Name = "label_Back";
            this.label_Back.Size = new System.Drawing.Size(92, 28);
            this.label_Back.TabIndex = 3;
            this.label_Back.Text = "뒤로가기";
            this.label_Back.Click += new System.EventHandler(this.BackPage);

            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(119, 182);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 36);
            this.textBox1.TabIndex = 1;
            // 
            // Form_AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 293);
            this.Controls.Add(this.panel1);
            this.Name = "Form_AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form_AdminLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label_Back;
        private Button btn_adminLogin;
        private TextBox textBox1;
        private TextBox txt_adminID;
    }
}