using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    public class Context
    {
        public static List<Student> Students { get; set; }
        public static List<Musician> Musicians { get; set; }
        public static List<Pilot> Pilots { get; set; }
    }
}
