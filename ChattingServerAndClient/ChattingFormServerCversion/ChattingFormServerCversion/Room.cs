using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ChattingFormServerCversion
{
    internal class Room
    {
        
        private int id;
        private List<RoomUser> userList; 

        public Room(List<RoomUser> users)//단체톡방은 유저리스트가 방을 만듦
        {
            this.userList = users;//상대와 나의 소켓, id, 이름 필요
        }
        public void SetID(int id)
        {
            this.id = id;
        }
        public int GetID()
        {
            return id;
        }
    }
    

}
