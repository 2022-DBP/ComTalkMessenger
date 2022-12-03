using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_관리
{
    public partial class FormAdmin_Login : Form
    {
        public FormAdmin_Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form_Login frm = new Form_Login();
            frm.Show();
            this.Close();
        }

        public void LOGIN(string str1, string str2)
        {
            LoginManager login = new LoginManager();
            login.Login(str1, str2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginManager login = new LoginManager();
            login.Login(textBox1.Text, textBox2.Text); //LoginManager.cs 메서드에서 로그인 여부 반환값 추가해야함
            FormAdmin_Dpt frm = new FormAdmin_Dpt();
            frm.Show();
            this.Close();
        }
    }
}
