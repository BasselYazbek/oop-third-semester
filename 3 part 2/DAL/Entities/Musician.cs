using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Serializable]
    public class Musician :Person, ISpecialBehavior
    {
        private string musicKind;
        private int salaryPerEvent;

        public string MusicKind { get => musicKind; set => musicKind = value; }
        public int SalaryPerEvent { get => salaryPerEvent; set => salaryPerEvent = value; }

        public string Ski()
        {
            return "The Musician is Skying";
        }
    }
}
