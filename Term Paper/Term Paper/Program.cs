using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using BLL.Services;
using DAL;
using DataProviderContract;
using PL;
using XMLProvider;
using System.Configuration;

namespace Term_Paper
{
    class Program
    {
        static IHotelService hotelService;
        static IDataReadWriteService<int> readWriteServiceInt;
        static IDataReadWriteService<string> readWriteServiceString;

        static IMenu menu;

        static void Main(string[] args)
        {
            string config;

            config = FileConfiguration("this is my task paper");
            //InitializeSettings();
            List<HotelInfo> hotelInfos = new List<HotelInfo>();
            hotelInfos.Add(new HotelInfo { roomNumber = 53, roomKind = "Suite", pricePerDay = 135, checkInTime = "10:00", checkOutTime = "20:00" });
            hotelInfos.Add(new HotelInfo { roomNumber = 23, roomKind = "Suite", pricePerDay = 115, checkInTime = "10:00", checkOutTime = "20:00" });
            hotelInfos.Add(new HotelInfo { roomNumber = 67, roomKind = "Suite", pricePerDay = 155, checkInTime = "10:00", checkOutTime = "20:00" });
            hotelInfos.Add(new HotelInfo { roomNumber = 12, roomKind = "Studio", pricePerDay = 75, checkInTime = "10:00", checkOutTime = "20:00" });
            hotelInfos.Add(new HotelInfo { roomNumber = 34, roomKind = "Studio", pricePerDay = 85, checkInTime = "10:00", checkOutTime = "20:00" });
            hotelInfos.Add(new HotelInfo { roomNumber = 75, roomKind = "Family Suite", pricePerDay = 200, checkInTime = "10:00", checkOutTime = "20:00" });

            foreach (var item in hotelInfos)
            {
                Console.WriteLine(item);
            }
            

            config = FileConfiguration("Int file");
            readWriteServiceInt = ConfigReadWriteServices<int>(config);

            config = FileConfiguration("String file");
            readWriteServiceString = ConfigReadWriteServices<string>(config);

            InitialReadWriteSetting();

            RunApp();

            Console.ReadKey();
        }

        static void RunApp()
        {
            menu = new Menu();
            menu.Start(hotelService, readWriteServiceInt, readWriteServiceString);
        }

        static string FileConfiguration(string configurationString)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            return ConfigurationSettings.AppSettings[configurationString];
#pragma warning restore CS0618 // Type or member is obsolete
                              //return ConfigurationManager.AppSettings[configurationString];
        }

        /*
        static void ConfigExchangeService(string path)
        {
            IDataContext<HotelService> dataContextER = new DataContext<HotelService>(path);
            dataContextER.DataProvider = new XMLDataProvider<HotelService>();

            hotelService = new CarrencyExchangeService(dataContextER);

        }
        */
        static ReadWriteService<T> ConfigReadWriteServices<T>(string path)
        {
            IDataContext<T> dataContextRW = new DataContext<T>(path);
            dataContextRW.DataProvider = new XMLDataProvider<T>();

            return (new ReadWriteService<T>(dataContextRW));
        }

        static void InitializeSettings()
        {
          /*  
            HotelInfo info = new HotelInfo() { roomNumber = 53, roomKind = "Suite", pricePerDay = 135, checkInTime = "10:00", checkOutTime = "20:00" };
            HotelInfo info2 = new HotelInfo() { roomNumber = 23, roomKind = "Suite", pricePerDay = 115, checkInTime = "10:00", checkOutTime = "20:00" };
            HotelInfo info3 = new HotelInfo() { roomNumber = 67, roomKind = "Suite", pricePerDay = 155, checkInTime = "10:00", checkOutTime = "20:00" };
            HotelInfo info4 = new HotelInfo() { roomNumber = 12, roomKind = "Studio", pricePerDay = 75, checkInTime = "10:00", checkOutTime = "20:00" };
            HotelInfo info5 = new HotelInfo() { roomNumber = 34, roomKind = "Studio", pricePerDay = 85, checkInTime = "10:00", checkOutTime = "20:00" };
            HotelInfo info6 = new HotelInfo() { roomNumber = 75, roomKind = "Family Suite", pricePerDay = 200, checkInTime = "10:00", checkOutTime = "20:00" };
            
            /*
            List<HotelInfo> hotelInfos = new List<HotelInfo>();
            hotelInfos.Add(new HotelInfo { roomNumber = 53, roomKind = "Suite", pricePerDay = 135, checkInTime = "10:00", checkOutTime = "20:00" });
            hotelInfos.Add(new HotelInfo { roomNumber = 23, roomKind = "Suite", pricePerDay = 115, checkInTime = "10:00", checkOutTime = "20:00" });
            hotelInfos.Add(new HotelInfo { roomNumber = 67, roomKind = "Suite", pricePerDay = 155, checkInTime = "10:00", checkOutTime = "20:00" });
            hotelInfos.Add(new HotelInfo { roomNumber = 12, roomKind = "Studio", pricePerDay = 75, checkInTime = "10:00", checkOutTime = "20:00" });
            hotelInfos.Add(new HotelInfo { roomNumber = 34, roomKind = "Studio", pricePerDay = 85, checkInTime = "10:00", checkOutTime = "20:00" });
            hotelInfos.Add(new HotelInfo { roomNumber = 75, roomKind = "Family Suite", pricePerDay = 200, checkInTime = "10:00", checkOutTime = "20:00" });

            foreach (var item in hotelInfos)
            {
                hotelService.Info = item;
            }
            
            
            hotelService.Info = info;
            hotelService.Info = info2;
            hotelService.Info = info3;
            hotelService.Info = info4;
            hotelService.Info = info5;
            hotelService.Info = info6;
        */    
        }
        
        
        static void InitialReadWriteSetting()
        {
            readWriteServiceInt.WriteData(12345);
            readWriteServiceString.WriteData("Mama mila ramu");
        }
        
    }
}
