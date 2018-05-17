using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.model
{
    public class SessionView
    {
        public SessionView(Session s)
        {
            id = s.ID;
            tenantname = s.TenantName;
            tenantid = s.TenantId;
            datestart = s.DateStart.ToString();
            dateend = s.DateEnd.ToString();
            duration = s.Duration;
            total = s.Total;
            roomname = s.Room.RoomName;

        }
        public int id { get; set; }
        public string tenantname { get; set; }
        public string tenantid { get; set; }
        public string roomname { get; set; }
        public string datestart { get; set; }
        public string dateend { get; set; }
        public int? duration { get; set; }
        public int? total { get; set; }
    }
}
