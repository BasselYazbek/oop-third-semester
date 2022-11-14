using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MusicianException : Exception
    {
        public MusicianException() : base() { }
        public MusicianException(string msg) : base(msg) { }
    }
}