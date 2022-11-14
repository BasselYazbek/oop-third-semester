using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL.Interfaces;

namespace BLL.Services
{
    public class StudentsCalculationMethod : ICalculateStudents
    {
        private IDataContext<CalculateStudents> _dataContext;

        public StudentsCalculationMethod(IDataContext<CalculateStudents> dataContext)
        {
            _dataContext = dataContext;
        }

        public CurrentStudents Students
        {
            get
            {
                try
                {
                    CalculateStudents er = _dataContext.GetData();
                    return new CurrentStudents() { lastName = er.lastName, firstName = er.firstName, yearOfStudy = er.yearOfStudy, studentID = er.studentID, gender = er.gender, placeOfResidence = er.placeOfResidence, campusStudents = er.campusStudents };
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

        public int CalculateMethod()
        {
            int sum = 0;
            if (Students.yearOfStudy == 1 && Students.gender == "Female" || Students.gender == "female" && Students.campusStudents != "No")
            {
                sum++;
            }
            return sum;
        }
    }
}
