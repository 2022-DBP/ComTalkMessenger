using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Net;

namespace DBP_관리
{
    internal class LoginManager
    {
        public enum OutputSort
        {
            None,
            Department,
            Team
        }

        private static LoginManager instance = new LoginManager();
        public static LoginManager Instance { get => instance; }

        private Regist _resist = new Regist();
        public static Regist _Regist { get => instance._resist; }

        private Login _login = new Login();

        public static Login _Login { get => instance._login; }
        // DB Connect Code
        public const string code = "Data Source = 115.85.181.212; Database=s5469698; Uid=s5469698; Pwd=s5469698; CharSet=utf8;";

        public string getIP()
        {
            String strHostName = string.Empty;
            IPHostEntry ipEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] addr = ipEntry.AddressList;
            return addr[0].ToString();
        }

        public void Logout()
        {
            //string query = $"update USER set = {} where id = {}";
            using (MySqlConnection conn = new MySqlConnection(code))
            {
                conn.Open();
            }
        }

        public void LoadUserData(string id, PictureBox image, Label nick, Label dpt, Label team)
        {
            string SQL = string.Empty;
            string FileName = string.Empty;
            FileStream fs;
            // 로그인 한 사람의 부서명과 팀명
            string query = $"select USER_image, USER.USER_nickname, department.dpt_name, team.team_name from USER, department, team " +
                $"where USER_id = '{id}' and USER.department_id = department.id and USER.team_id = team.id";
            using (MySqlConnection conn = new MySqlConnection(code))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    Byte[] data = (Byte[])reader["USER_image"];
                    MemoryStream ms = new MemoryStream(data);
                    image.Image = Image.FromStream(ms);
                    nick.Text = reader["USER_nickname"].ToString();
                    Debug.WriteLine(reader["USER_nickname"].ToString() + "화깅ㄴ");
                    dpt.Text = reader["dpt_name"].ToString();
                    team.Text = reader["team_name"].ToString();
                }
                else
                {
                    return;
                }
            }
        }

        public void SetImage(OpenFileDialog openFileDialog, TextBox txt_Profile, PictureBox profileBox)
        {
            openFileDialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName.ToString();
                txt_Profile.Text = path;
                profileBox.ImageLocation = path;
                profileBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        public void SetImage(OpenFileDialog openFileDialog, PictureBox profileBox, string id)
        {
            openFileDialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName.ToString();
                profileBox.ImageLocation = path;
                profileBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            using (MySqlConnection conn = new MySqlConnection(code))
            {
                conn.Open();
                byte[] imageData = null;
                FileStream fs = new FileStream(profileBox.ImageLocation, FileMode.Open, FileAccess.Read);

                BinaryReader br = new BinaryReader(fs);
                imageData = br.ReadBytes((int)fs.Length);

                string query = $"update USER set USER_image = @IMG where USER_id = '{id}'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySqlParameter("@IMG", imageData));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        // 파일 가져오는 기능 
        public void GetImage(string id, PictureBox image)
        {
            string SQL = string.Empty;
            string FileName = string.Empty;
            FileStream fs;

            using (MySqlConnection conn = new MySqlConnection(code))
            {
                conn.Open();

                string query = $"select User_image from USER where USER_id = {id}";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    UInt32 FileSize = reader.GetUInt32(reader.GetOrdinal("filesize"));
                    byte[] rawData = new byte[FileSize];

                    reader.GetBytes(reader.GetOrdinal("file"), 0, rawData, 0, (int)FileSize);

                    FileName = @System.IO.Directory.GetCurrentDirectory() + "\\newfile.png";

                    fs = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    fs.Write(rawData, 0, (int)FileSize);
                    fs.Close();

                    image.Image = Image.FromFile(FileName);
                }
                else
                {
                    reader.Close();
                    conn.Close();
                    return;
                }
                reader.Close();
                conn.Close();
            }

        }
    }
}