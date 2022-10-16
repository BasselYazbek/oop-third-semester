using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LabWork_3_in_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Goods[] goods;
            int arraySize = 5;

            goods = new Goods[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                goods[0] = new Goods(5614648, "Galaxy chocolate", "Switherland", 3.62, 389);
                goods[1] = new Goods(45679871, "Milka Bar", "Germany", 4.85, 238);
                goods[2] = new Goods(789547841, "Nutella Go!", "Italy", 2.84, 436);
                goods[3] = new Goods(542123874, "Reese's chocolate", "USA", 7.34, 253);
                goods[4] = new Goods(84456717, "Sport Ritter", "Finland", 4.38, 207);
                Console.WriteLine(goods[i]);
            }
            Console.WriteLine("===================================");
            
            Console.WriteLine("The total cost of the batch of goods is: ");
            foreach (Goods a in goods)
            {
                Console.WriteLine(a.TotalBatchCost());
            }
            Console.WriteLine("========================================");
            Console.WriteLine("The new prices after we add 15% on the prices will be: ");

            foreach (Goods a in goods)
            {
                Console.WriteLine(a.IncreasePercentage());
            }
            Console.WriteLine("=======================================");


            
            // Binary Serialize
            Stream stream = File.Open("goodsData.dat", FileMode.Create);           
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(stream, goods);
            stream.Close();

            goods = null;
            stream = File.Open("GoodsData.dat", FileMode.Open);
            bf = new BinaryFormatter();
            goods = (Goods[])bf.Deserialize(stream);
            foreach (Goods a in goods)
            {
                Console.WriteLine(a.ToString());
            }
            stream.Close();
            

            // The Xml Serialization & Deserialization
            Console.WriteLine("=================================");
            Console.WriteLine("The Xml Serialization is lready done.");

            using (Stream fs = new FileStream(@"C:\Users\Public\XmlGoodsData.xml", FileMode.Create, FileAccess.Write))
            {
                XmlSerializer serializer2 = new XmlSerializer(typeof(Goods[]));
                serializer2.Serialize(fs, goods);
            }
            goods = null;
            XmlSerializer serializer3 = new XmlSerializer(typeof(Goods[]));
            using(FileStream fs2= File.OpenRead(@"C:\Users\Public\XmlGoodsData.xml"))
            {
                goods = (Goods[])serializer3.Deserialize(fs2);
            }
         
            
            Console.WriteLine("===============================");
            Console.WriteLine("Json Serialize & Deserialize is done.");

            // JSON Serializing
            string filename = @"C:\Users\Public\JsonGoodsData.xml";
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(goods);
            if(System.IO.File.Exists(filename)== false)
            {
                System.IO.File.WriteAllText(filename, json);
            }
            else
            {
                System.IO.File.Delete(filename);
                System.IO.File.WriteAllText(filename, json);
            }

            Goods[] c2 = Newtonsoft.Json.JsonConvert.DeserializeObject<Goods[]>(json);

            Console.ReadLine();
        }
    }
}
