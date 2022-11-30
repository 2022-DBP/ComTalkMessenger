using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Diagnostics;

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

        private const string code = "Data Source = 115.85.181.212; Database=s5469698; Uid=s5469698; Pwd=s5469698; CharSet=utf8;";

        #region ===============================  로그인 기능들  =======================================
        // 로그인 기능
        public void Login(string id, string pass)
        {
            using (MySqlConnection conn = new MySqlConnection(code))
            {
                conn.Open();
                string query = $"SELECT USER_id, USER_password FROM USER WHERE USER_id = '{id}' AND USER_password = '{password}'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                // 데이터가 존재할 경우 일치하다고 판단하고 로그인
                if (reader.HasRows)
                {
                    reader.Close();
                    MessageBox.Show("로그인 성공", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                    string logquery = $"insert into Login_log (user_id, log_time, log_type) " +
                        $"values ((select ID from USER where USER_id = '{id}'), '{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}', 'in')";
                    cmd.CommandText = logquery;
                    cmd.ExecuteNonQuery();
                }
                // 데이터가 존재하지 않을 경우 아이디 또는 비밀번호가 일치하지 않음
                else
                {
                    MessageBox.Show("아이디 또는 비밀번호가 일치하지 않습니다.");
                    reader.Close();
                    return;
                }
                conn.Close();
            }
        }
        #endregion

        #region ===============================  회원가입 기능들  =======================================
        // 회원가입 기능 -> 회원가입 창에서 회원가입을 누를 시 데이터를 저장해주는 기능.
        public bool Resist(string profile, string name, string nick, string id,
            string pass, string address, string department, string team, string date)
        {
            // 이미지 넣기 전 BLOB 형식에 넣을 수 있게 변환
            byte[] imageData = null;
            if(string.IsNullOrEmpty(profile))
            {
                MessageBox.Show("프로필 이미지를 넣어주세요");
                return false; ;
            }
            FileStream fs = new FileStream(profile, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);
            imageData = br.ReadBytes((int)fs.Length);

            if (NullCheck(profile, name, nick, id, pass, address, department, team))
            {
                using (MySqlConnection conn = new MySqlConnection(code))
                {
                    conn.Open();
                    try
                    {
                        string query = $"INSERT INTO USER (USER_image, USER_name, USER_nickname, USER_id, USER_password, USER_address, USER_department, USER_team, USER_birth)" +
                            $"VALUES(@IMG, '{name}', '{nick}', '{id}', '{pass}', '{address}', " +
                            $"(select id from department where dpt_name = '{department}')," +
                            $"(select id from team where team_name = '{team}' and dpt_id = (select id from department where dpt_name = '{department}'))," +
                            $"'{date}')";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.Add(new MySqlParameter("@IMG", imageData));
                        cmd.ExecuteNonQuery();

                        conn.Close();

                        MessageBox.Show("회원가입이 완료되었습니다");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
            else
                return false;

            return true;

        }   


        // 아이디 중복 확인
        public bool CheckID(string check, string column, bool active)
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
                    return false;
                }
                else
                {
                    MessageBox.Show("사용 가능합니다.");
                    active = true;
                }
                reader.Close();
                conn.Close();
            }
            return true;
        }

        // 빈 칸 확인 기능
        private bool NullCheck(string profile, string name, string nickname, string id, string password,
            string address, string department, string team)
        {
            if (string.IsNullOrEmpty(profile))
            {
                MessageBox.Show("프로필 이미지를 입력해주세요");
                return false;
            }
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("이름을 입력해주세요");
                return false;
            }
            if (string.IsNullOrEmpty(nickname))
            {
                MessageBox.Show("닉네임을 입력해주세요");
                return false;
            }
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("아이디를 입력해주세요");
                return false;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("비밀번호를 입력해주세요");
                return false;
            }
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("주소를 입력해주세요");
                return false;
            }
            if (string.IsNullOrEmpty(department))
            {
                MessageBox.Show("부서를 설정해주세요");
                return false;
            }
            if (string.IsNullOrEmpty(team))
            {
                MessageBox.Show("팀을 선택해주세요");
                return false;
            }

            return true;
        }


        // 부서 및 팀 콤보 박스 데이터 출력
        public void LoadComboBoxColumnData(ComboBox department, ComboBox team, string column, string table, OutputSort sort = OutputSort.None)
        {
            string query = "";
            switch (sort)
            {
                case OutputSort.None:
                    break;
                case OutputSort.Department:
                    using (MySqlConnection conn = new MySqlConnection(code))
                    {
                        conn.Open();
                        query = $"select {column} from {table}";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        department.Items.Clear();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                department.Items.Add(reader[column].ToString());
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
                    break;

                case OutputSort.Team:
                    using (MySqlConnection conn = new MySqlConnection(code))
                    {
                        conn.Open();
                        query = $"select {column} from {table} where dpt_id = (select id from department where dpt_name = '{department.Text}')";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        team.Items.Clear();
                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                team.Items.Add(reader[column].ToString());
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
                        break;
            }
        }
        #endregion
    }
}
