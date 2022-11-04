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
        void Start(IHotelService hotelService,
            IDataReadWriteService<int> readWriteServiceInt,
            IDataReadWriteService<string> readWriteServiceString);

        void PrintCurrentInfo();
        void PrintTypes();
    }
}
