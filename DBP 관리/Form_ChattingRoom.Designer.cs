﻿namespace DBP_관리
{
    partial class Form_ChattingRoom
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonNoticeVisible = new System.Windows.Forms.Button();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "대화";
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.White;
            this.buttonSend.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSend.Location = new System.Drawing.Point(751, 470);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(98, 105);
            this.buttonSend.TabIndex = 7;
            this.buttonSend.Text = "보내기";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSend.Location = new System.Drawing.Point(109, 470);
            this.textBoxSend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(634, 104);
            this.textBoxSend.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 510);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "message";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(24, 75);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(772, 57);
            this.textBox1.TabIndex = 11;
            // 
            // buttonNoticeVisible
            // 
            this.buttonNoticeVisible.BackColor = System.Drawing.Color.White;
            this.buttonNoticeVisible.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNoticeVisible.Location = new System.Drawing.Point(797, 75);
            this.buttonNoticeVisible.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonNoticeVisible.Name = "buttonNoticeVisible";
            this.buttonNoticeVisible.Size = new System.Drawing.Size(49, 58);
            this.buttonNoticeVisible.TabIndex = 12;
            this.buttonNoticeVisible.Text = "공지";
            this.buttonNoticeVisible.UseVisualStyleBackColor = false;
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.ItemHeight = 20;
            this.listBoxHistory.Location = new System.Drawing.Point(26, 135);
            this.listBoxHistory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.ScrollAlwaysVisible = true;
            this.listBoxHistory.Size = new System.Drawing.Size(820, 284);
            this.listBoxHistory.TabIndex = 15;
            // 
            // Form_ChattingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(876, 607);
            this.Controls.Add(this.buttonNoticeVisible);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.listBoxHistory);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_ChattingRoom";
            this.Text = "채팅";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_ChattingRoom_FormClosing);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form_ChattingRoom_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonNoticeVisible;
        private System.Windows.Forms.ListBox listBoxHistory;
    }
}