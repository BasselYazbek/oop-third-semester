using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab_Work_4_third_semester_Csharp
{
    class Program
    {
        private delegate void GetAStringDelegate(string text);

        static void Main()
        {
            var user = new StackkItems();
            
            var first = new Consumer("Bassel");
            user.NewStackInfo += first.NewStackIsHere;

            user.NewStack("I'm the first person");

            var second = new Consumer("Jimy");
            user.NewStackInfo += second.NewStackIsHere;

            user.NewStack("I'm the second person");

            var third = new Consumer("Reem");
            user.NewStackInfo += second.NewStackIsHere;

            user.NewStack("I'm the third person");

            //In order to remove:
            user.NewStackInfo -= second.NewStackIsHere;

            user.NewStack("There is a lot more customers");
            Console.WriteLine("=======================");

            // use the delegates
            GetAStringDelegate stringDelegate = getSentenceToUpper;
            stringDelegate("This is my first Delegate method");

            // use with another method
            stringDelegate = getSentenceToLower;
            stringDelegate.Invoke("HERE IS ANOTHER METHOD");
            Console.WriteLine("=====================");

            // Anonymous method
            // Here i will add words in order to make a sentence
            //Using Lambda expression
            string firstPart = "My name is Bassel";
            Func<string, string> anon = delegate (string full)
            {
                full += firstPart;
                full += "This is added to the string using anonymous method.";
                return full;
            };
            Console.WriteLine(anon);

            Console.ReadLine();
        }

        // Method for delegate for upper case
        static void getSentenceToUpper(string text)
        {
            Console.WriteLine(text.ToUpper());
        }

        // method for delegate for lower case
        static void getSentenceToLower(string text)
        {
            Console.WriteLine(text.ToLower());
        }

    }
}
