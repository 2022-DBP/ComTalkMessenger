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
	public partial class FormAdmin_User : Form {
		public FormAdmin_User() {
			InitializeComponent();
		}

		private void FormAdmin_User_Load(object sender, EventArgs e) {
			load_user_treeview();
			load_dptchange_treeview();
		}

		private void load_user_treeview() {
			//부서-팀-사용자 트리뷰 출력
			//부서와 해당 팀에 속하는 직원명을 어떤 쿼리로 끌어내야할지 안떠올라서 일단 부서까지만 해두고 보류.. 향후 수정할 것.

			treeView_User.Nodes.Clear();
			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT dpt_name, group_concat(USER_name) FROM s5469698.department left outer join USER on USER_department = department.id group by dpt_name";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {
					TreeNode department = new TreeNode(rdr[0].ToString());
					string user_name = rdr[1].ToString();
					string[] str_list = user_name.Split(",");

					foreach (string str in str_list) {
						department.Nodes.Add(str);
					}

					treeView_User.Nodes.Add(department);
				}
			}

			treeView_User.ExpandAll();
		}

		private void load_dptchange_treeview() {
			//부서 변경의 부서-팀 트리 뷰 출력.

			treeView_User_DptChange.Nodes.Clear();
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

					treeView_User_DptChange.Nodes.Add(department);
				}
			}

			treeView_User_DptChange.ExpandAll();
		}

		private int get_user_id(string user_name, string user_dpt) {
			//사용자의 이름, 소속 부서명을 가져와서 사용자 반환. 동명이인이 있을 수 있으므로 이름뿐만 아닌 부서명도 포함해서 찾음. (팀까지 같은 경우는 배제..)
			//사용자 트리뷰의 팀 쿼리 문제가 해결되면, 팀도 추가할 것.

			int user_id = 0;

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT USER_id FROM s5469698.USER, department WHERE USER_name = '" + user_name + "' AND department.dpt_name = '" + user_dpt + "' AND USER_department = department.id;";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {
					string str = rdr[0].ToString();
					user_id = Int32.Parse(str);
				}
			}

			return user_id;
		}

		private string get_user_dpt(int user_id) {
			//사용자의 id를 통해서 사용자의 소속 부서명 가져오기

			string user_dpt = "";
			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT department.dpt_name, team.team_name FROM s5469698.USER, department, team WHERE USER_id = " + user_id + " AND USER_department = department.id AND USER_team = team.id;";

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

		private void treeView_User_AfterSelect(object sender, TreeViewEventArgs e) {
			//사용자 목록 트리뷰 선택시

			if (treeView_User.SelectedNode.Nodes.Count == 0) {   //선택한 노드 아래에 더 이상 노드가 없다 = 자식 노드(직원)를 선택했다.
				string user_name = treeView_User.SelectedNode.Text;
				string user_dpt = treeView_User.SelectedNode.Parent.Text;   //팀 추가시 Parent.Parent.Text로 변경해야함..
				int user_id = get_user_id(user_name, user_dpt);

				label_User_Name.Text = "관리할 사용자 : " + user_name;
				label_User_DptChange_Name1.Text = "현재 소속 : " + get_user_dpt(user_id);
			}
			else
				treeView_User.SelectedNode = null;  //아니면 선택 해제
		}

		private void treeView_User_DptChange_AfterSelect(object sender, TreeViewEventArgs e) {
			//부서 변경 트리뷰 선택시

			if (treeView_User_DptChange.SelectedNode.Nodes.Count == 0) { //트리뷰에서 자식 노드를 선택했다면
				label_User_DptChange_Name2.Text = "변경 소속 : " + treeView_User_DptChange.SelectedNode.Parent.Text + " " + treeView_User_DptChange.SelectedNode.Text;
			}
			else
				treeView_User_DptChange.SelectedNode = null;    //아니면 선택 해제
		}

		private void button_User_DptChange_Click(object sender, EventArgs e) {
			//사용자 부서 변경
			string user_name = treeView_User.SelectedNode.Text;
			string user_dpt = treeView_User.SelectedNode.Parent.Text;
			int user_id = get_user_id(user_name, user_dpt);

			string user_dptchange_team = treeView_User_DptChange.SelectedNode.Text;
			string user_dptchange_dpt = treeView_User_DptChange.SelectedNode.Parent.Text;

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "UPDATE s5469698.USER SET USER.USER_department = (SELECT department.id FROM department WHERE department.dpt_name = '" + user_dptchange_dpt + "'), USER.USER_team = (SELECT team.id FROM team WHERE team.team_name = '" + user_dptchange_team + "') WHERE USER.USER_id = '" + user_id + "';";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) { }
			}

			MessageBox.Show(user_name + "의 소속이 변경되었습니다.");
			load_user_treeview();
		}

		private void button_User_Chat_Click(object sender, EventArgs e) {
			//사용자 로그 검색

			if (String.IsNullOrEmpty(textBox_User_Chat.Text)) {
				MessageBox.Show("검색 내용을 입력해주세요.");
				return;
			}
			string search_text = textBox_User_Chat.Text;

			//이후 기능들은 채팅 구현 후에 가능하므로 보류..
			//일단 DataGridView를 넣었지만, 대화 내용도 시간별/키워드별로 검색해야하므로 공간이 작아서 차라리 아래 권한 조정을 넣고 검색은 따로 빼는게 어떨까싶음
		}

		private void button_User_Pri_Click(object sender, EventArgs e) {
			//사용자 권한 조정 폼 열기

			string user_name = treeView_User.SelectedNode.Text;
			string user_dpt = treeView_User.SelectedNode.Parent.Text;
			int user_id = get_user_id(user_name, user_dpt);

			Point tempPoint = this.Location;
			FormAdmin_User_Pri formPri = new FormAdmin_User_Pri(user_name, user_id);
			formPri.Location = tempPoint;
			formPri.Owner = this;
			formPri.Show();
		}


		//이하 네비게이션 바 버튼 클릭시 이벤트
		private void 부서관리ToolStripMenuItem_Click(object sender, EventArgs e) {
			this.Hide();
			Point tempPoint = this.Location;
			FormAdmin_Dpt formDpt = new FormAdmin_Dpt();
			formDpt.Location = tempPoint;
			formDpt.Owner = this;
			formDpt.Show();
		}

		private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e) {
			this.Hide();
			Point tempPoint = this.Location;
			FormAdmin_User formUser = new FormAdmin_User();
			formUser.Location = tempPoint;
			formUser.Owner = this;
			formUser.Show();
		}

		private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e) {
			MessageBox.Show("로그 아웃");

			this.Hide();
			Point tempPoint = this.Location;
			Form_Login formLogin = new Form_Login();
			formLogin.Location = tempPoint;
			formLogin.Owner = this;
			formLogin.Show();
		}
	}
}
