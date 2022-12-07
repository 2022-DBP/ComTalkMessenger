using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBP_관리 {
	public partial class FormAdmin_User_Pri : Form {
		List<string> list_PriVisible_Dpt = new List<string>();
		List<string> list_PriVisible_Team = new List<string>();
		List<string> list_PriVisible_User = new List<string>();
		List<string> list_PriChat = new List<string>();
		private string user_name;
		private int user_id;

		public FormAdmin_User_Pri(string user_name, int user_id) {
			InitializeComponent();

			this.user_name = user_name;
			this.user_id = user_id;	//이는 USER 테이블의 User_id가 아닌, ID임(인덱스).

			label_Pri_Title.Text = user_name + " 권한 조정";

			Load_PriVisible_Dpt(user_id);
			Load_PriVisible_Team(user_id);
			Load_PriVisible_User(user_id);
			Load_PriChat(user_id);
		}

		private void Load_PriVisible_Dpt(int user_id) {
			//보기제한 부서 리스트 로드
			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT dpt_name FROM department ORDER BY dpt_name;";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {
					checkedListBox_Pri_Visible_Dpt.Items.Add(rdr[0].ToString());
				}
			}

			Check_PriVisible_Dpt(user_id);
		}

		private void Check_PriVisible_Dpt(int user_id) {
			//보기제한 부서 체크
			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {

				}
			}
		}

		private void checkedListBox_Pri_Visible_Dpt_ItemCheck(object sender, ItemCheckEventArgs e) {
			//보기제한 부서 체크박스리스트 체크시

		}

		private void Load_PriVisible_Team(int user_id) {
			//보기제한 팀 리스트 로드
			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT dpt_name, team_name FROM department, team WHERE team.dpt_id = department.id ORDER BY dpt_name, team_name;";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {
					checkedListBox_Pri_Visible_Team.Items.Add(rdr[0].ToString() + " " + rdr[1].ToString());
				}
			}

			Check_PriVisible_Team(user_id);
		}

		private void Check_PriVisible_Team(int user_id) {
			//보기제한 팀 체크
			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {

				}
			}
		}

		private void checkedListBox_Pri_Visible_Team_ItemCheck(object sender, ItemCheckEventArgs e) {
			//보기제한 팀 체크박스리스트 체크시

		}

		private void Load_PriVisible_User(int user_id) {
			//보기제한 유저 리스트 로드
			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT dpt_name, team_name, USER_name FROM department, team, USER WHERE team.dpt_id = department.id AND department.id = USER.department_id AND team.id = USER.team_id;";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {
					checkedListBox_Pri_Visible_User.Items.Add(rdr[0].ToString() + " " + rdr[1].ToString() + " " + rdr[2].ToString());
				}
			}

			Check_PriVisible_User(user_id);
		}

		private void Check_PriVisible_User(int user_id) {
			//보기제한 유저 체크

		}

		private void checkedListBox_Pri_Visible_User_ItemCheck(object sender, ItemCheckEventArgs e) {
			//보기제한 유저 체크박스리스트 체크시

		}

		private void Load_PriChat(int user_id) {
			//대화 제한 리스트 로드
			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT dpt_name, team_name, USER_name FROM department, team, USER WHERE team.dpt_id = department.id AND department.id = USER.department_id AND team.id = USER.team_id;";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {
					checkedListBox_Pri_Chat.Items.Add(rdr[0].ToString() + " " + rdr[1].ToString() + " " + rdr[2].ToString());
				}
			}

			Check_PriChat(user_id);
		}

		private void Check_PriChat(int user_id) {
			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT department.dpt_name, team.team_name, USER.USER_name FROM department, team, USER WHERE department.id = USER.department_id AND team.id = USER.team_id AND USER.ID IN(SELECT USER_ID2 FROM USER_PriChat WHERE USER_ID2 != " + user_id + "); ";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {
					foreach (string str in checkedListBox_Pri_Chat.Items) {
						if (str.Equals(rdr[0].ToString() + " " + rdr[1].ToString() + " " + rdr[2].ToString())) {
							checkedListBox_Pri_Chat.SetItemChecked(checkedListBox_Pri_Chat.FindString(str), true);
						}
					}
				}
			}

			query = "SELECT department.dpt_name, team.team_name, USER.USER_name FROM department, team, USER WHERE department.id = USER.department_id AND team.id = USER.team_id AND USER.ID IN(SELECT USER_ID1 FROM USER_PriChat WHERE USER_ID1 != " + user_id + "); ";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {
					foreach (string str in checkedListBox_Pri_Chat.Items) {
						if (str.Equals(rdr[0].ToString() + " " + rdr[1].ToString() + " " + rdr[2].ToString())) {
							checkedListBox_Pri_Chat.SetItemChecked(checkedListBox_Pri_Chat.FindString(str), true);
						}
					}
				}
			}
		}

		private void checkedListBox_Pri_Chat_ItemCheck(object sender, ItemCheckEventArgs e) {
			//대화 권한 체크리스트박스 체크시

		}

		private void button_Pri_Chat_Click(object sender, EventArgs e) {
			//INSERT 전에 체크 해제, 즉 기존의 대화 제한을 해제했을 수 있으므로 선택한 사용자의 대화 제한 목록을 DELETE하기

		}

		private void button_Pri_Visible_Dpt_Click(object sender, EventArgs e) {
			//INSERT 전에 체크 해제, 즉 기존의 대화 제한을 해제했을 수 있으므로 선택한 사용자의 대화 제한 목록을 DELETE하기
		}

		private void button_Pri_Visible_Team_Click(object sender, EventArgs e) {
			//INSERT 전에 체크 해제, 즉 기존의 대화 제한을 해제했을 수 있으므로 선택한 사용자의 대화 제한 목록을 DELETE하기

		}

		private void button_Pri_Visible_User_Click(object sender, EventArgs e) {
			//INSERT 전에 체크 해제, 즉 기존의 대화 제한을 해제했을 수 있으므로 선택한 사용자의 대화 제한 목록을 DELETE하기

		}
	}
}