/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/
namespace DataProviderContract
{
    public interface IDataProvider<T>
    {
        //void Write(T data, string connection);
        T Read(string connection);
        void Write<T>(T data, string connectionString);
    }
}
