using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.IO;
using BLL.Interfaces;

namespace BLL.Services
{
    public class HotelService : List<IHotelService>
    {
        private IDataContext<Hotel> _dataContext;

        public HotelService(/*string path*/ IDataContext<Hotel> dataContext)
        {
            //_dataContext = new DataContext<ExchangeRate>(path);
            _dataContext = dataContext;

        }

        public HotelInfo Info
        {
            get
            {
                try
                {
                    Hotel er = _dataContext.GetData();
                    return new HotelInfo() { roomNumber = er.roomNumber, roomKind = er.roomKind, pricePerDay = er.pricePerDay, checkInTime = er.checkInTime, checkOutTime = er.checkOutTime };
                }
                catch (Exception ex)
                {
                    throw new HotelException(ex.Message);
                }
            }
            set
            {
                try
                {
                    Hotel er = new Hotel() { roomNumber = value.roomNumber, roomKind = value.roomKind, pricePerDay = value.pricePerDay, checkInTime = value.checkInTime, checkOutTime = value.checkOutTime };
                    _dataContext.SetData(er);
                }
                catch (Exception ex)
                {
                    throw new HotelException(ex.Message);
                }
            }
        }
    }
}
