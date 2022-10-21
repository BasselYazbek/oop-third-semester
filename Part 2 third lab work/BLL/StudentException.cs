using System;

namespace BLL
{
    public class StudentException: Exception
    {
        public StudentException() : base() { }
        public StudentException(string msg) : base(msg) { }
    }
}
