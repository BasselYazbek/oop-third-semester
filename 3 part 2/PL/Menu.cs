using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PL
{
    public class Menu
    {
        public static void StartMenu()
        {
            Help();
            string input;
            do
            {
                input = Console.ReadLine();
                input.ToLower();
                Regex.Replace(input, @"\s+", "");
                if (input == "0")
                {
                    Help();
                }
                else if (input == "1")
                {
                    ConsoleCommands.AddStudent();
                }
                else if (input == "2")
                {
                    ConsoleCommands.AddMusicain();
                }
                else if (input == "3")
                {
                    ConsoleCommands.AddPilot();
                }
                else if (input == "4")
                {
                    ConsoleCommands.ReadFile();
                }
                else if (input == "5")
                {
                    ConsoleCommands.CalculateStudents();
                }
                else if (input == "6")
                {
                    Console.WriteLine("In order to exit the program press Enter.");
                }
                else Console.WriteLine("Command wasn't found, try again.");
            } while (input != "6");
        }

        private static void Help()
        {
            string message = "Choose the command :\n" +
                "0 - Show all available commands;\n" +
                "1 - Add new student;\n" +
                "2 - Add new Musician;\n" +
                "3 - Add new Pilot;\n" +
                "4 - open file;\n" +
                "5 - calculate number of students with perfect weight;\n" +
                "6 - Exit program;";

            Console.WriteLine(message);
        }

    }

}
