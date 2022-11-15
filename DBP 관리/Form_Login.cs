using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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


        private void ResistIn_Click(object sender, EventArgs e)
        {
            // 현재 폼을 숨김
            this.Hide();
            Point tempPoint = this.Location;
            Form_Resist resist = new Form_Resist();
            resist.Location = tempPoint;
            resist.Owner = this;
            resist.Show();
        }

        // 체크 시 자동으로 로그인
        public void AutoLogin(object sender, EventArgs e)
        {

        }

        // 체크 시 자동으로 전에 로그인했던 유저의 아이디, 비번을 텍스트에 출력
        public void AutoInput(object sender, EventArgs e)
        {

        }

        public void Login_Click(object sender, EventArgs e)
        {
            LoginManager.Instance.Login(txt_Login.Text, txt_Password.Text);
        }
        public void GoAdminLogin(object sender, EventArgs e)
        {
            this.Hide();
            Point tempPoint = this.Location;
            Form_AdminLogin fal = new Form_AdminLogin();
            fal.Location = tempPoint;
            fal.Owner = this;
            fal.Show();
            // 관리 부서 창 띄우기
            this.Hide();
            Debug.WriteLine(this.Location);

            Debug.WriteLine(tempPoint);

            Form_AdminLogin ad = new Form_AdminLogin();
            ad.Location = tempPoint;
            ad.Owner = this;
            ad.Show();
        }

    }
}
 
