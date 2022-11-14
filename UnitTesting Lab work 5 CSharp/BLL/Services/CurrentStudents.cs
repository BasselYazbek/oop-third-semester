using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.Services
{
    public class CurrentStudents : Persons
    {
        private int YearOfStudy;
        private int StudentID;
        private string CampusStudents;

        public CurrentStudents()
        {
        }

        public CurrentStudents(string LastName, string FirstName,
            int YearOfStudy, int StudentID, string Gender, string
            PlaceOfResidence, string CampusStudents) : base(FirstName, LastName, Gender, PlaceOfResidence)
        {
            this.YearOfStudy = YearOfStudy;
            this.StudentID = StudentID;
            this.CampusStudents = CampusStudents;
        }

        public int yearOfStudy { get; set; }
        public int studentID { get; set; }
        public string campusStudents { get; set; }

        public int CalculateMethod()
        {
            int sum = 0;
            if (yearOfStudy == 1 && gender == "Female" || gender == "female" && campusStudents != "No")
            {
                sum++;
            }
            return sum;
        }
    }
}
