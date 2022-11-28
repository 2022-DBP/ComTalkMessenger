using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SocketIOClient;
using WebSocket4Net;
using MySql.Data.MySqlClient;
using System.Collections;
using Org.BouncyCastle.Utilities.Collections;
using MySqlX.XDevAPI.Relational;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chatting_Form
{
    public partial class FormChattingRoom : Form
    {


        public FormChattingRoom()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            search_treeview();
            view_list();
            textBox1.Visible = false;
        }

        private TreeNode SearchNode(string SearchText, TreeNode StartNode) //문자열로 노드 찾는 메서드
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
        public void search_treeview() //메인화면 트리뷰 메서드
        {
            treeView1.Nodes.Clear();
            string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
            string query = "SELECT department.dpt_name, team.team_name, group_concat(USER_nickname) FROM s5469698.department left outer join s5469698.team on department.id = team.dpt_id left outer join s5469698.USER on USER.team_id = team.id group by department.dpt_name, team.team_name;";

            using (MySqlConnection connection = new MySqlConnection(Connection_string))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                TreeNode department = null;
                int i = 0; //두번째부터 중복확인하기 위한 변수
                int x = 0; //부서가 중복인지 확인하기 위한 변수
                while (rdr.Read())
                {
                    TreeNode tn = null;
                    if (i >= 1)
                    {
                        tn = SearchNode(rdr[0].ToString(), treeView1.Nodes[0]); //부서컬럼이 현재트리에 있는지확인
                    }
                    TreeNode team = null;
                    string username = null;
                    string teamname = null;
                    if (tn == null) //부서가 중복이 안되어있으면
                    {
                        x = 0;
                        department = new TreeNode(rdr[0].ToString());
                        if (rdr[1].ToString() != null)
                        {
                            team = new TreeNode(rdr[1].ToString());
                        }
                    }
                    else //부서 중복이 된 경우
                    {
                        x = 1;
                        tn = SearchNode(rdr[0].ToString(), treeView1.Nodes[0]);
                        if (rdr[1].ToString() != null)
                        {
                            team = new TreeNode(rdr[1].ToString());
                        }
                    }

                    if (rdr[2].ToString() != null) //팀원이 있으면 팀원 추가
                    {
                        username = rdr[2].ToString();
                        string[] str_list = username.Split(',');
                        if (department != null)
                        {
                            foreach (string str in str_list)
                            {
                                team.Nodes.Add(str);
                            }
                        }
                    }
                    department.Nodes.Add(team);
                    if (x == 0) //부서가 중복이 안되있으면 상위노드(부서노드) 트리뷰에 추가
                    {
                        treeView1.Nodes.Add(department);
                    }
                    i++;
                }
            }
        }

        //대화방 불러오기 기능 이것도 유저가  A라고 가정후 실시 
        public void view_list()
        {
            string conn = "Data Source = 115.85.181.212; Database=s5469698; Uid=s5469698; Pwd=s5469698; CharSet=utf8;";
            string query = "SELECT idRoom, USER1, USER2 From Room WHERE idRoom IN (SELECT idRoom FROM Room WHERE USER1 = 'A' OR USER2 = 'A' GROUP BY idRoom);";

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(rdr);
                foreach (DataRow row in dt.Rows)
                {
                    listBox1.Items.Add(row["idRoom"]);
                }
            }
        }

        //대화 연결
        private void listBoxChattingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormChatting formChatting = new FormChatting();

            formChatting.Show();
        }


        //treenode 더블클릭시 대화방 생성 
        //임의로 유저는 A로 고정 한 상태
        private void Chatting(object sender, TreeNodeMouseClickEventArgs e)
        {
            string conn = "Data Source = 115.85.181.212; Database=s5469698; Uid=s5469698; Pwd=s5469698; CharSet=utf8;";
            string query = "SELECT distinct idRoom FROM Room WHERE (Room.USER1 = 'A' AND Room.USER2 = '" + e.Node.Text + "') OR (Room.USER1 = '" + e.Node.Text + "' AND Room.USER2 = 'A');";

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    //만약 값이 널이라면 룸 생성
                    //널값 구분??
                    if (rdr[0].ToString() == null)
                    {
                        string query2 = "INSERT INTO Room values('고유값', 'A', '" + e.Node.Text + "');";
                        MySqlConnection connect = new MySqlConnection(conn);
                        connect.Open();
                        MySqlCommand cmd2 = new MySqlCommand(query2, connect);
                        MySqlDataReader rdr2 = cmd2.ExecuteReader();
                    }
                    else
                    {
                        MessageBox.Show("이미 대화방이 존재합니다.");
                    }
                }
            }


        }

          
        //로그아웃 기능
        private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
