using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BLL;

namespace PL
{
    public interface IMenu
    {
        void Start(Students exchangeService,
                   IDataReadWriteService<int> readWriteServiceInt,
                   IDataReadWriteService<string> readWriteServiceString);
        //void PrintCurrentRate();
        //void PrintConvertedSum(decimal sum);
        void PrintTypes();
        //decimal ScanSumToConvert();

        
    }
}
