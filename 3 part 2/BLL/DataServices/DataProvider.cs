using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;
using DAL.Entities;
using DAL.Providers;

namespace BLL.DataServices
{
    public class DataProvider
    {
        public static void DataStudentsProvider(List<StudentDTO> studentsDTO, string nameOfFile)
        {
            List<Student> students = new List<Student>();
            foreach (StudentDTO studentDTO in studentsDTO)
            {
                var student = studentDTO.FromDTO();
                students.Add(student);
            }

            if (nameOfFile.EndsWith(".bin"))
            {
                BinaryDataProvider<List<Student>> provider = new BinaryDataProvider<List<Student>>();
                provider.Serialize(students, nameOfFile);

            }
            else if (nameOfFile.EndsWith(".json"))
            {
                JSONDataProvider<List<Student>> provider = new JSONDataProvider<List<Student>>();
                provider.Serialize(students, nameOfFile);
            }

            else if (nameOfFile.EndsWith(".xml"))
            {
                XMLDataProvider<List<Student>> provider = new XMLDataProvider<List<Student>>();
                provider.Serialize(students, nameOfFile);
            }
            else
            {
                throw new ProviderException("Serializer not defined!");
            }
        }
        public static void DataPilotProvider(List<PilotDTO> pilotsDTO, string nameOfFile)
        {
            List<Pilot> pilots = new List<Pilot>();
            foreach (var pilotDto in pilotsDTO)
            {
                var pilot = pilotDto.FromDTO();
                pilots.Add(pilot);
            }

            if (nameOfFile.EndsWith(".bin"))
            {
                BinaryDataProvider<List<DAL.Entities.Pilot>> provider = new BinaryDataProvider<List<DAL.Entities.Pilot>>();
                provider.Serialize(pilots, nameOfFile);
            }

            else if (nameOfFile.EndsWith(".json"))
            {
                JSONDataProvider<List<DAL.Entities.Pilot>> provider = new JSONDataProvider<List<DAL.Entities.Pilot>>();
                provider.Serialize(pilots, nameOfFile);
            }

            else if (nameOfFile.EndsWith(".xml"))
            {
                XMLDataProvider<List<DAL.Entities.Pilot>> provider = new XMLDataProvider<List<DAL.Entities.Pilot>>();
                provider.Serialize(pilots, nameOfFile);
            }
            else
            {
                throw new ProviderException("Serializer not defined!");
            }


        }

        public static void DataMusicianProvider(List<MusicianDTO> musiciansDTO, string nameOfFile)
        {
            List<Musician> musicians = new List<Musician>();
            foreach (var musicianDTO in musiciansDTO)
            {
                var musician = musicianDTO.FromDTO();
                musicians.Add(musician);
            }

            if (nameOfFile.EndsWith(".bin"))
            {
                BinaryDataProvider<List<Musician>> provider = new BinaryDataProvider<List<Musician>>();
                provider.Serialize(musicians, nameOfFile);
            }

            else if (nameOfFile.EndsWith(".json"))
            {
                JSONDataProvider<List<Musician>> provider = new JSONDataProvider<List<Musician>>();
                provider.Serialize(musicians, nameOfFile);
            }

            else if (nameOfFile.EndsWith(".xml"))
            {
                XMLDataProvider<List<Musician>> provider = new XMLDataProvider<List<Musician>>();
                provider.Serialize(musicians, nameOfFile);
            }

            else
            {
                throw new ProviderException("Serializer not defined!");
            }

        }
    }
}
