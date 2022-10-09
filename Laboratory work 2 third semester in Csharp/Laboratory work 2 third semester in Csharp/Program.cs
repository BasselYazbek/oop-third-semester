
//using lab2_3semester.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace lab2_3semester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Vector vector1 = new Vector(10, 5, 4, -7, "Red");
            Vector vector2 = new Vector(12, -3, 2, 1, "Blue");
            Vector vector3 = new Vector(11, 11, 3, 4, "Orange");

            BinaryTree<Vector> vectors = new BinaryTree<Vector>(vector1, vector2, vector3);
            vectors.AddItem(vector1);
            vectors.AddItem(vector3);
            vectors.Print();
            Console.WriteLine();
            Console.WriteLine(string.Join("", vectors.Preorder()));
        }

    }
}
