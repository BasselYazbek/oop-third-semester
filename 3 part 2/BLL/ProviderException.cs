using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProviderException : Exception
    {
        public ProviderException() : base() { }
        public ProviderException(string msg) : base(msg) { }
    }
}
