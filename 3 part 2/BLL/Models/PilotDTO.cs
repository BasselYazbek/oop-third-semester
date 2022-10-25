using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class PilotDTO : ModelDTO
    {
        public string AirLines { get; set; }
        public string MonthSalary { get; set; }

        public override string ToString()
        {
            return String.Format("Pilot: {0} {1}/n First name: {0}/n Last name: {1}/n, Gender: {2}/n Airlines company name: {3}/n Salary per month: {4}", FirstName, LastName, Gender, AirLines, MonthSalary);
        }
    }
}
