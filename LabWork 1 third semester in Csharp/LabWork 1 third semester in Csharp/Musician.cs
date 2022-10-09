using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_1_third_semester_in_Csharp
{
    class Musician : ToSkate
    {
        private string lastName;
        private string firstName;
        private string gender;
        private string placeOfResidence;
        private string kindOfMusic;
        private int age;

        public Musician(string lastName, string firstName, String gender, 
            string placeOfResidence, string kindOfMusic, int age)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.gender = gender;
            this.placeOfResidence = placeOfResidence;
            this.kindOfMusic = kindOfMusic;
            this.age = age;
        }

        // Amount of Musician who can Skate using the abstract method
        override public int Skate()
        {
            int sum = 0;
            if (age<=50)
            {
                sum++;
            }
            return sum;
        }

        public override string ToString()
        {
            return String.Format("Last Name: {0}, First name {1}, gender: {2}, " +
                "place of residence: {3}, kind of music: {4}", lastName, firstName, gender,
                placeOfResidence, kindOfMusic);
        }
    }
}
