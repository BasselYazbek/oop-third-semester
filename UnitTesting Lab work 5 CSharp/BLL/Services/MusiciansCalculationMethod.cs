/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL.Interfaces;

namespace BLL.Services
{
    public class MusiciansCalculationMethod : ICalculateMusicians
    {
        private IDataContext<CalculateMusicians> _dataContextMusician;

        public MusiciansCalculationMethod(IDataContext<CalculateMusicians> dataContextMusician)
        {
            _dataContextMusician = dataContextMusician;
        }

        public CurrentMusicians Musicians
        {
            get
            {
                try
                {
                    CalculateStudents er = _dataContextMusician.GetData();
                    return new CurrentMusicians { lastName = er.lastName, firstName = er.firstName, gender = er.gender, placeOfResidence = er.placeOfResidence, musicKind = er. };
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
                    CalculateStudents er = new CalculateStudents() { lastName = value.lastName, firstName = value.firstName, yearOfStudy = value.yearOfStudy, studentID = value.studentID, gender = value.gender, placeOfResidence = value.placeOfResidence, campusStudents = value.campusStudents };
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
*/