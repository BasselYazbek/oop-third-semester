using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Serializable]
    public class Pilot : Person, ISpecialBehavior
    {
        private string airLines;
        private string monthSalary;

        public string AirLines { get => airLines; set => airLines = value; }
        public string MonthSalary { get => monthSalary; set => monthSalary = value; }

        public string Ski()
        {
            return "The Pilot is Skying";
        }
    }
}
