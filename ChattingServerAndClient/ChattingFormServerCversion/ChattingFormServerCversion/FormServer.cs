using System.Collections.ObjectModel;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;


namespace ChattingFormServerCversion
{
    public partial class FormServer : Form
    {
        private object lockObj = new object();
        public static List<string>? chattingLogList = new List<string>();
        public static List<string>? userList = new List<string>();
        public static List<string>? AccessLogList = new List<string>();
        Task? conntectCheckThread = null;//연결을 체크하는 스레드
        public FormServer()
        {
            
            InitializeComponent();
            string debugCheck = "디버깅용 테스트서버를 사용하시려면 예, 실제 채팅프로그램 사용하려면 아니오를 눌러주세요";
            DialogResult nameMessageBoxResult = MessageBox.Show(debugCheck, "Question", MessageBoxButtons.YesNo);
            if (nameMessageBoxResult == DialogResult.Yes)
            {
                ClientData.isdebug = true;
            }
            else
            {
                ClientData.isdebug = false;
            }
            MainServerStart();//다른 스렐드에서 메인 서버가 클라이언트 msg를 listen
            ClientManager.messageParsingAction += MessageParsing;//이벤트 추가
            ClientManager.ChatngeListBoxAction += ChangeListBox;


            listBoxChattingLog.DataSource = chattingLogList;//리스트를 리스트 박스에 바인딩
            listBoxAccessLog.DataSource = AccessLogList;
            listBoxUser.DataSource = userList;



            conntectCheckThread = new Task(ConnectCheckLoop);//연결 체크 스레드 
            conntectCheckThread.Start(); //실행


        }
        public FormServer(string str)
        {

        }
        private void FormServer_Load(object sender, EventArgs e)
        {
            
        }
        private void ListBoxRefresh()
        {
            listBoxChattingLog.DataSource = null;//리스트를 리스트 박스에 바인딩
            listBoxAccessLog.DataSource = null;
            listBoxUser.DataSource = null;

            listBoxChattingLog.DataSource = chattingLogList;//리스트를 리스트 박스에 바인딩
            listBoxAccessLog.DataSource = AccessLogList;
            listBoxUser.DataSource = userList;
        }
        private void ListBoxRefresh(ListBox listbox, List<string> list, string DisplayName, string ValueName)
        {
            listbox.DataSource = null;
            listbox.DataSource = list;
            listbox.DisplayMember = DisplayName;
            listbox.ValueMember = ValueName;
        }
    
    private void buttonStart_Click(object sender, EventArgs e)
        {        
            
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
        }

        private void ConnectCheckLoop()
        {
            while (true)
            {
                foreach (var item in ClientManager.clientDic)
                {
                    try
                    {
                        string sendStringData = "관리자<TEST>";
                        byte[] sendByteData = new byte[sendStringData.Length];
                        sendByteData = Encoding.Default.GetBytes(sendStringData);

                        item.Value.tcpClient.GetStream().Write(sendByteData, 0, sendByteData.Length);
                    }
                    catch (Exception e)
                    {
                        RemoveClient(item.Value);
                    }
                }
                Thread.Sleep(1000);
            }
        }

        private void RemoveClient(ClientData targetClient)
        {
            ClientData? result = null;
            ClientManager.clientDic.TryRemove(targetClient.clientNumber, out result);
            string leaveLog = string.Format("[{0}] {1} Leave Server", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), result.clientName);
            ChangeListBox(leaveLog, StaticDefine.ADD_ACCESS_LIST);
            ChangeListBox(result.clientName, StaticDefine.REMOVE_USER_LIST);
        }

        private void ChangeListBox(string Message, int key)
        {
            ChangeListBox(Message, key, chattingLogList);
        }

