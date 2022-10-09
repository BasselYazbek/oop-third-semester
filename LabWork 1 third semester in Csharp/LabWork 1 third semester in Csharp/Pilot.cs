using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_1_third_semester_in_Csharp
{
    class Pilot : ToSkate
    {
        private string lastName;

        private string firstName;
        private string gender;
        private string companyName;
        private string airplaneName;
        private int age;

        public Pilot(string lastName, string firstName, string gender,
            string companyName, string airplaneName, int age)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.gender = gender;
            this.companyName = companyName;
            this.airplaneName = airplaneName;
            this.age = age;
        }

        // Amount of Pilots who can Skate using the abstract method
        override public int Skate()
        {
            int sum = 0;
            if (age <=40)
            {
                sum++;
            }
            return sum;
        }

        public override string ToString()
        {
            return String.Format("The Pilot first name is: {0}, " +
                "last name is: {1}, gender: {2}, company name: {3}, airplane name: {4}",
                firstName, lastName, gender, companyName, airplaneName);
        }
    }
}
