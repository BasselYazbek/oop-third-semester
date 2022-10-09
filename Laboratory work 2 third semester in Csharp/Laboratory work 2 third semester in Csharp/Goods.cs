//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace lab2_3semester
{
    class Point
    {
        private int x;
        private int y;
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    public class Vector : IComparable
    {
        readonly Point A;
        readonly Point B;
        Point VectorPoint;
        private string color;
        private double length;
        public Vector(int ax, int ay, int bx, int by, string color)
        {
            A = new Point(ax, ay);
            B = new Point(bx, by);
            VectorPoint = new Point(B.X - A.X, B.Y - A.Y);
            color = color;
        }
        public string Color { get => color; set => color = value; }
        public double Length
        {
            get
            {
                length = Math.Sqrt(Math.Pow(VectorPoint.X, 2) + Math.Pow(VectorPoint.Y, 2));
                return length;
            }
        }
        public int CompareTo(object o)
        {
            Vector other = o as Vector;
            if (Length < other.Length) return -1;
            else if (Length > other.Length) return 1;
            else if (Length == other.Length) return 0;
            else throw new Exception("Impossible to compare objects");
        }

        public void PlusVector(int x, int y)
        {
            B.X += x;
            B.Y += y;
            VectorPoint = new Point(B.X - A.X, B.Y = A.Y);
        }
        public override string ToString()
        {
            return $"Vector coordinates\nCoord X: {VectorPoint.X}" +
                $"\nCoord Y: {VectorPoint.Y}" +
                $"\nVector color: {Color}" +
                $"\nVector length: {Length}\n";
        }
    }

}
