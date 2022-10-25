using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace PL.InputLogic
{
    public class InputCommands
    {
        public static string InputName(string message)
        {
            string Input;
            Regex regex = new Regex(Patterns.NamePattern);
            do
            {
                Console.Write("Enter " + message + " ");
                Input = Console.ReadLine();

            } while (!regex.IsMatch(Input));

            return Input;
        }

        public static int InputHeight(string message)
        {
            int Input;
            Regex regex = new Regex(Patterns.ClubPattern);

            Console.Write("Enter " + message + " ");
            Input = Int16.Parse(Console.ReadLine());

            return Input;
        }

        public static int InputCourse(string message)
        {

            int Input;
            Regex regex = new Regex(Patterns.ClubPattern);

            Console.Write("Enter " + message + " ");
            Input = Int16.Parse(Console.ReadLine());


            return Input;

        }
        public static string InputID(string message)
        {
            string Input;
            Regex regex = new Regex(Patterns.IDPattern);
            do
            {
                Console.Write("Enter " + message + " ");
                Input = Console.ReadLine();
            } while (!regex.IsMatch(Input));

            return Input;
        }

        public static string InputPassport(string message)
        {
            string Input;
            Regex regex = new Regex(Patterns.IDPattern);
            do
            {
                Console.Write("Enter " + message + " ");
                Input = Console.ReadLine();
            } while (!regex.IsMatch(Input));

            return Input;
        }

        public static int InputWeight(string message)
        {
            /*string Input;
            int Course;
            do
            {
                Console.Write("Enter " + message + " ");
                Input = Console.ReadLine();
                Course = int.Parse(Input);
            } while (Course <=0 && Course > 6);
            return Input;
            */
            string Input;
            int weight;
            do
            {
                Console.Write("Enter " + message + " ");
                Input = Console.ReadLine();
                weight = Int16.Parse(Input);
            } while (weight <= 0 && weight > 200);

            return weight;
        }

        public static int InputWorkExperience(string message)
        {
            string Input;
            int Exp;
            do
            {
                Console.Write("Enter " + message + " ");
                Input = Console.ReadLine();
                Exp = int.Parse(Input);
            } while (Exp <= 0 && Exp > 60);
            Exp = int.Parse(Input);
            return Exp;
        }


        public static int InputSalary(string message)
        {
            string Input;
            int Salary;
            do
            {
                Console.Write("Enter " + message + " ");
                Input = Console.ReadLine();
                Salary = int.Parse(Input);
            } while (Salary <= 0 && Salary > 9999);
            Salary = int.Parse(Input);
            return Salary;
        }

        public static string InputCity(string message)
        {

            string Input;
            Regex regex = new Regex(Patterns.NamePattern);
            do
            {
                Console.Write("Enter " + message + " ");
                Input = Console.ReadLine();
            } while (!regex.IsMatch(Input));

            return Input;
        }

        public static string InputFileName(string message)
        {
            string Input;
            bool isValid = true;
            do
            {
                Console.Write("Enter: " + message + " ");
                Input = Console.ReadLine();
                isValid = true;
                if (Input.IndexOfAny(Path.GetInvalidFileNameChars()) != -1)
                {
                    isValid = false;
                }
                else if (!Input.EndsWith(".bin") && !Input.EndsWith(".json") && !Input.EndsWith(".xml"))
                {
                    isValid = false;
                }
            } while (isValid == false);
            var path = Path.Combine(Patterns.Path, Input);
            return path;
        }

        public static string FileExists(string message)
        {
            string Input;
            string path;
            bool isValid = false;
            do
            {
                Console.Write("Enter: " + message + " ");
                Input = Console.ReadLine();
                path = Path.Combine(Patterns.Path, Input);
                if (File.Exists(path))
                {
                    isValid = true;
                }
            } while (isValid == false);
            return path;
        }

        public static int InputChoice()
        {
            string Input;
            int Choice;
            do
            {
                Input = Console.ReadLine();
                Choice = int.Parse(Input);
            } while (Choice < 1 && Choice > 3);
            Choice = int.Parse(Input);
            return Choice;
        }
    }
}
