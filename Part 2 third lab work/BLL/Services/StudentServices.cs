using System;
using DAL;
using System.IO;
using System.Collections.Generic;


namespace BLL
{
    public class StudentServices : Students
    {
        private IDataContext<Student> _dataContext;

        public StudentServices(/*string path*/ IDataContext<Student> dataContext)
        {
            //_dataContext = new DataContext<ExchangeRate>(path);
            _dataContext = dataContext;
            
        }
        
        public CurrentStudent Students
        {
            get
            {
                try
                {

                    Student er = _dataContext.GetData();
                    return new CurrentStudent() { FirstName = er.FirstName, LastName = er.LastName, Year = er.Year, IDCard = er.IDCard, Gender = er.Gender, ResidenceLocation = er.ResidenceLocation, DormStudent = er.DormStudent };
                }
                catch (Exception ex)
                {
                    throw new StudentException(ex.Message);
                }
            }
            set
            {
                try
                {
                    Student er = new Student() { FirstName = value.FirstName, LastName = value.LastName, Year = value.Year, IDCard = value.IDCard, Gender = value.Gender, ResidenceLocation = value.ResidenceLocation, DormStudent = value.DormStudent};
                    _dataContext.SetData(er);
                }
                catch (Exception ex)
                {
                    throw new StudentException(ex.Message);
                }
            }
        }

    }
}
