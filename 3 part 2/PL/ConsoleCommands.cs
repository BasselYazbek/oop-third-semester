using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PL.InputLogic;
using BLL.DataServices;
using BLL.Models;
using BLL;
using DAL.Entities;
using DAL.Providers;
using DAL.Repisoteries;

namespace PL
{
    public class ConsoleCommands
    {
        public static void AddStudent()
        {
            StudentDTO student = new StudentDTO();
            student.FirstName = InputCommands.InputName("First name. ");
            student.LastName = InputCommands.InputName("Last name. ");
            student.Gender = InputCommands.InputName("Gender. ");
            student.YearOfStudy = InputCommands.InputCourse("Year: ");
            student.StudentID = InputCommands.InputID("Student ID: ");
            student.PlaceOfResidence = InputCommands.InputCity("Place of recidence ");
            student.DormStudents = InputCommands.InputCity("Dorm Students: ");

            string fileName = InputCommands.InputFileName("Filename: ");
            var students = new List<StudentDTO>();
            students.Add(student);
            DataProvider.DataStudentsProvider(students, fileName);


        }

        public static void AddMusician()
        {
            MusicianDTO musician = new MusicianDTO();
            musician.FirstName = InputCommands.InputName("first name:");
            musician.LastName = InputCommands.InputName("last name:");
            musician.Gender = InputCommands.InputName("Gender. ");
            musician.MusicKind = InputCommands.InputName("Music kind: ");
            musician.SalaryPerEvent = InputCommands.InputSalary("Salary: ");

            string fileName = InputCommands.InputFileName("filename: ");
            var musicians = new List<MusicianDTO>();
            musicians.Add(musician);
            DataProvider.DataMusicianProvider(musicians, fileName);
        }

        public static void AddPilot()
        {

            PilotDTO pilot = new PilotDTO();
            pilot.FirstName = InputCommands.InputName("first name:");
            pilot.LastName = InputCommands.InputName("last name:");
            pilot.Gender = InputCommands.InputName("Gender. ");
            pilot.AirLines = InputCommands.InputName("Air Lines: ");
            pilot.MonthSalary = InputCommands.InputName("Salary: ");

            string fileName = InputCommands.InputFileName("filename: ");
            var pilots = new List<PilotDTO>();
            pilots.Add(pilot);
            DataProvider.DataPilotProvider(pilots, fileName);
        }

        public static void ReadFile()
        {
            Console.WriteLine(Patterns.Read);
            int choice = InputCommands.InputChoice();

            switch (choice)
            {
                case 1:
                    ReadStudents();
                    break;
                case 2:
                    ReadMusician();
                    break;
                case 3:
                    ReadPilot();
                    break;
            }
        }

        public static void CalculateStudents()
        {
            //  Console.WriteLine("First enter the city.");
            //   var city = InputCommands.InputCity("city:");
            //   Console.WriteLine("Now input the name of file you want to read student from:");
            var filePath = InputCommands.FileExists("file name:");
            var students = DataDeserializeProvider.DataDeserialStudent(filePath);
            int count = 0;
            foreach (var student in students)
            {
                if (student.PerfectWeight == true)
                {
                    count++;
                }
            }

            //int percentage = (count * 100) / students.Count;
            Console.WriteLine($"There are {count} students with perfect weight.");
        }

        private static void ReadStudents()
        {
            var filePath = InputCommands.FileExists("file name:");
            var students = DataDeserializeProvider.DataDeserialStudent(filePath);
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }

        private static void ReadMusician()
        {
            var filePath = InputCommands.FileExists("file name:");
            var musicians = DataDeserializeProvider.DataDeserialLibrarian(filePath);
            foreach (var musician in musicians)
            {
                Console.WriteLine(musician.ToString());
            }
        }

        private static void ReadPilot()
        {
            var filePath = InputCommands.FileExists("file name:");
            var pilots = DataDeserializeProvider.DataDeserialSoftwareDeveloper(filePath);
            foreach (var pilot in pilots)
            {
                Console.WriteLine(pilot.ToString());
            }
        }
        public static void GetDirectoryInfo()
        {
            string[] files = Directory.GetFiles(Patterns.Path);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
