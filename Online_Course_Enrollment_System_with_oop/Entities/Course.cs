using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Course_Enrollment_System_with_oop.Entities
{
    class Course
    {
        private string _title;
        private double _baseFee;
        private double _charge;
        private CourseType _CourseType;

        public Course(string title, double baseFee , CourseType CourseType)
        {
            _title = title;
            _baseFee = baseFee;
            _CourseType = CourseType;
        }


        public string getTitle()
        {
            return _title;
        }

        public double getBaseFee()
        {
            return _baseFee;
        }

        public CourseType GetCourse()
        {
            return _CourseType;
        }

        public void setCharge(double charge)
        {
            _charge = charge;
        }

        public double getCharge()
        {
            return _charge;
        }

    }
}
