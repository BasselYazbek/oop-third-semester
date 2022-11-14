using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CurrentPilots : Persons
    {
        private string AirLinesName;

        public CurrentPilots() { }
        public CurrentPilots(string FirstName, string LastName, string Gender, string PlaceOfResidence, string AirLinesName)
            : base(FirstName, LastName, Gender, PlaceOfResidence)
        {
            this.AirLinesName = AirLinesName;
        }

        public string airLinesName { get; set; }
    }
}
