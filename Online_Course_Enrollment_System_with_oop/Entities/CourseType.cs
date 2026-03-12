using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Course_Enrollment_System_with_oop.Entities
{
    class CourseType
    {
        private string _courseType;

        public CourseType(string courseType)
        {
            _courseType = courseType;
        }

        public string getCourseType()
        {
            return _courseType;
        }
    }
}
