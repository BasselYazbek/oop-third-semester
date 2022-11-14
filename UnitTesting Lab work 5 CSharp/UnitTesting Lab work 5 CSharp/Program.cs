using System;
using BLL.Interfaces;
using BLL.Services;
using DAL;
using DataProviderContact;
using XMLProvider;
using PL;
using System.Configuration;
using System.Collections.Generic;

namespace UnitTesting_Lab_work_5_CSharp
{
    class Program
    {
        static ICalculateStudents calculateStudents;
        static ICalculateMusicians calculateMusicians;
        static ICalculatePilots calculatePilots;
        static IDataReadWriteService<int> readWriteServiceInt;
        static IDataReadWriteService<string> readWriteServiceString;
        static IMenu menu;

        static void Main(string[] args)
        {
            string config;
            // ConfigServices();
            //RunServices();
            config = FileConfiguration("ratefile");
            ConfigExchangeService(config);
            InitialCurrentStudents();
            Console.WriteLine("==========================");
            InitialCurrentMusicians();
            Console.WriteLine("==========================");
            InitialCurrentPilots();
            Console.WriteLine("==========================");

            config = FileConfiguration("intfile");
            readWriteServiceInt = ConfigReadWriteServices<int>(config);

            config = FileConfiguration("stringfile");
            readWriteServiceString = ConfigReadWriteServices<string>(config);

            InitialReadWriteSetting();

            RunApp();
            

            Console.ReadKey();

        }

        static void RunApp()
        {
            menu = new Menu();
            menu.Start(calculateStudents, calculateMusicians, calculatePilots ,readWriteServiceInt, readWriteServiceString);
        }

        static string FileConfiguration(string configurationString)
        {
            return ConfigurationManager.AppSettings[configurationString];
        }

        static void ConfigExchangeService(string path)
        {
            IDataContext<CalculateStudents> dataContextER = new DataContext<CalculateStudents>(path);
            dataContextER.DataProvider = new XMLDataProvider<CalculateStudents>();

            calculateStudents = new StudentsCalculationMethod(dataContextER);

        }

        static void InitialCurrentStudents()
        {
            List<CurrentStudents> studentInfo = new List<CurrentStudents>();
            studentInfo.Add(new CurrentStudents("Bassel", "Yazbek", 2, 156479, "Male", "Lebanon, Beirut", "No"));
            studentInfo.Add(new CurrentStudents("Hiba", "Tawaji", 1, 123548, "Female", "Rawshi, Lebanon", "Yes"));
            studentInfo.Add(new CurrentStudents("Nancy", "Ajram", 1, 154814, "Female", "Rawshi, Lebanon", "Yes"));
            studentInfo.Add(new CurrentStudents("Haifa", "Wehbeh", 1, 195204, "Female", "Rawshi, Lebanon", "Yes"));

            foreach (var item in studentInfo)
            {
                Console.WriteLine(item);
            }
            /*
            CurrentStudents studentsInfo = new CurrentStudents() { firstName = "Bassel", lastName = "Yazbek", gender = "Male", yearOfStudy = 2, studentID = 15621, placeOfResidence = "Lebanon, Beirut", campusStudents = "No" };
            calculateStudents.Students = studentsInfo;
            */
        }

        static void InitialCurrentMusicians()
        {
            List<CurrentMusicians> musiciansInfo = new List<CurrentMusicians>();
            musiciansInfo.Add(new CurrentMusicians("Marwan", "Khoury", "Male", "Beirut, Lebanon", "Arabic Music"));
            musiciansInfo.Add(new CurrentMusicians("Marwan", "Naseef", "Zaitoun", "Baalbak, Lebanon", "Arabic Music"));
            musiciansInfo.Add(new CurrentMusicians("Najwa", "Karam", "Female", "Beirut, Lebanon", "Arabic Music"));

            foreach (var item in musiciansInfo)
            {
                Console.WriteLine(item);
            }
        }

        static void InitialCurrentPilots()
        {
            List<CurrentPilots> currentPilots = new List<CurrentPilots>();
            currentPilots.Add(new CurrentPilots("Waleed", "Zoughaib", "Male", "Lebanon", "Middle East Airlines"));
            currentPilots.Add(new CurrentPilots("Ali", "Assaf", "Male", "Dubai", "Emirated Airlines"));
            currentPilots.Add(new CurrentPilots("Ahmad", "Wajdi", "Male", "Doha, Qatar", "Qatar Airlines"));

            foreach (var item in currentPilots)
            {
                Console.WriteLine(item);
            }
        }

        static ReadWriteService<T> ConfigReadWriteServices<T>(string path)
        {
            IDataContext<T> dataContextRW = new DataContext<T>(path);
            dataContextRW.DataProvider = new XMLDataProvider<T>();

            return (new ReadWriteService<T>(dataContextRW));
        }


        static void InitialReadWriteSetting()
        {
            readWriteServiceInt.WriteData(12345);
            readWriteServiceString.WriteData("Mama mila ramu");
        }
    }
}
