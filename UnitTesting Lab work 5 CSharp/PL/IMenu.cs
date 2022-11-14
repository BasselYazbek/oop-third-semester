using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using BLL.Services;

namespace PL
{
    public interface IMenu
    {
        void Start(ICalculateStudents calculateStudents,
            ICalculateMusicians calculateMusicians,
            ICalculatePilots calculatePilots,
            IDataReadWriteService<int> readWriteServiceInt,
            IDataReadWriteService<string> readWriteServiceString);

        void PrintCurrentStudents();
        void PrintCurrentMusicians();
        void PrintCurrentPilots();

        void PrintCalculatedStudents();
        void PrintLearnNewMusic();

        void PrintTypes();
    }
}
