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
    public delegate void DataEventHandler(string data);

    public partial class Form_ChangeProfile : Form
    {
        public DataEventHandler dataEvent;
        string receivedData;
        public Form_ChangeProfile(string data)
        {
            receivedData = data;
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_address_click(object sender, EventArgs e)
        {
            Form_Address fd = new Form_Address();
            fd.sendEvent += new DataGetEventHandler(DataGet);
            fd.ShowDialog();
        }
        private void DataGet(string data)
        {
            string datas = data;
            var ad = datas.Split('\n');

            txt_zipCode.Text = ad[0];
            txt_roadAddress.Text = ad[1];
            txt_landlordAddress.Text = ad[2];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginManager.Instance.SetImage(openFileDialog1, pictureBox1, receivedData);
        }

        private void Form_ChangeProfile_Load(object sender, EventArgs e)
        {
            LoginManager.Instance.LoadUserData(receivedData, pictureBox1, txt_name, txt_nickname, txt_zipCode, txt_roadAddress, txt_landlordAddress);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            LoginManager.Instance.ChangeProfile(receivedData, txt_name.Text, txt_nickname.Text, txt_password.Text, txt_zipCode.Text, txt_roadAddress.Text, txt_landlordAddress.Text);
            dataEvent("변경");
            this.Close();
        }
    }
}
