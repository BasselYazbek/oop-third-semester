using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudentException : Exception
    {
        public StudentException() : base() { }
        public StudentException(string msg) : base(msg) { }
    }
}
