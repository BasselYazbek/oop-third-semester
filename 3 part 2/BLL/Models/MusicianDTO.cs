using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class MusicianDTO : ModelDTO
    {
        public string MusicKind { get; set; }
        public int SalaryPerEvent { get; set; }

        public override string ToString()
        {
            return String.Format("Musician: {0} {1}/n First name: {0}/n Last name: {1}/n Gender: {2}/n Music kind: {3}/n Salary per event: {4}", FirstName, LastName, Gender, MusicKind, SalaryPerEvent);
        }


    }
}