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
			load_treeview();
		}

		private void load_treeview() {
			//부서-팀-사용자 트리뷰 출력. 부서와 해당 팀에 속하는 직원명을 어떤 쿼리로 끌어내야할지 안떠올라서 일단 부서까지만 해두고 보류.. 가능하면 함수로 빼도 될듯

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

		private int get_user_id(string user_name, string user_dpt) {
			//user의 이름, 소속 부서명을 가져와서 id 반환.(동명이인이 있을 수 있으므로. 트리의 팀 쿼리 문제가 해결되면, 팀도 추가할 것. 다 같은 소속이고 동명 이인일 경우는 배제..)
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

		//현재 아래 기능들에서 트리의 부모(부서, 팀명)를 선택할 수 있어서 버그 위험이 있기에 수정이 필요할듯..(선택이 안되게 한다던지)
		private void treeView_User_AfterSelect(object sender, TreeViewEventArgs e) {
			label_User_Name.Text = treeView_User.SelectedNode.Text;
		}

		private void button_User_DptChange_Click(object sender, EventArgs e) {
			//부서 변경 폼 열기
			string user_name = treeView_User.SelectedNode.Text;
			string user_dpt = treeView_User.SelectedNode.Parent.Text;
			int user_id = get_user_id(user_name, user_dpt);

			Point tempPoint = this.Location;
			FormAdmin_User_DptChange formDptChange = new FormAdmin_User_DptChange(user_name, user_id);
			formDptChange.Location = tempPoint;
			formDptChange.Owner = this;
			formDptChange.Show();
		}

		private void button_User_Chat_Click(object sender, EventArgs e) {
			//로그 검색 폼 열기
			string user_name = treeView_User.SelectedNode.Text;
			string user_dpt = treeView_User.SelectedNode.Parent.Text;
			int user_id = get_user_id(user_name, user_dpt);

			Point tempPoint = this.Location;
			FormAdmin_User_Chat formUserChat = new FormAdmin_User_Chat(user_name, user_id);
			formUserChat.Location = tempPoint;
			formUserChat.Owner = this;
			formUserChat.Show();
		}

		private void button_User_Pri_Click(object sender, EventArgs e) {
			//권한 조정 폼 열기
			string user_name = treeView_User.SelectedNode.Text;
			string user_dpt = treeView_User.SelectedNode.Parent.Text;
			int user_id = get_user_id(user_name, user_dpt);

			Point tempPoint = this.Location;
			FormAdmin_User_Pri formPri = new FormAdmin_User_Pri(user_name, user_id);
			formPri.Location = tempPoint;
			formPri.Owner = this;
			formPri.Show();
		}

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
