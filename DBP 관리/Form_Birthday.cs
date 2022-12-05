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

namespace DBP_관리 {
	public partial class Form_Birthday : Form {
		public Form_Birthday() {
			InitializeComponent();

			label_Birthday_Title.Text = DateTime.Now.Month + "월 생일 목록";
			Load_Birthday_Today_List();
			Load_Birthday_Month_List();
		}

		private void Load_Birthday_Today_List() {
			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT department.dpt_name, team.team_name, USER.USER_name FROM department, team, USER WHERE USER.department_id = department.id AND USER.team_id = team.id AND MONTH(USER.USER_birth) = '" + DateTime.Now.Month + "' AND DAY(USER.USER_birth) = '" + DateTime.Now.Day + "';";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				listBox_Birthday_Today.Items.Clear();

				if (!rdr.Read()) {
					listBox_Birthday_Today.Items.Add("오늘(" + DateTime.Now.Month + "월 " + DateTime.Now.Day + "일)이 생일인 사람은 없습니다.");
					return;
				}

				while (rdr.Read()) {
					listBox_Birthday_Today.Items.Add(rdr[0].ToString() + " " + rdr[1].ToString() + " " + rdr[2].ToString()  + " (" + DateTime.Now.Month + "월 " + DateTime.Now.Day + "일)");
				}
			}
		}

		private void Load_Birthday_Month_List() {
			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT department.dpt_name, team.team_name, USER.USER_name, MONTH(USER.USER_birth), DAY(USER.USER_birth) FROM department, team, USER WHERE USER.department_id = department.id AND USER.team_id = team.id AND MONTH(USER.USER_birth) = '" + DateTime.Now.Month + "' ORDER BY DAY(USER.USER_birth), department.dpt_name, team.team_name, USER.USER_name;";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				listBox_Birthday_Month.Items.Clear();
				
				if (!rdr.Read()) {
					listBox_Birthday_Month.Items.Add("이번 달에 생일인 사람은 없습니다.");
					return;
				}

				while (rdr.Read()) {
					listBox_Birthday_Month.Items.Add(rdr[0].ToString() + " " + rdr[1].ToString() + " " + rdr[2].ToString() + " (" + rdr[3].ToString() + "월 " + rdr[4].ToString() + "일)");	
				}
			}
		}
	}
}
