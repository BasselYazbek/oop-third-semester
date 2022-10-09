using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LabWork_1_third_semester_in_Csharp
{
    class Program
    {
        public static void Main()
        {
            StreamWriter sw = new StreamWriter(".\\ Students.txt");

            Console.WriteLine("Here are the students informations:");
            sw.WriteLine("Here are the students informations:");
            Console.WriteLine();

            Students student1 = new Students("Yazbek", "Bassel", 2 , 156489 ,"Gender: Male", "Living in the Dorm: No");
            Students student2 = new Students("Bou hamdan", "Adham", 1, 1569475, "Male", "27_building.room");
            Students student3= new Students("Harb", "Wisl", 1, 159847, "Female", "35_building.room");
            Students student4 = new Students("Monzer", "Carol", 1, 4148794, "Female", "32_building.room");

            Console.WriteLine("First Student :" + student1);
            sw.WriteLine("First Student :" + student1);
            sw.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Second Student :" + student2);
            sw.WriteLine("Second Student :" + student2);
            sw.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Third Student :" + student3);
            sw.WriteLine("Third Student : " + student3);
            sw.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Forth Student :" + student4);
            sw.WriteLine("Forth Student : " + student4);
            sw.WriteLine();
            Console.WriteLine();

            // The method in order to add the Students who are in there first
            //year and living in the dorm
            int sum = student1.StudentsInDorm(student1) +student2.StudentsInDorm
                (student2) + student3.StudentsInDorm(student3) + 
                student4.StudentsInDorm(student4);

            Console.WriteLine("Amount of Students who are in the First year and " +
                "also are Living in the dorm are: " + sum);

            sw.WriteLine("Amount of Students who are in the First year and " +
               "also are Living in the dorm are: " + sum);

            // Here we will add the abstract method to calculate the students who can Skate
            int sumToSkate = student1.Skate() + student2.Skate() + student3.Skate()
                + student4.Skate();
            
            Console.WriteLine();
            sw.WriteLine();
            
            Console.WriteLine("The Amount of students who can Skate is: " + sumToSkate);

            sw.WriteLine("The Amount of students who can Skate is: " + sumToSkate);
            Console.WriteLine("=======================================================");

            Console.WriteLine();


            // Create the file.txt for the pillots informations.
            StreamWriter pilot = new StreamWriter(".\\Pilots.txt");

            // Add informations about some pilots
            Pilot pilot1 = new Pilot("Arakji", "Wael", "Male", "Fly Emirates", "Boing 12-85", 27);
            Pilot pilot2 = new Pilot("Tawaji", "Hiba", "Female", "Middle East Airlines", "Boing 230-25", 32);
            Pilot pilot3 = new Pilot("Saoud", "Amir", "Male", "Qatar Airways", "Boing 23 - 26", 48);

            // Write the informations in the debig and also in the Pilots.txt file
            Console.WriteLine("Pilot number 1: " + pilot1);
            pilot.WriteLine("Pilot Number 1: " + pilot1);
            Console.WriteLine();
            pilot.WriteLine();

            Console.WriteLine("Pilot number 2: " + pilot2);
            pilot.WriteLine("Pilot number 2: " + pilot2);
            Console.WriteLine();
            pilot.WriteLine();

            Console.WriteLine("Pilot Number 3: " + pilot3);
            pilot.WriteLine("Pilot Number 3: " + pilot3);

            Console.WriteLine();
            pilot.WriteLine();

            // Counting and writing in Pilots.txt amount who can Skate.
            int pilotSkateAmount = pilot1.Skate() + pilot2.Skate() + pilot3.Skate();
            Console.WriteLine("The amount of Pilots who can Skate is: " + pilotSkateAmount);
            pilot.WriteLine("The amount of Pilots who can Skate is: " + pilotSkateAmount);
            Console.WriteLine("=============================================");
            Console.WriteLine();


            // creat a file.txt for the musician and also insert elements...
            StreamWriter musician = new StreamWriter(".// Musicians.txt");
         
            Musician musician1 = new Musician("Kfoury", "Wael", "Male", "Beirut, Lebanon", "Love Musics", 50);
            Musician musician2 = new Musician("Karam", "Najwa", "Female", "Hamra, Lebanon", "Classic Music", 36);
            Musician musician3 = new Musician("Khoury", "Marwan", "Male", "Batroun, Lebanon", "Feelings Musics", 38);
            Musician musician4 = new Musician("Wehbi", "Haifa", "Female", "Rawshi, Beirut", "Love Music", 58);

            Console.WriteLine("The first Singer is: " + musician1);
            musician.WriteLine("The first Singer is: " + musician1);
            Console.WriteLine();
            musician.WriteLine();

            Console.WriteLine("The Second singer is: " + musician2);
            musician.WriteLine("The second singer is: " + musician2);
            Console.WriteLine();
            musician.WriteLine();

            Console.WriteLine("The third singer is: " + musician3);
            musician.WriteLine("The third singer is: " + musician3);
            Console.WriteLine();
            musician.WriteLine();

            Console.WriteLine("The forth singer is: " + musician4);
            musician.WriteLine("The forth singer is: " + musician4);
            Console.WriteLine();
            musician.WriteLine();

            // Calculate the amount of Musician who can skate depending on the abstract method
            int MucisianSkateAmount = musician1.Skate() + musician2.Skate() + musician3.Skate() + musician4.Skate();
            Console.WriteLine("The amount of Pilots who can Skate is: " + MucisianSkateAmount);
            musician.WriteLine("The amount of Pilots who can Skate is: " + MucisianSkateAmount);


            Console.ReadLine();
            sw.Close();
            pilot.Close();
            musician.Close();
        }
    }
}
