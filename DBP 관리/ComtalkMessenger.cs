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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EnterLogin(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("로그인");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResistIn_Click(object sender, EventArgs e)
        {
            Form_Resist f2 = new Form_Resist();
            f2.Show();
        }
    }
}
