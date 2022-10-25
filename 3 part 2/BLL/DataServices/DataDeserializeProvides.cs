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
    public class DataDeserializeProvides
    {
        public static List<StudentDTO> DataDeserialStudent(string nameOfFile)
        {
            List<Student> students = new List<Student>();
            List<StudentDTO> studentsDTO = new List<StudentDTO>();
            if (nameOfFile.EndsWith(".bin"))
            {
                BinaryDataProvider<List<Student>> provider = new BinaryDataProvider<List<Student>>();
                students = provider.Deserialize(nameOfFile);
                foreach (Student student in students)
                {
                    var studentDTO = student.ToDTO();
                    studentsDTO.Add(studentDTO);
                }

            }
            else if (nameOfFile.EndsWith(".json"))
            {
                JSONDataProvider<List<Student>> provider = new JSONDataProvider<List<Student>>();
                students = provider.Deserialize(nameOfFile);
                foreach (Student student in students)
                {
                    var studentDTO = student.ToDTO();
                    studentsDTO.Add(studentDTO);
                }

            }
            else if (nameOfFile.EndsWith(".xml"))
            {
                XMLDataProvider<List<Student>> provider = new XMLDataProvider<List<Student>>();
                students = provider.Deserialize(nameOfFile);
                foreach (Student student in students)
                {
                    var studentDTO = student.ToDTO();
                    studentsDTO.Add(studentDTO);
                }
            }
            else
            {
                throw new ProviderException("Serializer not defined!");
            }

            return studentsDTO;
        }
        public static List<Models.PilotDTO> DataDeserialPilot(string nameOfFile)
        {
            List<DAL.Entities.Pilot> pilots = new List<DAL.Entities.Pilot>();
            List<Models.PilotDTO> pilotsDTO = new List<Models.PilotDTO>();
            if (nameOfFile.EndsWith(".bin"))
            {
                BinaryDataProvider<List<DAL.Entities.Pilot>> provider = new BinaryDataProvider<List<DAL.Entities.Pilot>>();
                pilots = provider.Deserialize(nameOfFile);
                foreach (DAL.Entities.Pilot pilot in pilots)
                {
                    var pilotDTO = Mapper.ToDTO(pilot);
                    pilotsDTO.Add(pilotDTO);
                }

            }
            else if (nameOfFile.EndsWith(".json"))
            {
                JSONDataProvider<List<DAL.Entities.Pilot>> provider = new JSONDataProvider<List<DAL.Entities.Pilot>>();
                pilots = provider.Deserialize(nameOfFile);
                foreach (DAL.Entities.Pilot pilot in pilots)
                {
                    var pilotDTO = Mapper.ToDTO(pilot);
                    pilotsDTO.Add(pilotDTO);
                }

            }
            else if (nameOfFile.EndsWith(".xml"))
            {
                XMLDataProvider<List<DAL.Entities.Pilot>> provider = new XMLDataProvider<List<DAL.Entities.Pilot>>();
                pilots = provider.Deserialize(nameOfFile);
                foreach (DAL.Entities.Pilot pilot in pilots)
                {
                    var pilotDTO = Mapper.ToDTO(pilot);
                    pilotsDTO.Add(pilotDTO);
                }
            }
            else
            {
                throw new ProviderException("Serializer not defined!");
            }

            return pilotsDTO;
        }
        public static List<MusicianDTO> DataDeserialMusician(string nameOfFile)
        {
            List<Musician> musicians = new List<Musician>();
            List<MusicianDTO> musiciansDTO = new List<MusicianDTO>();
            if (nameOfFile.EndsWith(".bin"))
            {
                BinaryDataProvider<List<Musician>> provider = new BinaryDataProvider<List<Musician>>();
                musicians = provider.Deserialize(nameOfFile);
                foreach (Musician musician in musicians)
                {
                    var musicianDTO = musician.ToDTO();
                    musiciansDTO.Add(musicianDTO);
                }

            }
            else if (nameOfFile.EndsWith(".json"))
            {
                JSONDataProvider<List<Musician>> provider = new JSONDataProvider<List<Musician>>();
                musicians = provider.Deserialize(nameOfFile);
                foreach (Musician musician in musicians)
                {
                    var musicianDTO = musician.ToDTO();
                    musiciansDTO.Add(musicianDTO);
                }

            }
            else if (nameOfFile.EndsWith(".xml"))
            {
                XMLDataProvider<List<Musician>> provider = new XMLDataProvider<List<Musician>>();
                musicians = provider.Deserialize(nameOfFile);
                foreach (Musician musician in musicians)
                {
                    var musicianDTO = musician.ToDTO();
                    musiciansDTO.Add(musicianDTO);
                }
            }
            else
            {
                throw new ProviderException("Serializer not defined!");
            }

            return musiciansDTO;
        }
    }
}
}
