using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Entities;

namespace DAL.Repisoteries
{
    public class PilotRepository : IRepository<Pilot>
    {
        public void Add(Pilot entity)
        {
            Context.Pilots.Add(entity);
        }
        public void Delete(int ID)
        {
            Context.Pilots.RemoveAt(ID);
        }
        public List<Pilot> GetAll()
        {
            return Context.Pilots;
        }
        public Pilot GetByID(int ID)
        {
            return Context.Pilots[ID];
        }
        public void Update(int ID, Pilot entity)
        {
            Context.Pilots.Insert(ID, entity);
        }
    }
}
