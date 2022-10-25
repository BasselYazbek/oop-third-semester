using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.InputLogic
{
    public class Patterns
    {
        public static string NamePattern = @"^[A-Z][a-zA-Z]*$";
        public static string ClubPattern = @"^[A-Za-z ]+$";
        public static string IDPattern = @"[A-ZA-Z]\d{8}$";
        public static string Path = "C:\\2 курс\\1 семестр\\ООП\\LabWork3\\Serializing";
        public static string Read = "Choose the entity you want to read :\n" +
                                                           "1 - Students;\n" +
                                                           "2 - Pilot;\n" +
                                                           "3 - Musician";
    }
}
