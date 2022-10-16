using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


namespace LabWork_3_in_Csharp
{
    // Class should be public to make the Xml serialization
    [Serializable()]
    public class Goods : ISerializable
    {
        private int code;
        private string name;
        private string manufactured;
        private double cost;
        private int quantity;

        // We should create this constructor in order to make the Xml Serialization
        public Goods() { }

        public Goods(int code, string name, string manufactured, double cost, int quantity)
        {
            this.code = code;
            this.name = name;
            this.manufactured = manufactured;
            this.cost = cost;
            this.quantity = quantity;
        }

        public int Code { get; set; }
        public string Name { get; set; }
        public string Manufactured { get; set; }
        public double Cost{ get; set; }
        public int Quantity { get; set; }

        // Calculate total cost of the batch
        public double TotalBatchCost()
        {
            double sum = 1.0;
            if(quantity >= 0)
            {
                sum = cost * quantity;
            }
            return sum;
        }

        // Increase total cost by 15%
        public double IncreasePercentage()
        {
            double resultt = 1.0;
            double costIncrease = 0.15;
            if(cost > 0)
            {
                resultt = cost + (cost * costIncrease);
            }
            return resultt;
        }

        public override string ToString()
        {
            return String.Format("The item code is: {0}, it's name is: {1}, " +
                "this item is Manufactured in {2}, it's price is: {3} " +
                " and the quantity in the stock is :{4}", code, name, manufactured, cost, quantity);
        }

        // Binary Serialization
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Code", code);
            info.AddValue("Name", name);
            info.AddValue("Manufactured", manufactured);
            info.AddValue("Cost", cost);
            info.AddValue("Quantity", quantity);
        }

        public Goods(SerializationInfo info, StreamingContext context)
        {
            code = (int)info.GetValue("Code", typeof(int));
            name = (string)info.GetValue("Name", typeof(string));
            manufactured = (string)info.GetValue("Manufactured", typeof(string));
            cost = (double)info.GetValue("Cost", typeof(double));
            quantity = (int)info.GetValue("Quantity", typeof(int));
        }


        
    }
}
