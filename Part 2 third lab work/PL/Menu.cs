using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BLL;

namespace PL
{
    public class Menu: IMenu
    {
        Students _exchangeService;
        IDataReadWriteService<int> _readWriteServiceInt;
        IDataReadWriteService<string> _readWriteServiceString;

        public void Start(Students exchangeService, 
                          IDataReadWriteService<int> readWriteServiceInt,
                          IDataReadWriteService<string> readWriteServiceString)
        {
            _exchangeService = exchangeService;
            //PrintCurrentRate();
            //decimal sum = ScanSumToConvert();
            //PrintConvertedSum(sum);

            _readWriteServiceInt = readWriteServiceInt;
            _readWriteServiceString = readWriteServiceString;
            PrintTypes();
        }
        
        public void PrintTypes()
        {
           
            int number = _readWriteServiceInt.ReadData();
            Console.WriteLine($"number = {number}");

            string str = _readWriteServiceString.ReadData();
            Console.WriteLine($"str = {str}");
        }

        
    }
}
