using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Services;

namespace BLL.Interfaces
{
    public interface ICalculateStudents
    {
        CurrentStudents Students { get; set; }

        int CalculateMethod();
    }
}