        private void ChangeListBox(string Message, int key, List<string>? chattingLogList)
        {
            switch (key)
            {
                case StaticDefine.ADD_ACCESS_LIST:
                    {//스레드에 대한 작업 항목 큐를 관리한다.

                        if (this.listBoxAccessLog.InvokeRequired)
                        {
                            this.listBoxAccessLog.Invoke(new MethodInvoker(delegate { AccessLogList.Add(Message); ListBoxRefresh();;
                            }));
                        }
                        break;
                    }
                case StaticDefine.ADD_CHATTING_LIST:
                    {
                        if (this.listBoxChattingLog.InvokeRequired)
                        {
                            this.listBoxChattingLog.Invoke(new MethodInvoker(delegate {
                                chattingLogList.Add(Message); ListBoxRefresh(); ;
                            }));
                        }
                        break;
                    }
                case StaticDefine.ADD_USER_LIST:
                    {
                        if (this.listBoxUser.InvokeRequired)
                        {
                            this.listBoxUser.Invoke(new MethodInvoker(delegate {
                                userList.Add(Message); ListBoxRefresh(); ;
                            }));
                        }
                        break;
                    }
                case StaticDefine.REMOVE_USER_LIST:
                    {
                        if (this.listBoxUser.InvokeRequired)
                        {
                            this.listBoxUser.Invoke(new MethodInvoker(delegate {
                                userList.Remove(Message); ListBoxRefresh(); ;
                            }));
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        public void MessageParsing(string sender, string message)
        {
            lock (lockObj)
            {
                List<string> msgList = new List<string>();

                string[] msgArray = message.Split('>');
                foreach (var item in msgArray)
                {
                    if (string.IsNullOrEmpty(item))
                        continue;
                    msgList.Add(item);
                }
                SendMsgToClient(msgList, sender);
            }
        }

        private void SendMsgToClient(List<string> msgList, string sender)
        {
            string parsedMessage = "";
            string receiver = "";

            
            int senderNumber = -1;
            int receiverNumber = -1;

            foreach (var item in msgList)
            {
                string[] splitedMsg = item.Split('<');

                receiver = splitedMsg[0];
                parsedMessage = string.Format("{0}<{1}>", sender, splitedMsg[1]);

                if (parsedMessage.Contains("<GroupChattingStart>"))
                {
                    string[] groupSplit = receiver.Split('#');

                    foreach (var el in groupSplit)
                    {
                        if (string.IsNullOrEmpty(el))
                            continue;
                        string groupLogMessage = string.Format(@"[{0}] [{1}] -> [{2}] , {3}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), groupSplit[0], el, splitedMsg[1]);
                        ChangeListBox(groupLogMessage, StaticDefine.ADD_CHATTING_LIST);

                        receiverNumber = GetClinetNumber(el);

                        parsedMessage = string.Format("{0}<GroupChattingStart>", receiver);
                        byte[] sendGroupByteData = Encoding.Default.GetBytes(parsedMessage);
                        ClientManager.clientDic[receiverNumber].tcpClient.GetStream().Write(sendGroupByteData, 0, sendGroupByteData.Length);
                    }
                    return;
                }

                if (receiver.Contains('#'))
                {
                    string[] groupSplit = receiver.Split('#');

                    foreach (var el in groupSplit)
                    {
                        if (string.IsNullOrEmpty(el))
                            continue;
                        if (el == groupSplit[0])
                            continue;
                        string groupLogMessage = string.Format(@"[{0}] [{1}] -> [{2}] , {3}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), groupSplit[0], el, splitedMsg[1]);
                        ChangeListBox(groupLogMessage, StaticDefine.ADD_CHATTING_LIST);

                        receiverNumber = GetClinetNumber(el);

                        parsedMessage = string.Format("{0}<{1}>", receiver, splitedMsg[1]);
                        byte[] sendGroupByteData = Encoding.Default.GetBytes(parsedMessage);
                        ClientManager.clientDic[receiverNumber].tcpClient.GetStream().Write(sendGroupByteData, 0, sendGroupByteData.Length);
                    }
                    return;
                }


                senderNumber = GetClinetNumber(sender);
                receiverNumber = GetClinetNumber(receiver);


                if (senderNumber == -1 || receiverNumber == -1)
                {
                    //File.AppendAllText("ClientNumberErrorLog.txt", sender + receiver);
                    return;
                }

                byte[] sendByteData = new byte[parsedMessage.Length];
                sendByteData = Encoding.Default.GetBytes(parsedMessage);

                if (parsedMessage.Contains("<GiveMeUserList>"))
                {
                    string userListStringData = "관리자<";
                    foreach (var el in userList)
                    {
                        userListStringData += string.Format("${0}", el);
                    }
                    userListStringData += ">";
                    byte[] userListByteData = new byte[userListStringData.Length];
                    userListByteData = Encoding.Default.GetBytes(userListStringData);
                    ClientManager.clientDic[receiverNumber].tcpClient.GetStream().Write(userListByteData, 0, userListByteData.Length);
                    return;
                }




                string logMessage = string.Format(@"[{0}] [{1}] -> [{2}] , {3}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), sender, receiver, splitedMsg[1]);
                //ChangeListBox(logMessage, StaticDefine.ADD_CHATTING_LIST);

                if (parsedMessage.Contains("<ChattingStart>"))
                {
                    parsedMessage = string.Format("{0}<ChattingStart>", receiver);
                    sendByteData = Encoding.Default.GetBytes(parsedMessage);
                    ClientManager.clientDic[senderNumber].tcpClient.GetStream().Write(sendByteData, 0, sendByteData.Length);

                    parsedMessage = string.Format("{0}<ChattingStart>", sender);
                    sendByteData = Encoding.Default.GetBytes(parsedMessage);
                    ClientManager.clientDic[receiverNumber].tcpClient.GetStream().Write(sendByteData, 0, sendByteData.Length);

                    return;
                }



                if (parsedMessage.Contains(""))

                    ClientManager.clientDic[receiverNumber].tcpClient.GetStream().Write(sendByteData, 0, sendByteData.Length);
            }
        }

        private int GetClinetNumber(string targetClientName)
        {
            foreach (var item in ClientManager.clientDic)
            {
                if (item.Value.clientName == targetClientName)
                {
                    return item.Value.clientNumber;
                }
            }
            return -1;
        }

        private void MainServerStart()
        {
            MainServer a = new MainServer();
        }
    }
}