using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CurrentMusician
    {
        private string firstName;
        private string lastName;
        private int year;
        private string kindOfMusic;
        private string residenceLocation;
        private string dormStudent;
        private string gender;

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }
        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public int Year
        {
            get => year;
            set => year = value;
        }


        public string Gender
        {
            get; set;
        }

        public string KindOfMusic
        {
            get; set;
        }

        public string ResidenceLocation
        {
            get; set;
        }

        public string DormStudent
        {
            get; set;
        }


        public CurrentMusician(string fname, string lname, int year, string Music, string Residence, string Dorm, string gen)
        {
            FirstName = fname;
            LastName = lname;
            Year = year;
            gender = gen;
            kindOfMusic = Music;
            residenceLocation = Residence;
            dormStudent = Dorm;
        }

        public CurrentMusician()
        {
        }


        public int CountEquation()
        {
            int sum = 0;
            if (year == 1 && gender == "Female" && dormStudent == "Yes")
            {
                sum++;
            }
            return sum++;

        }

        public override string ToString()
        {
            return String.Format("Full Name is: {0} {1}, {0} year od study is: {2}, " +
                "The Gender is: {3}, The kind of music is: {4}, Residence Location: {5}, Living in a dorm? {6}", FirstName, LastName, Year, gender, KindOfMusic, residenceLocation, dormStudent);
        }

    }
}

