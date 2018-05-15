using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.model
{
   public class PriceView
    {
        public PriceView(Price p)
        {
            ID = p.ID;
            ValueName = p.ValueName;
            Value = p.Value;
        }
        public int ID { get; set; }
        public string ValueName { get; set; }
        public int? Value { get; set; }
        

    }
}
