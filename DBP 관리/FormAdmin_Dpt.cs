using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Data;
using System.Windows.Forms;

namespace DBP_관리 {
	public partial class FormAdmin_Dpt : Form {
		public FormAdmin_Dpt() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
            search_treeview();
        }


        //connect directly to DB
        public void search_treeview()
        {
            treeView1.Nodes.Clear();
            string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
            string query = "SELECT dpt_name, group_concat(team_name) FROM s5469698.department left outer join team on department.id = team.dpt_id group by dpt_name";



            using (MySqlConnection connection = new MySqlConnection(Connection_string))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    TreeNode department = new TreeNode(rdr[0].ToString());
                    string teamname = rdr[1].ToString();
                    string[] str_list = teamname.Split(",");
                    foreach (string str in str_list)
                    {
                        department.Nodes.Add(str);
                    }

                    treeView1.Nodes.Add(department);
                }
            }
        }

        // Find Nodes by Textbox1.Text Function
        private TreeNode SearchNode(string SearchText, TreeNode StartNode)
        {
                TreeNode node = null;
                while (StartNode != null)
                {
                    if (StartNode.Text.ToLower().Contains(SearchText.ToLower()))
                    {
                        node = StartNode;
                        break;
                    };
                    if (StartNode.Nodes.Count != 0)
                    {
                        node = SearchNode(SearchText, StartNode.Nodes[0]);  //Recursive Search
                        if (node != null)
                        {
                            break;
                        };
                    };
                    StartNode = StartNode.NextNode;
                };
                return node;
        }


		private void button_Dpt_Search_Click(object sender, EventArgs e)
		{
            string keyword = textBox1.Text;
            TreeNode SelectNode = SearchNode(keyword, treeView1.Nodes[0]);
            SelectNode.EnsureVisible(); //Expand the node
            SelectNode.ForeColor = Color.Red; //SelectNode Marked
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if(label2.Text == "확장")
            {
                treeView1.ExpandAll();
                label2.Text = "축소";
            }
            else if(label2.Text == "축소")
            {
                treeView1.CollapseAll();
                label2.Text = "확장";
            }
        }

        private void button_Dpt_Plus_Click(object sender, EventArgs e)
        {
            FormAdmin_Dpt_Plus frm = new FormAdmin_Dpt_Plus();
            frm.ShowDialog();
        }

        private void 부서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.Hide();
			Point tempPoint = this.Location;
			FormAdmin_Dpt formDpt = new FormAdmin_Dpt();
			formDpt.Location = tempPoint;
			formDpt.Owner = this;
			formDpt.Show();
		}

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.Hide();
			Point tempPoint = this.Location;
			FormAdmin_User formUser = new FormAdmin_User();
			formUser.Location = tempPoint;
			formUser.Owner = this;
			formUser.Show();
		}

        private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
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