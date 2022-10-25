using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;
using DAL.Entities;

namespace BLL
{
    public static class Mapper
    {
        public static StudentDTO ToDTO(this Student student)
        {
            return new StudentDTO()
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                Gender = student.Gender,
                YearOfStudy = student.YearOfStudy,
                StudentID = student.StudentID,
                PlaceOfResidence = student.PlaceOfResidence,
                DormStudents = student.DormStudents
            };
        }

        public static Student FromDTO(this StudentDTO student)
        {
            return new Student()
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                Gender = student.Gender,
                YearOfStudy = student.YearOfStudy,
                StudentID = student.StudentID,
                PlaceOfResidence = student.PlaceOfResidence,
                DormStudents = student.DormStudents
            };
        }

        public static MusicianDTO ToDTO(this Musician musician)
        {
            return new MusicianDTO()
            {
                FirstName = musician.FirstName,
                LastName = musician.LastName,
                Gender = musician.Gender,
                MusicKind = musician.MusicKind,
                SalaryPerEvent = musician.SalaryPerEvent
            };
        }

        public static Musician FromDTO(this MusicianDTO musician)
        {
            return new Musician()
            {
                FirstName = musician.FirstName,
                LastName = musician.LastName,
                Gender = musician.Gender,
                MusicKind = musician.MusicKind,
                SalaryPerEvent = musician.SalaryPerEvent
            };
        }

        public static PilotDTO ToDTO(this Pilot pilot)
        {
            return new PilotDTO()
            {
                FirstName = pilot.FirstName,
                LastName = pilot.LastName,
                Gender = pilot.Gender,
                AirLines = pilot.AirLines,
                MonthSalary = pilot.MonthSalary
            };
        }

        public static Pilot FromDTO(this PilotDTO pilot)
        {
            return new Pilot()
            {
                FirstName = pilot.FirstName,
                LastName = pilot.LastName,
                Gender = pilot.Gender,
                AirLines = pilot.AirLines,
                MonthSalary = pilot.MonthSalary
            };
        }
    }
}
