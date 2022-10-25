using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace DAL.Providers
{
    public class XMLDataProvider<T> : IDataProvider<T>
    {
        public void Serialize(T data, string nameOfFile)
        {
            using (FileStream stream = new FileStream(nameOfFile, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                try
                {
                    xmlSerializer.Serialize(stream, data);
                }
                catch (Exception msg)
                {
                    throw msg;
                }
            }
        }

        public T Deserialize(string nameOfFile)
        {
            T deserialData;
            using (FileStream stream = new FileStream(nameOfFile, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                try
                {
                    deserialData = (T)xmlSerializer.Deserialize(stream);
                }

                catch (Exception msg)
                {
                    throw msg;
                }

            }
            return deserialData;
        }
    }
}
