using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HotelException : Exception
    {
        public HotelException(): base() { }
        public HotelException(string msg) : base(msg) { }
    }
}
