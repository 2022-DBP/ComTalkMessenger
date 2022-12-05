using MySql.Data.MySqlClient;
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
    public partial class Form_Font : Form
    {
        private int userid = 0;
        public Form_Font(string user_id)
        {
            InitializeComponent();
            this.userid = Convert.ToInt32(user_id);
        }

        private void button_BackColor_Click(object sender, EventArgs e)
        {
            if(comboBox3.SelectedItem == null && comboBox4.SelectedItem == null)
            {
                MessageBox.Show("폰트가 선택되어있지 않습니다.");
            }
            else
            {
                string font = comboBox4.SelectedItem.ToString();
                int size = Convert.ToInt32(comboBox3.SelectedItem.ToString());

                Change_Font(size, this.userid, font);
            }
        }

        //size = 폰트크기, user = 현재 로그인한 유저 고유인덱스
        public void Change_Font(int size, int user, string Font)
        {
            string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
            string query = "INSERT INTO USER_Config(User_ID, Font, Font_Size) VALUES ("+ user +", '"+ Font +"', "+ size+ ") ON DUPLICATE KEY UPDATE Font = '"+ Font + "', Font_Size = "+ size +";";

            using (MySqlConnection connection = new MySqlConnection(Connection_string))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("폰트가 설정되었습니다.");
                this.Close();
            }
        }
    }
}
