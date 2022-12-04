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

        public static string myID = null;
        TcpClient client = null;
        Thread ReceiveThread = null;
        Form_ChattingRoom chattingWindow = null;
        Dictionary<string, ChattingThreadData> chattingThreadDic = new Dictionary<string, ChattingThreadData>();

        private static ObservableCollection<User> currentUserList = new ObservableCollection<User>();
        private static ObservableCollection<string> currentRoomList = new ObservableCollection<string>();
        public string RoomMemeber;

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

                        /*
                        //유저 리스트에 받아온 유저 리스트 추가 아마 필요없는 것 같음 
                        if (this.listBoxMember.InvokeRequired)
                        {
                            this.listBoxMember.Invoke(new MethodInvoker(delegate
                            {
                                foreach (var item1 in tempUserList)
                                {
                                    currentUserList.Add(item1); RefreshListBoxMember();

                                }
                            }));
                        }
                        */
                        messageList.Clear();
                        return;
                    }
                    if (chattingPartner == "채팅방")
                    {
                        ObservableCollection<string> tempRoomList = new ObservableCollection<string>();
                        string[] splitedRoom = message.Split('$');
                        foreach (var el in splitedRoom)
                        {
                            if (string.IsNullOrEmpty(el))
                                continue;
                            tempRoomList.Add(el);//새로운 유저 들어오면 Add
                        }
                        currentRoomList.Clear();

                        /*
                        //아마 이부분도 이미 보이기 때문에 필요 없을 것 같음.
                        if (this.listBoxMember.InvokeRequired)
                        {
                            this.listBoxRoom.Invoke(new MethodInvoker(delegate
                            {
                                foreach (var item1 in tempRoomList)
                                {
                                    currentRoomList.Add(item1); RefreshListBoxRoom();

                                }
                            }));
                        }
                        messageList.Clear();
                        */
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
        /*
        //아마 필요없을 것 같음 현재 리스트가 뜨기 때문
        private void RefreshListBoxMember()
        {
            listBoxMember.DataSource = null;
            listBoxMember.DataSource = currentUserList;
            listBoxMember.DisplayMember = "userName";
        }
        */
        private void RefreshListBoxRoom()
        {
            listBoxRoom.DataSource = null;
            listBoxRoom.DataSource = currentRoomList;
        }
        private void ThreadStartingPoint(string chattingPartner, string RoomID)
        {
            chattingWindow = new Form_ChattingRoom(client, chattingPartner, RoomID);
            chattingThreadDic.Add(chattingPartner, new ChattingThreadData(Thread.CurrentThread, chattingWindow));

            chattingWindow.ShowDialog();
            MessageBox.Show("채팅이 종료되었습니다.");
            chattingThreadDic.Remove(chattingPartner);

        }


   

        public string receivedData;
        public Form_main(string Data)
        {
            InitializeComponent();
            receivedData = Data;
            textBoxMyID.Text = "1";//로그인할때 정보를 받아올 것
            //로그인할 때 쓰는 User_id 말고 int형인 ID여야 합니다.->추후 clientNumber로 사용
            textBoxIPAdress.Text = "127.0.0.1";
            listBoxRoom.DataSource = currentRoomList;

            Login();
        }
        private void Login()
        {
            try
            {
                string ip = textBoxIPAdress.Text;
                string parsedID = "%^&";
                parsedID += textBoxMyID.Text;
                client = new TcpClient();
                client.Connect(ip, 9999);//직접 설정한 ip로 연결

                byte[] byteData = new byte[parsedID.Length];
                byteData = UTF8Encoding.UTF8.GetBytes(parsedID);//Name추가해서 보내기
                client.GetStream().Write(byteData, 0, byteData.Length);

                Info.Text = string.Format("{0} 님 반갑습니다 ", textBoxMyID.Text);
                myID = textBoxMyID.Text;

                ReceiveThread = new Thread(RecieveMessage);
                ReceiveThread.Start();
            }

            catch
            {
                MessageBox.Show("서버연결에 실패하였습니다.");
                client = null;
            }
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

        //대화방 불러오기 기능 이것도 유저가  A라고 가정후 실시 
        public void view_list()
        {
            listBox1.Items.Clear();
            string conn = "Data Source = 115.85.181.212; Database=s5469698; Uid=s5469698; Pwd=s5469698; CharSet=utf8;";
            string query = "SELECT distinct USER1, USER2 From Room WHERE idRoom IN (SELECT idRoom FROM Room WHERE USER1 = 'A' OR USER2 = 'A' GROUP BY idRoom);";

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
                    listBox1.Items.Remove("A");
                }
            }

        }

        //대화 연결 - 유저는 ID 와 NAME 모두이지만 여기서는 상대 ID만 보여서 오류가 발생함..
        private void listBoxChattingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<User> dummyChattingUser = listBox1.Items.Cast<User>().ToList();

            User selectedUser = (User)listBox1.SelectedItem;
            if (Form_main.myID == selectedUser.userName)
            {
                MessageBox.Show("자기 자신과는 채팅할 수 없습니다.");
                return;
            }

            this.OneOnOneReceiverID = selectedUser.userID;        //받는 사람 결정
            this.OneOnOneReceiverName = selectedUser.userName;
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

                
                    //만약 값이 널이라면 룸 생성
                    if (rdr.HasRows)
                    {
                    MessageBox.Show("이미 대화방이 존재합니다.");
           
                    }
                    else
                    {
                    string query2 = "INSERT INTO Room (USER1,USER2) values('A', '" + e.Node.Text + "');";
                    MySqlConnection connect = new MySqlConnection(conn);
                    connect.Open();
                    MySqlCommand cmd2 = new MySqlCommand(query2, connect);
                    MySqlDataReader rdr2 = cmd2.ExecuteReader();
                    connect.Close();
                    view_list();
                }
                
            }


        }


        //로그아웃 기능
        private void btn_main_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("로그아웃 되었습니다.");
            Owner.Show();
            this.Close();
        }

        private void label_profile_click(object sender, EventArgs e)
        {
            LoginManager.Instance.SetImage(openFileDialog1, main_profile, receivedData);
        }

        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();

        }

        //오른쪽 버튼
        private void buttonChattingStart_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("채팅상대를 선택해주세요.", "Information");
                return;
            }

            List<User> dummyChattingUser = listBox1.SelectedItems.Cast<User>().ToList();

            User selectedUser = (User)listBox1.SelectedItem;

            if (myID == selectedUser.userID)//내 아이디와 선택한 유저의 아이디 비교
            {
                MessageBox.Show("자기 자신과는 채팅할 수 없습니다.");
                return;
            }
            //이부분 자체가 현 프로그램에서 작동이 불가능해서 변경
            MessageBox.Show("{0}님과 채팅을 시작합니다", selectedUser.userName);
            
            this.OneOnOneReceiverID = selectedUser.userID;//채팅 상대 결정됨 userName->userID로 바꿈
            this.OneOnOneReceiverName = selectedUser.userName;
            Chatting_Start();
        }
        private void Chatting_Start()
        {

            string chattingStartMessage = string.Format("{0}%{1}<ChattingStart>", OneOnOneReceiverID, OneOnOneReceiverName);//UserID, UserName으로 ChattingStart작성
            byte[] chattingStartByte = UTF8Encoding.UTF8.GetBytes(chattingStartMessage);
            client.GetStream().Write(chattingStartByte, 0, chattingStartByte.Length);//서버에 보내는 부분

        }

        //왼쪽 버튼      룸도 이미 보여지기 때문에 이를 어떤 방식으로 옮겨야하는지 모르겠음.
        private void button1_Click(object sender, EventArgs e)
        {
            RoomMemeber = listBoxRoom.SelectedItem.ToString();

            string chattingStartMessage = string.Format("{0}<ChattingRoomStart>", RoomMemeber);//UserID, UserName으로 ChattingStart작성
            byte[] chattingStartByte = UTF8Encoding.UTF8.GetBytes(chattingStartMessage);
            client.GetStream().Write(chattingStartByte, 0, chattingStartByte.Length);//서버에 보내는 부분
        }
    }
}
