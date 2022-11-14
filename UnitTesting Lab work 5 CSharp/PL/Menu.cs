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
        ICalculateStudents _calculateStudents;
        ICalculateMusicians _calculateMusicians;
        ICalculatePilots _calculatePilos;
        IDataReadWriteService<int> _readWriteServiceInt;
        IDataReadWriteService<string> _readWriteServiceString;

        public void Start(ICalculateStudents calculateStudents,
                          ICalculateMusicians calculateMusicians,
                          ICalculatePilots calculatePilots,
                          IDataReadWriteService<int> readWriteServiceInt,
                          IDataReadWriteService<string> readWriteServiceString)
        {
            _calculateStudents = calculateStudents;
            PrintCurrentStudents();

            _calculateMusicians = calculateMusicians;
            PrintCurrentMusicians();

            _calculatePilos = calculatePilots;
            PrintCurrentPilots();

            PrintCalculatedStudents();
            PrintLearnNewMusic();

            _readWriteServiceInt = readWriteServiceInt;
            _readWriteServiceString = readWriteServiceString;
            PrintTypes();
        }

        public void PrintCurrentStudents()
        {
            Console.WriteLine("Student last name is: {0}/n First name is: {1}/n Year of study is: {2}/n StudentID: {3}/n Gender: {4}/n Place of residence: {5}/n Campus student: {6}/n ========================", _calculateStudents.Students.lastName, _calculateStudents.Students.firstName, _calculateStudents.Students.yearOfStudy, _calculateStudents.Students.studentID, _calculateStudents.Students.gender, _calculateStudents.Students.placeOfResidence, _calculateStudents.Students.campusStudents);
        }

        public void PrintCurrentMusicians()
        {
            Console.WriteLine("Student last name is: {0}/n First name is: {1}/n Gender: {2}/n Place of residence: {3}/n Music kind: {4}/n ========================", _calculateMusicians.Musicians.lastName, _calculateMusicians.Musicians.firstName, _calculateMusicians.Musicians.gender, _calculateMusicians.Musicians.placeOfResidence, _calculateMusicians.Musicians.musicKind);
        }

        public void PrintCurrentPilots()
        {
            Console.WriteLine("Student last name is: {0}/n First name is: {1}/n Gender: {2}/n Place of residence: {3}/n Air lines name: {4}/n ========================", _calculatePilos.Pilots.lastName, _calculatePilos.Pilots.firstName, _calculatePilos.Pilots.gender, _calculatePilos.Pilots.placeOfResidence, _calculatePilos.Pilots.airLinesName);
        }

        public void PrintCalculatedStudents()
        {
            Console.WriteLine("The amount of students who are female, first year and living in the dorm is:/n {0}", _calculateStudents.CalculateMethod());
        }

        public void PrintLearnNewMusic() => Console.WriteLine(_calculateMusicians.LearnNewMusic());

        public void PrintTypes()
        {
            int number = _readWriteServiceInt.ReadData();
            Console.WriteLine($"number = {number}");

            string str = _readWriteServiceString.ReadData();
            Console.WriteLine($"str = {str}");
        }
    }
}
