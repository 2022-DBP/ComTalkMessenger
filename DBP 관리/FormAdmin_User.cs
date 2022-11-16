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
		}

		private void load_user_treeview() {
			//부서-팀-사용자 트리뷰 출력

			treeView_User.Nodes.Clear();
			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT dpt_name, group_concat(USER_name) FROM s5469698.department left outer join USER on department_id = department.id group by dpt_name";
			//수정 사항 : 부서-팀-유저 단위로 출력해야함. 생각해볼것..
			//아이디어 : 부서-팀(concat) 쿼리로 출력해 트리뷰를 만들고, 다시 부서-팀-직원(concat) 쿼리로 출력해서 해당하는 부서-팀에 따라(case? if?) 직원을 자식노드로 추가.

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

		private int get_user_id(string user_name, string user_dpt) {
			//사용자의 이름, 소속 부서명을 가져와서 사용자 반환. 동명이인이 있을 수 있으므로 이름뿐만 아닌 부서명도 포함해서 찾음. (팀까지 같은 경우는 배제..)
			//사용자 트리뷰의 팀 쿼리 문제가 해결되면, 팀도 추가할 것.

			int user_id = 0;

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT USER.ID FROM s5469698.USER, department WHERE USER_name = '" + user_name + "' AND department.dpt_name = '" + user_dpt + "' AND department_id = department.id;";

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
			string query = "SELECT department.dpt_name, team.team_name FROM s5469698.USER, department, team WHERE USER.ID = " + user_id + " AND department_id = department.id AND team_id = team.id;";

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

		private void load_dptchange_treeview() {
			//부서 변경의 부서-팀 트리 뷰 출력.

			treeView_User_DptChange.Nodes.Clear();
			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT dpt_name, group_concat(team_name) FROM s5469698.department left outer join team on department.id = team.dpt_id group by dpt_name";
			//수정 사항 : 현재 소속된 팀은 제외할 것.

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

		private void treeView_User_AfterSelect(object sender, TreeViewEventArgs e) {
			//사용자 목록 트리뷰 선택시

			if (treeView_User.SelectedNode.Nodes.Count == 0) {   //선택한 노드 아래에 더 이상 노드가 없다 = 자식 노드(직원)를 선택했다.
				string user_name = treeView_User.SelectedNode.Text;
				string user_dpt = treeView_User.SelectedNode.Parent.Text;   //팀 추가시 Parent.Parent.Text로 변경해야함..
				int user_id = get_user_id(user_name, user_dpt);

				label_User_Name.Text = "관리할 사용자 : " + user_name;
				label_User_DptChange_Name1.Text = "현재 소속 : " + get_user_dpt(user_id);

				load_dptchange_treeview();
				button_User_Pri.Enabled = true;
				button_User_Chat.Enabled = true;
				dateTimePicker_User_Log.Enabled = true;
			}
			else
				treeView_User.SelectedNode = null;  //아니면 선택 해제
		}

		private void treeView_User_DptChange_AfterSelect(object sender, TreeViewEventArgs e) {
			//부서 변경 트리뷰 선택시

			if (treeView_User_DptChange.SelectedNode.Nodes.Count == 0) { //트리뷰에서 자식 노드를 선택했다면
				label_User_DptChange_Name2.Text = "변경 소속 : " + treeView_User_DptChange.SelectedNode.Parent.Text + " " + treeView_User_DptChange.SelectedNode.Text;
				button_User_DptChange.Enabled = true;
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
			string query = "UPDATE s5469698.USER SET USER.department_id = (SELECT department.id FROM department WHERE department.dpt_name = '" + user_dptchange_dpt + "'), USER.team_id = (SELECT team.id FROM team WHERE team.team_name = '" + user_dptchange_team + "') WHERE USER.ID = " + user_id + ";";
			//수정 사항 : 팀명으로 찾는 쿼리라서 다른 부서임에도 같은 팀명이 있어 오류 발생. 같은 부서명은 없을 것으로 생각하자..
			//team 업데이트 부질의에서 team.dpt_id와 바꿀 department.id가 같다는 조건을 추가하면 될듯..?

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) { }
			}

			MessageBox.Show(user_name + "의 소속이 변경되었습니다.");

			load_user_treeview();
			button_User_Pri.Enabled = false;
			button_User_Chat.Enabled = false;
			button_User_DptChange.Enabled = false;
			dateTimePicker_User_Log.Enabled = false;
		}

		private void dateTimePicker_User_Log_ValueChanged(object sender, EventArgs e) {
			//사용자 로그 검색
			//수정 사항 : dateTimePicker 포맷을 시간, 분까지 선택가능하도록 변경.
			//Login_log 테이블 DATETIME 기본 형식 YYYY-MM-DD hh:mm:ss

			string user_name = treeView_User.SelectedNode.Text;
			string user_dpt = treeView_User.SelectedNode.Parent.Text;
			int user_id = get_user_id(user_name, user_dpt);

			string date = dateTimePicker_User_Log.Text;

			string query = "SELECT ... FROM USER WHERE ...";
			//날짜 선택 후 해당 날짜의 기록을 SELECT하는 쿼리로 로그 검색.
			//이 기능들은 다른 파트 구현 후에 가능하므로 일단 보류.
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

		private void button_User_Chat_Click(object sender, EventArgs e) {
			//사용자 대화 내용 검색 폼 열기

			string user_name = treeView_User.SelectedNode.Text;
			string user_dpt = treeView_User.SelectedNode.Parent.Text;
			int user_id = get_user_id(user_name, user_dpt);

			Point tempPoint = this.Location;
			FormAdmin_User_Chat formChat = new FormAdmin_User_Chat(user_name, user_id);
			formChat.Location = tempPoint;
			formChat.Owner = this;
			formChat.Show();
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
			MessageBox.Show("현재 사용자 관리 페이지입니다.");
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
