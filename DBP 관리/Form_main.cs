using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBP_관리
{
    public partial class Form_main : Form
    {
        private static string Font = null;
        private static int Size = 0;
        public static string myID = null;
        public static string myNickName = null;
        TcpClient client = null;
        Thread ReceiveThread = null;
        Form_ChattingRoom chattingWindow = null;
        Dictionary<string, ChattingThreadData> chattingThreadDic = new Dictionary<string, ChattingThreadData>();
        private static ObservableCollection<User> currentUserList = new ObservableCollection<User>();

        private List<string> ChattingUserList = new List<string>();
        private string oneOnOneReceiverID { get; set; }
        public string OneOnOneReceiverID
        {
            get
            {
                return oneOnOneReceiverID;
            }
            private set
            {
                oneOnOneReceiverID = value;
            }

        }
        private string oneOnOneReceiverName { get; set; }
        public string OneOnOneReceiverName
        {
            get
            {
                return oneOnOneReceiverName;
            }
            private set
            {
                oneOnOneReceiverName = value;
            }

        }

        private void RecieveMessage()
        {
            string receiveMessage = "";
            List<string> receiveMessageList = new List<string>();
            while (true)
            {
                try
                {
                    byte[] receiveByte = new byte[1024];
                    client.GetStream().Read(receiveByte, 0, receiveByte.Length);


                    receiveMessage = UTF8Encoding.UTF8.GetString(receiveByte);

                    string[] receiveMessageArray = receiveMessage.Split('>');
                    foreach (var item in receiveMessageArray)
                    {
                        if (!item.Contains('<'))
                            continue;
                        if (item.Contains("관리자<TEST"))
                            continue;

                        receiveMessageList.Add(item);
                    }

                    ParsingReceiveMessage(receiveMessageList);
                }
                catch (Exception e)
                {
                    MessageBox.Show("서버와의 연결이 끊어졌습니다.");
                    MessageBox.Show(e.Message);
                    MessageBox.Show(e.StackTrace);
                    Environment.Exit(1);
                }
                Thread.Sleep(500);
            }
        }

        private void ParsingReceiveMessage(List<string> messageList)
        {
            foreach (var item in messageList)
            {
                string chattingPartner = "";
                string message = "";

                if (item.Contains('<'))
                {
                    string[] splitedMsg = item.Split('<');

                    chattingPartner = splitedMsg[0];
                    message = splitedMsg[1];

                    // 하트비트 
                    if (chattingPartner == "관리자")
                    {
                        ObservableCollection<User> tempUserList = new ObservableCollection<User>();
                        string[] splitedUser = message.Split('$');
                        foreach (var el in splitedUser)
                        {
                            if (string.IsNullOrEmpty(el))
                                continue;
                            string[] IDSplitedUser = el.Split('%');
                            tempUserList.Add(new User(IDSplitedUser[1], IDSplitedUser[0]));//새로운 유저 들어오면 Add
                        }
                        currentUserList.Clear();

                        messageList.Clear();
                        return;
                    }
                    
                    // 1:1채팅

                    if (!chattingThreadDic.ContainsKey(chattingPartner))
                    {
                        string RoomID = message.Split('#')[0];
                        if (message.Split('#')[1] == "ChattingStart")//채팅 시작 요청
                        {
                            Thread chattingThread = new Thread(() => ThreadStartingPoint(chattingPartner, RoomID));//chattingPartner. 서버에서 userID랑 Name 모두 보내줄 것 
                            chattingThread.SetApartmentState(ApartmentState.STA);
                            chattingThread.IsBackground = true;
                            chattingThread.Start();
                        }
                    }
                    else
                    {
                        if (chattingThreadDic[chattingPartner].chattingThread.IsAlive)
                        {
                            chattingThreadDic[chattingPartner].chattingWindow.ReceiveMessage(chattingPartner, message);
                        }
                    }
                    messageList.Clear();
                    return;

                }
            }
            messageList.Clear();
        }
        
        private void ThreadStartingPoint(string chattingPartner, string RoomID)
        {
            chattingWindow = new Form_ChattingRoom(client, chattingPartner, RoomID, Get_ID(receivedData));
            chattingThreadDic.Add(chattingPartner, new ChattingThreadData(Thread.CurrentThread, chattingWindow));
            chattingWindow.ShowDialog();
            chattingThreadDic.Remove(chattingPartner);
        }
        public string receivedData;
		private string selectedColor = "";


        public Form_main(string Data)
        {
            InitializeComponent();
            receivedData = Data;
            myID = receivedData;//로그인할때 정보를 받아올 것
            //로그인할 때 쓰는 User_id 말고 int형인 ID여야 합니다.->추후 clientNumber로 사용

            textBoxIPAdress.Text = "127.0.0.1";

            Login();

			string user_ID = Get_ID(receivedData);
            SELECT_Font(user_ID);
            Load_User_Config(user_ID);
		}
        private void Login()
        {
            try
            {
                string ip = textBoxIPAdress.Text;
                string parsedID = "%^&";
                parsedID += myID;
                client = new TcpClient();
                client.Connect(ip, 9999);//직접 설정한 ip로 연결

                byte[] byteData = new byte[parsedID.Length];
                byteData = UTF8Encoding.UTF8.GetBytes(parsedID);//Name추가해서 보내기
                client.GetStream().Write(byteData, 0, byteData.Length);

                myNickName = SearchNickNamewithID(myID);
                label1.Text = myNickName;

                Info.Text = string.Format("{0} 님 반갑습니다 ", myNickName);

                ReceiveThread = new Thread(RecieveMessage);
                ReceiveThread.Start();
            }

            catch
            {
                MessageBox.Show("서버연결에 실패하였습니다.");
                client = null;
            }
        }


		private string Get_ID(string Data) {
			string ID = "";
			string conn = "Data Source = 115.85.181.212; Database=s5469698; Uid=s5469698; Pwd=s5469698; CharSet=utf8;";
			string query = "SELECT ID FROM USER WHERE USER_id = '" + Data + "';";

			using (MySqlConnection connection = new MySqlConnection(conn)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {
					ID = rdr[0].ToString();
				}
			}

			return ID;
		}

		private void Load_User_Config(string user_ID) {
			//원래 저장된 테마 데이터 불러오기 및 적용

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT Back_Color FROM USER_Config WHERE User_ID = " + user_ID + ";";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				if (!rdr.Read()) {
					//기존 데이터가 없다면 기본 다크 모드
					selectedColor = "DarkMode";
					Apply_Mode(selectedColor);
                    return;
				}

				selectedColor = rdr[0].ToString();
			}
			Apply_Mode(selectedColor);
		}

		private void Apply_Mode(string selectedColor) {
			if (selectedColor.Equals("DarkMode")) {
				this.BackColor = Color.FromArgb(66, 66, 66);
				this.ForeColor = Color.White;
			}
			else {
				this.BackColor = Color.White;
				this.ForeColor = Color.FromArgb(66, 66, 66);
			}
			this.groupBox1.BackColor = this.BackColor;
			this.groupBox1.ForeColor = this.ForeColor;
			this.group_profile.BackColor = this.BackColor;
			this.group_profile.ForeColor = this.ForeColor;
			this.main_profile.BackColor = this.BackColor;
			this.label_alterProfile.BackColor = this.BackColor;
			this.label_alterProfile.ForeColor = this.ForeColor;
			this.profile_nick.BackColor = this.BackColor;
			this.profile_nick.ForeColor = this.ForeColor;
			this.txt_nick.BackColor = this.BackColor;
			this.txt_nick.ForeColor = this.ForeColor;
			this.label_dapartment.BackColor = this.BackColor;
			this.label_dapartment.ForeColor = this.ForeColor;
			this.txt_department.BackColor = this.BackColor;
			this.txt_department.ForeColor = this.ForeColor;
			this.label_team.BackColor = this.BackColor;
			this.label_team.ForeColor = this.ForeColor;
			this.txt_team.BackColor = this.BackColor;
			this.txt_team.ForeColor = this.ForeColor;
			this.btn_main_logout.BackColor = this.ForeColor;
			this.btn_main_logout.ForeColor = this.BackColor;
		}


		private void Form_main_Load_1(object sender, EventArgs e)
        {
            search_treeview();
            view_list();
            // 로딩 시 데이터 자동 로드
            LoginManager.Instance.LoadUserData(receivedData, main_profile, txt_nick, txt_department, txt_team);
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

        //대화방 불러오기 기능
        public void view_list()
        {
            listBox1.Items.Clear();
            string conn = "Data Source = 115.85.181.212; Database=s5469698; Uid=s5469698; Pwd=s5469698; CharSet=utf8;";
            string query = "SELECT distinct USER1, USER2 From Room WHERE idRoom IN (SELECT idRoom FROM Room WHERE USER1 = \"" + myNickName + "\" OR USER2 = \"" + myNickName + "\" GROUP BY idRoom);";

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(rdr);
                foreach (DataRow row in dt.Rows)
                {
                    listBox1.Items.Add(row["USER1"]);
                    listBox1.Items.Add(row["USER2"]);
                    listBox1.Items.Remove("" + myNickName + "");
                }
            }

        }

        //treenode 더블클릭시 대화방 생성 
        //임의로 유저는 A로 고정 한 상태
        private void Chatting(object sender, TreeNodeMouseClickEventArgs e)
        {
            string conn = "Data Source = 115.85.181.212; Database=s5469698; Uid=s5469698; Pwd=s5469698; CharSet=utf8;";
            string query = "SELECT distinct idRoom FROM Room WHERE (Room.USER1 =\"" + myNickName + "\" AND Room.USER2 = '" + e.Node.Text + "') OR (Room.USER1 = '" + e.Node.Text + "' AND Room.USER2 = 'A');";

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();

                
                    //만약 값이 널이라면 룸 생성
                    if (rdr.HasRows)
                    {           
                    }
                    else
                    {
                    string query2 = "INSERT INTO Room (USER1,USER2) values('" + myNickName + "', '" + e.Node.Text + "');";
                    MySqlConnection connect = new MySqlConnection(conn);
                    connect.Open();
                    MySqlCommand cmd2 = new MySqlCommand(query2, connect);
                    MySqlDataReader rdr2 = cmd2.ExecuteReader();
                    connect.Close();
                    view_list();
                }      
            }
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("채팅상대를 선택해주세요.", "Information");
                return;
            }

            OneOnOneReceiverName = treeView1.SelectedNode.ToString();
            OneOnOneReceiverName = OneOnOneReceiverName.Split(": ")[1];
            OneOnOneReceiverID = SearchIDwithNickName(OneOnOneReceiverName);
            if (myID == OneOnOneReceiverID)//내 아이디와 선택한 유저의 아이디 비교
            {
                MessageBox.Show("자기 자신과는 채팅할 수 없습니다.");
                OneOnOneReceiverName = "";
                OneOnOneReceiverID = "";
                return;
            }
            //이부분 자체가 현 프로그램에서 작동이 불가능해서 변경
            string start_msg = OneOnOneReceiverName + "님과 채팅을 시작합니다";
            MessageBox.Show(start_msg);

            Chatting_Start();


        }


        //로그아웃 기능
        private void btn_main_logout_Click(object sender, EventArgs e)
        {
            LoginManager.Instance.Logout(receivedData);
            MessageBox.Show("로그아웃 되었습니다.");
            Owner.Show();
            Application.Restart();
        }

        private void label_profile_click(object sender, EventArgs e)
        {
            Form_ChangeProfile cp = new Form_ChangeProfile(receivedData);
            cp.dataEvent += new DataEventHandler(this.CheckEvent);
            cp.ShowDialog();
        }

        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();

        }
        private void Chatting_Start()//채팅 시작하자고 서버에 요청
        {
            string chattingStartMessage = string.Format("{0}%{1}<ChattingStart>", OneOnOneReceiverID, OneOnOneReceiverName);//UserID, UserName으로 ChattingStart작성
            byte[] chattingStartByte = UTF8Encoding.UTF8.GetBytes(chattingStartMessage);
            client.GetStream().Write(chattingStartByte, 0, chattingStartByte.Length);//서버에 보내는 부분

        }      

        //왼쪽 버튼      룸도 이미 보여지기 때문에 이를 어떤 방식으로 옮겨야하는지 모르겠음.
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("채팅방을 선택해주세요.", "Information");
                return;
            }
            else
            {
                OneOnOneReceiverName = listBox1.SelectedItem.ToString();
                OneOnOneReceiverID = SearchIDwithNickName(OneOnOneReceiverName);
                Chatting_Start();
            }
        }
        private string SearchIDwithNickName(string UserNickName)
        {
            string conn = "Data Source = 115.85.181.212; Database=s5469698; Uid=s5469698; Pwd=s5469698; CharSet=utf8;";
            string query = "Select USER_id from USER where USER_nickname=\"" + UserNickName + "\"";

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                string UserID = "";
                while (rdr.Read())
                {
                    UserID = rdr[0].ToString();
                }
                return UserID;
            }
        }


        // delegate와 연동하여 프로필 수정 시 마다 데이터가 변경됨
        public void CheckEvent(string check)
        {
            LoginManager.Instance.LoadUserData(receivedData, main_profile, txt_nick, txt_department, txt_team);
        }

        // 종료 기능
        private void menu_AllClose_Click(object sender, EventArgs e)
        {
            LoginManager.Instance.Logout(receivedData);
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private string SearchNickNamewithID(string UserID)
        {
            string conn = "Data Source = 115.85.181.212; Database=s5469698; Uid=s5469698; Pwd=s5469698; CharSet=utf8;";
            string query = "Select USER_nickname from USER where USER_id=\"" + UserID + "\"";

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                string UserNickName = "";
                while (rdr.Read())
                {
                    UserNickName = rdr[0].ToString();
                }
                return UserNickName;
            }
        }

        private void 생일ToolStripMenuItem_Click(object sender, EventArgs e) {
			string ID = Get_ID(receivedData);
			Form_Birthday formBirthday = new Form_Birthday(ID);
			formBirthday.ShowDialog();
		}

        private void 테마변경ToolStripMenuItem_Click(object sender, EventArgs e) {
			string ID = Get_ID(receivedData);
			Form_BackColor formBackColor = new Form_BackColor(ID);
			formBackColor.ShowDialog();

			//변경된 테마 적용
			Load_User_Config(ID);
		}

        private void 뉴스검색ToolStripMenuItem_Click(object sender, EventArgs e) {
			string ID = Get_ID(receivedData);
			Form_News formNews = new Form_News(ID);
			formNews.ShowDialog();
		}


        private void SELECT_Font(string user)
        {
            string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
            string query = "SELECT Font, Font_Size FROM s5469698.USER_Config WHERE User_ID = " + user + ";";

            using (MySqlConnection connection = new MySqlConnection(Connection_string))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    Font = rdr[0].ToString();
                    Size = Convert.ToInt32(rdr[1].ToString());
                    Apply_Font();
                    return;
                }
                MessageBox.Show("설정된 폰트가 없습니다.");
            }
        }


        private void Apply_Font()
        {
            Font ft = new Font(Font, Size);
            listBox1.Font = ft;
            treeView1.Font = ft;
            group_profile.Font = ft;
            btn_main_logout.Font = ft;
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            string ID = Get_ID(receivedData);
            Form_Font formF = new Form_Font(ID);
            formF.ShowDialog();

            //변경된 테마 적용
            SELECT_Font(ID);
        }

        private void listBox_click(object sender, EventArgs e)
        {
            OneOnOneReceiverName = listBox1.SelectedItem.ToString();
            OneOnOneReceiverID = SearchIDwithNickName(OneOnOneReceiverName);
            Chatting_Start();
        }
    }
}