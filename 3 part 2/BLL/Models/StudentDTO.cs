using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class StudentDTO : ModelDTO
    {
        public int YearOfStudy { get; set; }
        public string StudentID { get; set; }
        public string PlaceOfResidence { get; set; }
        public string DormStudents { get; set; }

        public override string ToString()
        {
            return String.Format("Student {0} {1}/n First name: {0}/n Last Name: {1}/n Gender: {2}/n Year of study: {3}/n StudentID: {4}/n Place of recidense: {5}/n Dorm Student: {6}", FirstName, LastName, Gender, YearOfStudy, StudentID, PlaceOfResidence, DormStudents);
        }
    }
}
