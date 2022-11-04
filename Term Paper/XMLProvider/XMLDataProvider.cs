using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProviderContract;
using System.IO;
using System.Xml.Serialization;

namespace XMLProvider
{
    public class XMLDataProvider<T> : IDataProvider<T>
    {
        public T Read(string connection)
        {
            T data;
            using (FileStream fs = new FileStream(connection, FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(T));
                try
                {
                    data = (T)formatter.Deserialize(fs);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return data;
        }
        
        public void Write(T data, string connection)
        {
            using (FileStream fs = new FileStream(connection, FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(data.GetType());
                try
                {
                    formatter.Serialize(fs, data);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void Write<T1>(T1 data, string connectionString)
        {
            throw new NotImplementedException();
        }
    }
}
