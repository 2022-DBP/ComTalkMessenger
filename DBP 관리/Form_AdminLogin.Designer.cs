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
<<<<<<< Updated upstream
            this.label_Back = new System.Windows.Forms.Label();
            this.btn_adminLogin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
=======
            this.btn_adminLogin = new System.Windows.Forms.Button();
            this.txt_adminID = new System.Windows.Forms.TextBox();
>>>>>>> Stashed changes
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
<<<<<<< Updated upstream
            this.panel1.Controls.Add(this.label_Back);
            this.panel1.Controls.Add(this.btn_adminLogin);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
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
            // btn_adminLogin
            // 
            this.btn_adminLogin.Location = new System.Drawing.Point(421, 181);
            this.btn_adminLogin.Name = "btn_adminLogin";
            this.btn_adminLogin.Size = new System.Drawing.Size(94, 37);
            this.btn_adminLogin.TabIndex = 2;
            this.btn_adminLogin.Text = "로그인";
            this.btn_adminLogin.UseVisualStyleBackColor = true;
            this.btn_adminLogin.Click += new System.EventHandler(this.AdminLogin);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(119, 182);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 36);
            this.textBox1.TabIndex = 1;
=======
            this.panel1.Controls.Add(this.btn_adminLogin);
            this.panel1.Controls.Add(this.txt_adminID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 297);
            this.panel1.TabIndex = 0;
            // 
            // btn_adminLogin
            // 
            this.btn_adminLogin.Location = new System.Drawing.Point(448, 160);
            this.btn_adminLogin.Name = "btn_adminLogin";
            this.btn_adminLogin.Size = new System.Drawing.Size(94, 48);
            this.btn_adminLogin.TabIndex = 2;
            this.btn_adminLogin.Text = "로그인";
            this.btn_adminLogin.UseVisualStyleBackColor = true;
            this.btn_adminLogin.Click += new System.EventHandler(this.LoadImage);
            // 
            // txt_adminID
            // 
            this.txt_adminID.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_adminID.Location = new System.Drawing.Point(119, 160);
            this.txt_adminID.Multiline = true;
            this.txt_adminID.Name = "txt_adminID";
            this.txt_adminID.Size = new System.Drawing.Size(314, 48);
            this.txt_adminID.TabIndex = 1;
            this.txt_adminID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterLoginAdmin);
>>>>>>> Stashed changes
            // 
            // label1
            // 
            this.label1.AutoSize = true;
<<<<<<< Updated upstream
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(161, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 60);
=======
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(171, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 57);
>>>>>>> Stashed changes
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrator";
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
<<<<<<< Updated upstream
        private Label label1;
        private Label label_Back;
        private Button btn_adminLogin;
        private TextBox textBox1;
=======
        private Button btn_adminLogin;
        private TextBox txt_adminID;
        private Label label1;
>>>>>>> Stashed changes
    }
}