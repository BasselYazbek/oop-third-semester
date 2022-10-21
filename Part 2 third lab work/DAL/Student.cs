using System;
using System.Text.RegularExpressions;

namespace DAL
{
    [Serializable]
    public class Student
    {
        
        private string firstName;
        private string lastName;
        private int year;
        private string iDCard;
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

        public string IDCard
        {
            get => iDCard;
            set => iDCard = value;
        }

        public string Gender
        {
            get => gender;
            set => gender = value;
        }

        public string ResidenceLocation
        {
            get => residenceLocation;
            set => residenceLocation = value;
        }

        public string DormStudent
        {
            get => dormStudent;
            set => dormStudent = value;
        }
        
        public Student(string fname, string lname, int year, string ID, string Residence, string Dorm, string gen)
        {
            firstName = fname;
            lastName = lname;
            this.year = year;
            gender = gen;
            iDCard = ID;
            residenceLocation = Residence;
            dormStudent = Dorm;
        }
        
        public Student()
        {
        }
        
        public override string ToString()
        {
            return String.Format("Full Name is: {0} {1}, {0} year od study is: {2}, " +
                "The Gender is: {3}, IDCard number is: {4}, Residence Location: {5}, Living in a dorm? {6}", FirstName, LastName, Year, Gender, IDCard, ResidenceLocation, DormStudent);
        }

    }
}
