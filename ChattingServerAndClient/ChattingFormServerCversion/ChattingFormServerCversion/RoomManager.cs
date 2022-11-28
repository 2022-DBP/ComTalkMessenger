using System.Collections.Generic;

namespace ChattingFormServerCversion
{
    internal class RoomManager
    {
        private static List<Room> roomList = new List<Room>();//방의 리스트

        public static Room createRoom(List<RoomUser> users)
        {
            Room room = new Room(users);
            roomList.Add(room);
            return room;
        }
    }
}
