using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace ChattingFormServerCversion
{
    class ClientManager
    {
        FormServer formServer1 = new FormServer("str");
        public static ConcurrentDictionary<int, ClientData> clientDic = new ConcurrentDictionary<int, ClientData>();
        public static event Action<string, string>? messageParsingAction = null;
        public static event Action<string, int>? ChatngeListBoxAction = null;
        DBManager dbmanager = DBManager.GetInstance();

        public void AddClient(TcpClient newClient)
        {
            ClientData currentClient = new(newClient);

            try
            {//받아온 아이디 검색해서 db에 이름 혹은 닉네임 검색하면 된다
                newClient.GetStream().BeginRead(currentClient.readBuffer, 0, currentClient.readBuffer.Length, new AsyncCallback(DataReceived), currentClient);
                clientDic.TryAdd(currentClient.clientNumber, currentClient);//유저 식별 번호와, 그외 유저 정보들 ADD
            }

            catch (Exception e)
            {
                //RemoveClient(currentClient);
            }
        }



        private void DataReceived(IAsyncResult ar)
        {
            ClientData? client = ar.AsyncState as ClientData;

            try
            {
                int byteLength = client.tcpClient.GetStream().EndRead(ar);

                string strData = UTF8Encoding.UTF8.GetString(client.readBuffer, 0, byteLength);

                client.tcpClient.GetStream().BeginRead(client.readBuffer, 0, client.readBuffer.Length, new AsyncCallback(DataReceived), client);

                if (string.IsNullOrEmpty(client.clientID))
                {
                    if (ChatngeListBoxAction != null)
                    {
                        if (CheckID(strData))
                        {
                            string userID = strData.Substring(3);//로그인때 사용한 ID
                            client.clientID = userID;//ID를 통해 본인의 이름(), 닉네임 저장해두자.
                            ChatngeListBoxAction.Invoke(client.clientID, StaticDefine.ADD_USER_LIST);
                            string accessLog = string.Format("[{0}] {1} Access Server", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), client.clientID);
                            ChatngeListBoxAction.Invoke(accessLog, StaticDefine.ADD_ACCESS_LIST);
                            File.AppendAllText("AccessRecored.txt", accessLog + "\n");
                            return;
                        }
                    }
                }


                if (messageParsingAction != null)
                {
                    Task task = Task.Run(() => formServer1.MessageParsing(client.clientID, strData));

                }

            }
            catch (Exception e)
            {
                //RemoveClient(client);
            }
        }


        private bool CheckID(string ID)
        {
            if (ID.Contains("%^&"))
                return true;

            File.AppendAllText("IDErrLog.txt", ID);
            return false;
        }
    }
}
