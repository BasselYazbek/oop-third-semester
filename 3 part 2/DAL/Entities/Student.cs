using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Serializable]
    public class Student : Person, ISpecialBehavior
    {
        private int yearOfStudy;
        private string studentID;
        private string placeOfResidence;
        private string dormStudents;

        public int YearOfStudy { get => yearOfStudy; set => yearOfStudy = value; }
        public string StudentID { get => studentID; set => studentID = value; }
        public string PlaceOfResidence { get => placeOfResidence; set => placeOfResidence = value; }
        public string DormStudents { get => dormStudents; set => dormStudents = value; }

        public string Ski()
        {
            return "The student is Skying";
        }
    }
}
