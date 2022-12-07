﻿using MySql.Data.MySqlClient;
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
			checkedListBox_Pri_Visible_Dpt.Items.Clear();
			list_PriVisible_Dpt.Clear();

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
			string query = "SELECT department.dpt_name FROM department WHERE department.id IN (SELECT UnableChat_Dpt_ID FROM USER_Visible WHERE USER_ID = " + user_id + ")";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {
					for (int i = 0; i < checkedListBox_Pri_Visible_Dpt.Items.Count; i++) {
						if (checkedListBox_Pri_Visible_Dpt.Items[i].ToString().Equals(rdr[0].ToString())) {
							checkedListBox_Pri_Visible_Dpt.SetItemChecked(i, true);
						}
					}
				}
			}
		}

		private void Load_PriVisible_Team(int user_id) {
			//보기제한 팀 리스트 로드
			checkedListBox_Pri_Visible_Team.Items.Clear();
			list_PriVisible_Team.Clear();

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
			string query = "SELECT department.dpt_name, team.team_name FROM department, team WHERE department.id = team.dpt_id AND team.id IN (SELECT UnableChat_Team_ID FROM USER_Visible WHERE USER_ID = " + user_id + ");";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {
					for (int i = 0; i < checkedListBox_Pri_Visible_Team.Items.Count; i++) {
						if (checkedListBox_Pri_Visible_Team.Items[i].ToString().Equals(rdr[0].ToString() + " " + rdr[1].ToString())) {
							checkedListBox_Pri_Visible_Team.SetItemChecked(i, true);
						}
					}
				}
			}
		}

		private void Load_PriVisible_User(int user_id) {
			//보기제한 유저 리스트 로드
			checkedListBox_Pri_Visible_User.Items.Clear();
			list_PriVisible_User.Clear();

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

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT department.dpt_name, team.team_name, USER.USER_name FROM department, team, USER WHERE department.id = USER.department_id AND team.id = USER.team_id AND USER.ID IN (SELECT UnableChat_User_ID FROM USER_Visible WHERE USER_ID = " + user_id + ");";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {
					for (int i = 0; i < checkedListBox_Pri_Visible_User.Items.Count; i++) {
						if (checkedListBox_Pri_Visible_User.Items[i].ToString().Equals(rdr[0].ToString() + " " + rdr[1].ToString() + " " + rdr[2].ToString())) {
							checkedListBox_Pri_Visible_User.SetItemChecked(i, true);
						}
					}
				}
			}
		}

		private void Load_PriChat(int user_id) {
			//대화 제한 리스트 로드
			checkedListBox_Pri_Chat.Items.Clear();
			list_PriChat.Clear();

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
					for (int i = 0; i < checkedListBox_Pri_Chat.Items.Count; i++) {
						if (checkedListBox_Pri_Chat.Items[i].ToString().Equals(rdr[0].ToString() + " " + rdr[1].ToString() + " " + rdr[2].ToString())) {
							checkedListBox_Pri_Chat.SetItemChecked(i, true);
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
					for (int i = 0; i < checkedListBox_Pri_Chat.Items.Count; i++) {
						if (checkedListBox_Pri_Chat.Items[i].ToString().Equals(rdr[0].ToString() + " " + rdr[1].ToString() + " " + rdr[2].ToString())) {
							checkedListBox_Pri_Chat.SetItemChecked(i, true);
						}
					}
				}
			}
		}

		private void button_Pri_Chat_Click(object sender, EventArgs e) {
			//INSERT 전에 체크 해제, 즉 기존의 대화 제한을 해제했을 수 있으므로 선택한 사용자의 대화 제한 목록을 DELETE하기
			for(int i = 0; i < checkedListBox_Pri_Chat.CheckedItems.Count; i++) {
				list_PriChat.Add(checkedListBox_Pri_Chat.CheckedItems[i].ToString());
			}

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "DELETE FROM USER_PriChat WHERE (User_ID1 = " + user_id + ") OR (USER_ID2 = " + user_id + ");";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {	}
			}

			foreach(string str in list_PriChat) {
				string[] info = str.Split(" ");
				string dpt = info[0];
				string team = info[1];
				string user = info[2];

				query = "INSERT INTO USER_PriChat(User_ID1, User_ID2) VALUES(" + user_id + ", (SELECT USER.ID FROM USER WHERE USER.department_id = (SELECT department.id FROM department WHERE department.dpt_name = '" + dpt + "') AND USER.team_id = (SELECT team.id FROM team WHERE team.team_name = '" + team + "') AND USER.USER_name = '" + user +"'));";
				using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
					connection.Open();
					MySqlCommand cmd = new MySqlCommand(query, connection);
					MySqlDataReader rdr = cmd.ExecuteReader();

					while (rdr.Read()) { }
				}
			}

			MessageBox.Show("대화 제한 적용 완료");
			Load_PriChat(user_id);
		}

		private void button_Pri_Visible_Dpt_Click(object sender, EventArgs e) {
			//INSERT 전에 체크 해제, 즉 기존의 대화 제한을 해제했을 수 있으므로 선택한 사용자의 대화 제한 목록을 DELETE하기
			for (int i = 0; i < checkedListBox_Pri_Visible_Dpt.CheckedItems.Count; i++) {
				list_PriVisible_Dpt.Add(checkedListBox_Pri_Visible_Dpt.CheckedItems[i].ToString());
			}

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "DELETE FROM USER_PriVisible WHERE ;";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) { }
			}

			foreach (string str in list_PriChat) {
				string[] info = str.Split(" ");
				string dpt = info[0];
				string team = info[1];
				string user = info[2];

				query = "INSERT INTO USER_PriChat(User_ID1, User_ID2) VALUES(" + user_id + ", (SELECT USER.ID FROM USER WHERE USER.department_id = (SELECT department.id FROM department WHERE department.dpt_name = '" + dpt + "') AND USER.team_id = (SELECT team.id FROM team WHERE team.team_name = '" + team + "') AND USER.USER_name = '" + user +"'));";
				using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
					connection.Open();
					MySqlCommand cmd = new MySqlCommand(query, connection);
					MySqlDataReader rdr = cmd.ExecuteReader();

					while (rdr.Read()) { }
				}
			}

			MessageBox.Show("대화 제한 부서 적용 완료");
			Load_PriChat(user_id);
		}

		private void button_Pri_Visible_Team_Click(object sender, EventArgs e) {
			//INSERT 전에 체크 해제, 즉 기존의 대화 제한을 해제했을 수 있으므로 선택한 사용자의 대화 제한 목록을 DELETE하기

		}

		private void button_Pri_Visible_User_Click(object sender, EventArgs e) {
			//INSERT 전에 체크 해제, 즉 기존의 대화 제한을 해제했을 수 있으므로 선택한 사용자의 대화 제한 목록을 DELETE하기

		}
	}
}