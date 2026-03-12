using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Course_Enrollment_System_with_oop
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Entities.Course> courses = new List<Entities.Course>();
            int num;

            do
            {
                Console.WriteLine("----- Online_Course_Enrollment -----");
                Console.WriteLine("1. Add course ");
                Console.WriteLine("2. view course");
                Console.WriteLine("3. Exite");
                Console.Write("Chose any number : ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num > 0 && num < 3)
                {
                    switch (num)
                    {
                        case 1:
                            Console.Write("Course title = ");
                            string title = Console.ReadLine();

                            Console.Write("Base fee = ");
                            double baseFee = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Course type (Live/Recorded) =  ");
                            string crType = Console.ReadLine();

                            

                            Entities.CourseType courseType = new Entities.CourseType(crType);
                            Entities.Course course = new Entities.Course(title, baseFee, courseType);
                            if (crType == "Live")
                            {
                                
                                Console.Write("Charge = ");
                                double charge = Convert.ToDouble(Console.ReadLine());
                                course.setCharge(charge);
                            }

                            courses.Add(course);
                            break;


                        case 2:

                            foreach (var c in courses)
                            {
                                service.priceCalculation calculation;
                                if (c.GetCourse().getCourseType() == "Live")
                                {
                                    calculation = new service.LiveCourseFee(c);
                                }
                                else
                                {
                                    calculation = new service.RecordedCourseFee(c);
                                }

                                Console.WriteLine();
                                Console.WriteLine("Title = " + c.getTitle());
                                Console.WriteLine("Course Type = " + c.GetCourse().getCourseType() + " Course");
                                Console.WriteLine("Price = " + c.getBaseFee());
                                Console.WriteLine("Final price = " + calculation.calculateFinalPrice());

                            }
                            break;
                    }

                }
            } while (num != 3);
        }
    }
}
