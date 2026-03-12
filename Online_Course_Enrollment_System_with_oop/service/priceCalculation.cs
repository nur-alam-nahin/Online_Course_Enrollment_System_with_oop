using Online_Course_Enrollment_System_with_oop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Course_Enrollment_System_with_oop.service
{
    abstract class priceCalculation
    {
        protected Course _course;

        protected priceCalculation(Course course)
        {
            _course = course;
        }

        public abstract double calculateFinalPrice();

    }
}
