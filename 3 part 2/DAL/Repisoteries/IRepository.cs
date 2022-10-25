using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repisoteries
{
    public interface IRepository<T> where T :class
    {
        void Add(T entity);
        T GetByID(int ID);
        List<T> GetAll();
        void Delete(int ID);
        void Update(int ID, T entity);
    }
}
