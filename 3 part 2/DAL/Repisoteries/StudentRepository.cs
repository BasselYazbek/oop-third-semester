using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Repisoteries
{
    public class StudentRepository : IRepository<Student>
    {
        public void Add(Student entity) { Context.Students.Add(entity); }
        public void Delete(int ID) { Context.Students.RemoveAt(ID); }

        public List<Student> GetAll() { return Context.Students; }
        public Student GetByID(int ID) { return Context.Students[ID]; }

        public void Update(int ID, Student entity) { Context.Students.Insert(ID, entity); }
    }
}
