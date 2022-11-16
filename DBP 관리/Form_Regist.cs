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

        // 로그인을 되돌아가기
        private void BackLogin(object sender, EventArgs e)
        {
            Owner.Location = this.Location;
            Owner.Show();
            this.Close();
        }

        // 회원가입 버튼
        private void Btn_ResistON(object sender, EventArgs e)
        {
            if(!isID)
            {
                MessageBox.Show("아이디 중복 체크를 다시 해주세요");
                return;
            }
 
            if(!isPass)
            {
                MessageBox.Show("비밀번호를 다시 확인해주세요");
                return;
            }
            if (LoginManager.Instance.Resist(txt_Profile.Text, txt_Name.Text, txt_Nickname.Text, txt_Id.Text, txt_Password.Text, txt_Address.Text, combo_Department.Text, combo_team.Text, dateTimePicker1.Text))
                BackLogin(sender, e);
            else
                return;
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
                isID = LoginManager.Instance.CheckID(txt_Id.Text, "USER_id", isID);
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

        // 이미지 넣기 기능
        private void LoadImage(object sender, EventArgs e)
        {
            // 파일 열기 확장자 필터링 - 사진만 넣을 수 있게 함. All 추가 시 All Files(*.*)|*.*
            openFileDialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName.ToString();
                txt_Profile.Text = path;
                profileBox.ImageLocation = path;
                profileBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void combo_Department_Enter(object sender, EventArgs e)
        {
            LoginManager.Instance.LoadComboBoxColumnData(combo_Department, combo_team, "dpt_name", "department", LoginManager.OutputSort.Department);
        }

        private void label_birth_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Load_TeamData(object sender, EventArgs e)
        {
            LoginManager.Instance.LoadComboBoxColumnData(combo_Department, combo_team, "team_name", "team", LoginManager.OutputSort.Team);
        }

        private void txt_Profile_TextChanged(object sender, EventArgs e)
        {

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
