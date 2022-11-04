using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using BLL.Services;

namespace PL
{
    public class Menu : IMenu
    {
        IHotelService _hotelService;
        IDataReadWriteService<int> _readWriteServiceInt;
        IDataReadWriteService<string> _readWriteServiceString;

        public void Start(IHotelService hotelService,
            IDataReadWriteService<int> readWriteServiceInt,
            IDataReadWriteService<string> readWriteServiceString)
        {
            _hotelService = hotelService;
            PrintCurrentInfo();

            _readWriteServiceInt = readWriteServiceInt;
            _readWriteServiceString = readWriteServiceString;

        }

        public void PrintCurrentInfo()
        {
            Console.WriteLine("The rooms available with information that can be reserved:/n Room number: {0}, Room kind: {1}, Price per day: {2}, Check in time: {3}, and the check out time is: {4} ", _hotelService.Info.roomNumber, _hotelService.Info.roomKind, _hotelService.Info.pricePerDay, _hotelService.Info.checkInTime, _hotelService.Info.checkOutTime);
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
