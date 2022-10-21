using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL.Services
{
    public class MusicianServices :Musician
    {
        private IDataContext<Student> _dataContext;

        public MusicianServices( IDataContext<Student> dataContext)
        {
            //_dataContext = new DataContext<ExchangeRate>(path);
            _dataContext = dataContext;

        }

        public CurrentMusician Musician
        {
            get
            {
                try
                {

                    Student er = _dataContext.GetData();
                    return new CurrentMusician() { FirstName = er.FirstName, LastName = er.LastName, Year = er.Year, Gender = er.Gender, ResidenceLocation = er.ResidenceLocation, DormStudent = er.DormStudent };
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
                    Student er = new Student() { FirstName = value.FirstName, LastName = value.LastName, Year = value.Year, IDCard = value.KindOfMusic , Gender = value.Gender, ResidenceLocation = value.ResidenceLocation, DormStudent = value.DormStudent };
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
