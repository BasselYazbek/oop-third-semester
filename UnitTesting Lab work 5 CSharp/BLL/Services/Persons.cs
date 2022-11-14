using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class Persons
    {
        private string FirstName;
        private string LastName;
        private string Gender;
        private string PlaceOfResidence;

        public Persons() { }
        public Persons(string FirstName, string LastName, string Gender,
            string PlaceOfResidence)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.PlaceOfResidence = PlaceOfResidence;
        }


        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string placeOfResidence { get; set; }
    }
}
