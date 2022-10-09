using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3semester
{
    public class Collections
    {
        public static void Arrays()
        {
            Vector[] vectors = new Vector[3];
            vectors[0] = new Vector(-4, 3, 9, 4, "Blue");
            vectors[1] = new Vector(3, 7, -9, 1, "Green");
            vectors[2] = new Vector(8, 5, -2, 5, "Yellow");
            foreach (Vector vector in vectors)
            {
                Console.WriteLine(vector.ToString());
            }
            Array.Resize(ref vectors, 2);
            foreach (Vector vector in vectors)
            {
                Console.WriteLine(vector.ToString());
            }
            foreach (Vector vector in vectors)
            {
                Vector findvector = new Vector(3, 7, -9, 1, "Green");
                Console.Write(Array.Find(vectors, vectorf => vectorf.Equals(findvector)));
            }
        }
        public static void GenericCollection()
        {
            List<Vector> vectorsList = new List<Vector>();
            Vector vector1 = new Vector(10, 5, 4, -7, "Red");
            Vector vector2 = new Vector(12, -3, 2, 1, "Blue");
            Vector vector3 = new Vector(11, 11, 3, 4, "Orange");
            Vector find = new Vector(10, 5, 4, -7, "Red");
            vectorsList.Add(vector1);
            vectorsList.Add(vector2);
            vectorsList.Add(vector3);
            foreach (Vector vector in vectorsList)
            {
                Console.WriteLine(vector.ToString());
            }
            vectorsList.Remove(vector2);
            foreach (Vector vector in vectorsList)
            {
                Console.WriteLine(vector.ToString());
            }
            if (!vectorsList.Contains(find))
            {
                Console.WriteLine(find.ToString());
            }
        }
        public static void NonGenericCollection()
        {
            ArrayList arrayList = new ArrayList();
            Vector vector1 = new Vector(10, 5, 4, -7, "Red");
            Vector vector2 = new Vector(12, -3, 2, 1, "Blue");
            Vector vector3 = new Vector(11, 11, 3, 4, "Orange");
            Vector find = new Vector(11, 11, 3, 4, "Orange");
            arrayList.Add(vector1);
            arrayList.Add(vector2);
            arrayList.Add(vector3);
            foreach (Vector vector in arrayList)
            {
                Console.WriteLine(vector.ToString());
            }
            arrayList.Remove(vector2);
            foreach (Vector vector in arrayList)
            {
                Console.WriteLine(vector.ToString());
            }
            if (!arrayList.Contains(find))
            {
                Console.WriteLine(find.ToString());
            }
        }
    }
}
