using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_1_third_semester_in_Csharp
{
    class Students : ToSkate
    {

        private string LastName;
        private string FirstName;
        private int YearOfStudy;
        private int StudentID;
        private string Gender;
        private string DormStudents;

        // Private elements coordinates
        public Students(string LastName, string FirstName, int YearOfStudy, 
            int StudentID, string Gender, string DormStudents)
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.YearOfStudy = YearOfStudy;
            this.StudentID = StudentID;
            this.Gender = Gender;
            this.DormStudents = DormStudents;
        }

        // Students who are in the first year and living in the Dorm
        public int StudentsInDorm(Students a)
        {
            int sum = 0;
            if(a.YearOfStudy ==1 && a.DormStudents != "No")
            {
                sum++;
            }
            return sum;
        }

        // Amount of students who can Skate using the abstract method
        override public int Skate()
        {
            int sum = 0;
            if(YearOfStudy >=1 && DormStudents != "No")
            {
                sum++;
            }
            return sum;
        }

        public override string ToString()
        {
            return String.Format("Last Name: {0}, First Name: {1}, year of Study: {2}, " +
                "Student-ID: {3}, Gender: {4}, " + "Living in a Dorm: {5}", 
                LastName, FirstName, YearOfStudy, StudentID, Gender, DormStudents);
        }
    }
}
