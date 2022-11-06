using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace DBP_관리
{
    public partial class Form_Resist : Form
    {
        private bool isID = false;
        private bool isPass = false;
        public Form_Resist()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        // 회원가입 취소
        private void Cancle_Resist(object sender, EventArgs e)
        {
            Owner.Location = this.Location;
            Owner.Show();
            this.Close();
        }

        // 회원가입 버튼
        private void Btn_ResistON(object sender, EventArgs e)
        {
            LoginManager.Instance.Resist(txt_Profile.Text, txt_Name.Text, txt_Nickname.Text, txt_Id.Text, txt_Password.Text
                , txt_Address.Text, combo_Department.SelectedIndex);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void CheckID(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txt_Id.Text))
            {
                MessageBox.Show("아이디를 입력하세요");
                return;
            }
            else
            {
                LoginManager.Instance.CheckString(txt_Id.Text, "USER_id", isID);
            }
        }

        private void CheckAllInput(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txt_Name.Text) && String.IsNullOrEmpty(txt_Nickname.Text) &&
                String.IsNullOrEmpty(txt_Id.Text) && String.IsNullOrEmpty(txt_Password.Text) &&
                String.IsNullOrEmpty(txt_Address.Text) && String.IsNullOrEmpty(combo_Department.Text))
            {

            }
            else
            {
            }
        }

        private void CheckPassword(object sender, CancelEventArgs e)
        {
            if(txt_Password.Text.Equals(txt_ConfirmPass.Text))
            {
                label_verify.ForeColor = Color.LightGreen;
                label_verify.Text = "비밀번호가\n일치합니다";
                isPass = true;
            }
            else
            {
                label_verify.ForeColor = Color.Red;
                label_verify.Text = "비밀번호가\n일치하지 않습니다";
                isPass = false;
            }
        }
        /*
   프로세서 관리
   Process[] mProcess = Process.GetProcessesByName(Application.ProductName);
   Debug.WriteLine(mProcess);
   foreach (Process p in mProcess)
       p.Kill();
   */
    }
}
