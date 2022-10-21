using System;
using BLL;
using DAL;
using DataProviderContract;
using XMLProvider;
using PL;
using System.Collections.Generic;

using System.Configuration;


namespace ConsoleApp
{
    class MainApp
    {
        //static IDataContext<ExchangeRate> dataContext;
        //static IDataContext<int> dataContextInt;

        static Students students;
        static IDataReadWriteService<int> readWriteServiceInt;
        static IDataReadWriteService<string> readWriteServiceString;

        static IMenu menu;

        static void Main(string[] args)
        {   
            List<CurrentStudent> studentsss = new List<CurrentStudent>();
            studentsss.Add(new CurrentStudent("Bassel", "Yazbek", 2, "BEI- 456982", "Beirut, Lebanon", "No", "Male"));
            studentsss.Add(new CurrentStudent("Wael", "Arakji", 4, "BEI-4863217", "Mount Lebanon", "Yes", "Male"));
            studentsss.Add(new CurrentStudent("Hiba ", "Tawaji", 1, "BEI-821639", "Jeita, Lebanon", "Yes", "Female"));
            studentsss.Add(new CurrentStudent("Nour", "Akiki", 2, "BEI-522944", "Mount Lebanon", "Yes", "Female"));


            foreach (var item in studentsss)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==========================");
            Console.WriteLine("The students who are girls, first year and also in the dorm are: ");

            foreach (var item in studentsss)
            {
                Console.WriteLine(item.CountEquation());
                
            }

            Console.WriteLine("=============================");
            
            

            Console.WriteLine("===========================");

            string config;
           //ConfigServices();
           //RunServices();
            config = FileConfiguration("ratefile");
            ConfigExchangeService(config);
            //InitialCurrentRateSetting();

            

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
            menu.Start(students, readWriteServiceInt, readWriteServiceString);
        }

        static string FileConfiguration(string configurationString)
        {
            return ConfigurationManager.AppSettings[configurationString];
        }

        static void ConfigExchangeService(string path)
        {
            IDataContext<Student> dataContextER = new DataContext<Student>(path);
            dataContextER.DataProvider = new XMLDataProvider<Student>();

            students = new StudentServices(dataContextER);

        }

        /*
        static void InitialCurrentRateSetting()
        {
            List<CurrentStudent> studentsss = new List<CurrentStudent>();
            studentsss.Add(new CurrentStudent("Bassel", "Yazbek", 2, "BEI- 456982", "Beirut, Lebanon", "No", "Male"));
            studentsss.Add(new CurrentStudent("Wael", "Arakji", 4, "BEI-4863217", "Mount Lebanon", "Yes", "Male"));
            studentsss.Add(new CurrentStudent("Hiba ", "Tawaji", 1, "BEI-821639", "Jeita, Lebanon", "Yes", "Female"));
            studentsss.Add(new CurrentStudent("Nour", "Akiki", 2, "BEI-522944", "Mount Lebanon", "Yes", "Female"));
            
            foreach (var item in studentsss)
            {
                Console.WriteLine(item);
            }
        }
        */
        

        static ReadWriteService<T> ConfigReadWriteServices<T>(string path)
        {
            IDataContext<T> dataContextRW = new DataContext<T>(path);
            dataContextRW.DataProvider = new XMLDataProvider<T>();

            return (new ReadWriteService<T>(dataContextRW));
        }

       
        static void InitialReadWriteSetting()
        {
            readWriteServiceInt.WriteData(3);
            readWriteServiceString.WriteData("This is my Variant");
        }
          
       
    }
}
