using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Serializable]
    public class Hotel
    {
        public Int16 roomNumber { get; set; }
        public String roomKind { get; set; }
        public Int16 pricePerDay { get; set; }
        public String checkInTime { get; set; }
        public String checkOutTime { get; set; }
    }
}
