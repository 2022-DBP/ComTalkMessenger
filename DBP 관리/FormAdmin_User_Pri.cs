using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBP_관리 {
	public partial class FormAdmin_User_Pri : Form {
		List<string> checkedUserList = new List<string>();
		private string user_name;
		private int user_id;

		public FormAdmin_User_Pri(string user_name, int user_id) {
			InitializeComponent();

			this.user_name = user_name;
			this.user_id = user_id;	//이는 USER 테이블의 User_id가 아닌, ID임(인덱스).

			label_Pri_Title.Text = user_name + " 권한 조정";

			load_treeView_Pri_Chat(user_id);
		}

		private TreeNode SearchNode(string SearchText, TreeNode StartNode) {
			TreeNode node = null;

			while (StartNode != null) {
				if (StartNode.Text.ToLower().Contains(SearchText.ToLower())) {
					node = StartNode;
					break;
				};
				if (StartNode.Nodes.Count != 0) {
					node = SearchNode(SearchText, StartNode.Nodes[0]);  //Recursive Search
					if (node != null) {
						break;
					};
				};
				StartNode = StartNode.NextNode;
			};

			return node;
		}

		private void load_treeView_Pri_Chat(int user_id) {
			//대화 권한 트리뷰(부서-팀-직원, 선택한 유저 제외) 출력

			treeView_Pri_Chat.Nodes.Clear();

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT department.dpt_name, team.team_name, group_concat(USER_name) FROM s5469698.department, team, USER WHERE department.id = team.dpt_id AND USER.team_id = team.id AND USER.ID != " + user_id + " GROUP BY department.dpt_name, team.team_name;";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();
				TreeNode department = null;

				int i = 0; //두번째부터 중복확인하기 위한 변수
				int x = 0; //부서가 중복인지 확인하기 위한 변수

				while (rdr.Read()) {
					TreeNode tn = null;
					if (i >= 1)
						tn = SearchNode(rdr[0].ToString(), treeView_Pri_Chat.Nodes[0]); //부서컬럼이 현재트리에 있는지확인

					TreeNode team = null;
					string username = null;
					string teamname = null;

					if (tn == null) { //부서가 중복이 안되어있으면
						x = 0;
						department = new TreeNode(rdr[0].ToString());

						if (rdr[1].ToString() != null)
							team = new TreeNode(rdr[1].ToString());
					}
					else { //부서 중복이 된 경우
						x = 1;
						tn = SearchNode(rdr[0].ToString(), treeView_Pri_Chat.Nodes[0]);

						if (rdr[1].ToString() != null)
							team = new TreeNode(rdr[1].ToString());
					}

					if (rdr[2].ToString() != null) { //팀원이 있으면 팀원 추가
						username = rdr[2].ToString();
						string[] str_list = username.Split(",");

						if (department != null)
							foreach (string str in str_list) {
								team.Nodes.Add(str);
							}
					}

					department.Nodes.Add(team);

					if (x == 0) //부서가 중복이 안되있으면 상위노드(부서노드) 트리뷰에 추가
						treeView_Pri_Chat.Nodes.Add(department);

					i++;
				}
			}

			treeView_Pri_Chat.ExpandAll();

			Check_Unable_Users();
		}

		private void Check_Unable_Users() {
			//이미 사용자와 대화 제한을 걸었던 부서, 팀, 직원은 체크를 해둬야함

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT department.dpt_name, team.team_name, group_concat(USER.USER_name) FROM department, team, USER, USER_PriChat WHERE USER_PriChat.UnableChat_User_ID = USER.ID AND USER_PriChat.User_id = " + user_id + " AND department.id = USER.department_id AND team.id = USER.team_id GROUP BY department.dpt_name, team.team_name;";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();
				
				while (rdr.Read()) {
					string department_name = rdr[0].ToString();
					string team_name = rdr[1].ToString();
					string[] user_list = rdr[2].ToString().Split(",");

					TreeNode dptNode = SearchNode(department_name, treeView_Pri_Chat.Nodes[0]);
					TreeNode teamNode = SearchNode(team_name, dptNode);
					foreach (string user_name in user_list) {
						TreeNode userNode = SearchNode(user_name, teamNode);

						userNode.Checked = true;
					}
					
				}
			}
		}

		private void ChildNodeChecking(TreeNode selectNode) {
			//선택한 노드의 자식 노드들 체크
			foreach(TreeNode tn in selectNode.Nodes) {
				tn.Checked = selectNode.Checked;
				ChildNodeChecking(tn);
			}
			return;
		}

		private void ParentNodeChecking(TreeNode selectNode) {
			//선택한 노드가 부모의 유일한 자식 노드라면, 부모 노드도 체크
			TreeNode t = selectNode.Parent;
			if (t != null) {
				t.Checked = true;
				foreach (TreeNode tn in t.Nodes) {
					if (!tn.Checked) {
						t.Checked = false;
						break;
					}
				}
				ParentNodeChecking(t);
			}
		}

		private void treeView_Pri_Chat_AfterCheck(object sender, TreeViewEventArgs e) {
			//노드가 체크되었을 경우 체크한 노드에 대해서 자식과 부모 노드 체크 처리
			treeView_Pri_Chat.AfterCheck -= treeView_Pri_Chat_AfterCheck;
			ChildNodeChecking(e.Node);
			ParentNodeChecking(e.Node);
			treeView_Pri_Chat.AfterCheck += treeView_Pri_Chat_AfterCheck;

			if (e.Node.Checked == true) {
				if (e.Node.Parent != null && e.Node.Parent.Parent != null)
					checkedUserList.Add(e.Node.Parent.Parent.Text + " " + e.Node.Parent.Text + " " + e.Node.Text);
			}
			else {
				if (e.Node.Parent != null && e.Node.Parent.Parent != null)
					checkedUserList.Remove(e.Node.Parent.Parent.Text + " " + e.Node.Parent.Text + " " + e.Node.Text);
			}

			checkedUserList = checkedUserList.Distinct().ToList();	//리스트 중복 제거
		}

		private void treeView_Pri_Chat_AfterSelect(object sender, TreeViewEventArgs e) {
			//체크박스만 체크하도록 이름 선택시 선택 해제
			treeView_Pri_Chat.SelectedNode = null;
		}

		private int get_user_id(string user_name, string user_dpt, string user_team) {
			//사용자의 이름, 소속 부서명, 소속 팀명을 가져와서 사용자 id 반환

			int user_id = 0;

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT USER.ID FROM s5469698.USER, department, team WHERE USER_name = '" + user_name + "' AND department.dpt_name = '" + user_dpt + "' AND team.team_name = '" + user_team + "' AND department_id = department.id AND team_id = team.id;";

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

		private void button_Pri_Chat_Click(object sender, EventArgs e) {
			//INSERT 전에 체크 해제, 즉 기존의 대화 제한을 해제했을 수 있으므로 선택한 사용자의 대화 제한 목록을 DELETE하기

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "DELETE FROM USER_PriChat WHERE User_ID = " + user_id + ";";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) { }
			}

			//이후 리스트에 저장된 목록을 불러 하나씩 하나씩 INSERT하기

			foreach (string str in checkedUserList) {
				string[] info = str.Split(" ");
				string selected_dpt_name = info[0];
				string selected_team_name = info[1];
				string selected_user_name = info[2];
				int selected_user_id = get_user_id(selected_user_name, selected_dpt_name, selected_team_name);
				MessageBox.Show("번호: " + selected_user_id);

				query = "INSERT INTO USER_PriChat(User_ID, UnableChat_User_ID) VALUES (" + user_id + ", " + selected_user_id + ");";

				using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
					connection.Open();
					MySqlCommand cmd = new MySqlCommand(query, connection);
					MySqlDataReader rdr = cmd.ExecuteReader();

					while (rdr.Read()) { }
				}
			}

			MessageBox.Show("대화 제한 갱신 완료");
			load_treeView_Pri_Chat(user_id);
		}
	}
}