using System;

namespace BLL
{
    public class CurrentStudent
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
            get;set;
        }

        public string ResidenceLocation
        {
            get;set;
        }

        public string DormStudent
        {
            get;set;
        }

        
        public CurrentStudent(string fname, string lname, int year, string ID, string Residence, string Dorm, string gen)
        {
            FirstName = fname;
            LastName = lname;
            Year = year;
            gender = gen;
            IDCard = ID;
            residenceLocation = Residence;
            dormStudent = Dorm;
        }
        
        public CurrentStudent()
        {
        }
        
        
        public int CountEquation()
        {
            int sum = 0;
            if(year == 1 && gender == "Female" && dormStudent == "Yes")
            {
                sum++;
            }
            return sum++;

        }
        
        public override string ToString()
        {
            return String.Format("Full Name is: {0} {1}, {0} year od study is: {2}, " +
                "The Gender is: {3}, IDCard number is: {4}, Residence Location: {5}, Living in a dorm? {6}", FirstName, LastName, Year, gender, iDCard, residenceLocation, dormStudent);
        }
        
    }
}
