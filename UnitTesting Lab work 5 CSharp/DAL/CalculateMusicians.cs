using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DAL
{
    [Serializable]
    public class CalculateMusicians : Person
    {
        private string MusicKind;

        public CalculateMusicians() { }
        public CalculateMusicians(string FirstName, string LastName, string Gender, string PlaceOfResidence, string MusicKind)
            :base (FirstName, LastName, Gender, PlaceOfResidence)
        {
            this.MusicKind = MusicKind;
        }

        public string musicKind { get; set; }

        public void LearnNewMusic()
        {
            if(gender == "Male" || gender == "male")
            {
                Console.WriteLine("This Musician can learn new music");
            }
        }
    }
}
