using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_관리
{
    internal class LoginManager
    {
        private static LoginManager instance = new LoginManager();
        public static LoginManager Instance { get => instance; }

        private const string code = "Data Source = 115.85.181.212; Database=s5469698; Uid=s5469698; Pwd=s5469698; CharSet=utf8;";
        

        // 로그인 기능
        public void Login(string id, string pass)
        {
            using (MySqlConnection conn = new MySqlConnection(code))
            {
                conn.Open();
                string query = $"SELECT USER_id, USER_password FROM USER WHERE USER_id = '{id}' AND USER_password = '{pass}'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                // 데이터가 존재할 경우 일치하다고 판단하고 로그인
                if (reader.HasRows)
                {
                    MessageBox.Show("로그인 성공");
                }
                // 데이터가 존재하지 않을 경우 아이디 또는 비밀번호가 일치하지 않음
                else
                {
                    MessageBox.Show("아이디 또는 비밀번호가 일치하지 않습니다.");
                    reader.Close();
                    return;
                }
                reader.Close();
                conn.Close();
            }
        }

        // 회원가입 기능 -> 회원가입 창에서 회원가입을 누를 시 데이터를 저장해주는 기능. DB에서 확인할 필요 없이 데이터를 처분? 유저 수 확인하는 방법은 COUNT 쿼리로 세면 됨
        public void Resist(string profile, string name, string nick, string id,
            string pass, string address, int department)
        {
            FileStream fs = new FileStream(profile, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] imageData = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();

            using (MySqlConnection conn = new MySqlConnection(code))
            {
                conn.Open();

                string query = $"INSERT INTO USER" +
                    $"VALUES('{imageData}', '{name}', '{nick}', '{id}', '{pass}', '{address}', {department})";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }   

        // 아이디 중복 확인
        public void CheckString(string check, string column, bool active)
        {
            using (MySqlConnection conn = new MySqlConnection(code))
            {
                conn.Open();
                string query = $"SELECT {column} FROM USER WHERE {column} = '{check}'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                // 데이터가 중복하는 경우
                if(reader.HasRows)
                {
                    MessageBox.Show("해당 데이터는 중복됩니다.");
                    active = false;
                    return;
                }
                else
                {
                    MessageBox.Show("사용 가능합니다.");
                    active = true;
                }
                reader.Close();
                conn.Close();
            }
        }

        // 부서 데이터 출력
        public void LoadComboBoxColumnData(ComboBox combo, string column, string table)
        {
            string query = $"SELECT {column} FROM {table}";

            using (MySqlConnection conn = new MySqlConnection(code))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                combo.Items.Clear();
                
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        combo.Items.Add(reader.Read());
                    }
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
