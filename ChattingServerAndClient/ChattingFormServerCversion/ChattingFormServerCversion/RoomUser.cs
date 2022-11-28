using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChattingFormServerCversion
{
    internal class RoomUser
    {
        public Socket socket;
        public string UserName;
        public int id;

        public RoomUser(Socket mainSock)
        {
        }

        public Socket MainSock { get; }
    }
}
