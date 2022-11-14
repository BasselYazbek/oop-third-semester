using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Serializable]
    public class CalculatePilots : Person
    {
        private string AirLinesName;

        public CalculatePilots() { }
        public CalculatePilots(string FirstName, string LastName, string Gender, string PlaceOfResidence, string AirLinesName)
            : base(FirstName, LastName, Gender, PlaceOfResidence)
        {
            this.AirLinesName = AirLinesName;
        }

        public string airLinesName { get; set; }


    }
}
