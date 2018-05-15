using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.model
{
    public class RoomView
    {
        public RoomView(Room r)
        {
            id = r.ID;
            roomName = r.RoomName;
            status = r.RoomStatu.StatusName;
            type = r.Price.ValueName;
        }
        public int id { get; set; }
        public string roomName { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        
        
    }
}
