using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Repisoteries
{
    public class MusicianRepository :IRepository<Musician>
    {
        public void Add(Musician entity)
        {
            Context.Musicians.Add(entity);
        }
        public void Delete(int ID)
        {
            Context.Musicians.RemoveAt(ID);
        }
        public List<Musician> GetAll()
        {
            return Context.Musicians;
        }
        public Musician GetByID(int ID)
        {
            return Context.Musicians[ID];
        }
        public void Update(int ID, Musician entity)
        {
            Context.Musicians.Insert(ID, entity);
        }
    }
}
