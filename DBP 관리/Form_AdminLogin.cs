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
    public partial class Form_AdminLogin : Form
    {
        public Form_AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin(object sender, EventArgs e)
        {

        }

        private void BackPage(object sender, EventArgs e)
        {
            this.Hide();
            Point tempPoint = this.Location;
            Form_Login login = new Form_Login();
            login.Location = tempPoint;
            login.Owner = this;
            login.Show();
        }

        private void btn_adminLogin_Click(object sender, EventArgs e)
        {
            Point tempPoint = this.Location;
            this.Hide();
            FormAdmin_Dpt frm = new FormAdmin_Dpt();
            frm.Location = tempPoint;
            frm.Owner = this;
            frm.Show();
        }

        private void EnterLoginAdmin(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Point tempPoint = this.Location;
                this.Hide();
                FormAdmin_Dpt frm = new FormAdmin_Dpt();
                frm.Location = tempPoint;
                frm.Owner = this;
                frm.Show();
            }
        }

        private void LoadImage(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }
        }
    }
}
