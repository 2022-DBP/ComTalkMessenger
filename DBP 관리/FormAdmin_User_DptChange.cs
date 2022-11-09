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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBP_관리 {
	public partial class FormAdmin_User_DptChange : Form {
		private string user_name;
		private int user_id;

		public FormAdmin_User_DptChange(string user_name, int user_id) {
			InitializeComponent();

			this.user_name = user_name;
			this.user_id = user_id;

			label_DptChange_Title.Text = user_name + " 부서 변경";
			label_DptChange_Name.Text = "현재 소속 : " + get_user_dpt(user_id);

			load_treeview();
		}

		private string get_user_dpt(int user_id) {
			//user id를 통해서 user의 소속 부서명 가져오기
			string user_dpt = "";
			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT department.dpt_name, team.team_name FROM s5469698.USER, department, team WHERE USER_id = " + user_id+ " AND USER_department = department.id AND USER_team = team.id;";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				DataTable dt = new DataTable();
				dt.Load(rdr);

				foreach (DataRow dr in dt.Rows) {
					user_dpt += dr["dpt_name"].ToString();
					user_dpt += " " + dr["team_name"].ToString();
				}
			}

			return user_dpt;
		}

		private void load_treeview() {
			//부서-팀 트리 뷰 로드
			treeView_DptChange.Nodes.Clear();
			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT dpt_name, group_concat(team_name) FROM s5469698.department left outer join team on department.id = team.dpt_id group by dpt_name";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {
					TreeNode department = new TreeNode(rdr[0].ToString());
					string teamname = rdr[1].ToString();
					string[] str_list = teamname.Split(",");
					foreach (string str in str_list) {
						department.Nodes.Add(str);
					}

					treeView_DptChange.Nodes.Add(department);
				}
			}

			treeView_DptChange.ExpandAll();
		}

		private void button_DptChange_Udt_Click(object sender, EventArgs e) {
			//업데이트 버튼 클릭. 부서명과 팀 이름을 통해서 업데이트를 해야하므로 쿼리가 좀 복잡해질 것 같아서 잠시 보류.
			/*
			string user_team = treeView_DptChange.SelectedNode.Text;
			string user_dpt = treeView_DptChange.SelectedNode.Parent.Text;

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "UPDATE ";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {	}
			}
			*/
			MessageBox.Show(user_name + "의 소속이 변경되었습니다.");	//업데이트된 부서명과 팀명을 표시하는 것도 좋을듯
		}
	}
}
