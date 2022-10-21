
using System;
using DAL;

namespace BLL
{
    public class ReadWriteService<T>:IDataReadWriteService<T>
    {
        private IDataContext<T> _dataContext;
        public ReadWriteService(/*string path*/ IDataContext<T> dataContext)
        {
            //_dataContext = new DataContext<ExchangeRate>(path);
            _dataContext = dataContext;
        }

        public T ReadData()
        {
            return _dataContext.GetData();
        }

        public void WriteData(T data)
        {
            _dataContext.SetData(data);
        }

    }
}
