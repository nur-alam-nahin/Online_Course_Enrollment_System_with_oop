using Online_Course_Enrollment_System_with_oop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Course_Enrollment_System_with_oop.service
{
    class LiveCourseFee : priceCalculation
    {
       
       

        public LiveCourseFee(Course course):base(course)
        {
           
        }
      

        public override double calculateFinalPrice()
        {
            
            return _course.getBaseFee() + _course.getCharge();
        }
    }
}
