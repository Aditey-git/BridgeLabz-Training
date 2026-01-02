using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.Constructor_Instance.level1
{
    internal class Course
    {
        //Attributes
        public string courseName;
        public int duration;    
        public double fee;

        //Class variable (common for all courses)
        public static string NameOfInstitute = "BridgeLabz";

        // Constructor
        public Course(string courseName, int duration, double fee)
        {
            this.courseName = courseName;
            this.duration = duration;
            this.fee = fee;
        }

        // Instance method to display course details
        public void CourseDetailsDisplay()
        {
            Console.WriteLine($"Institute Name: {NameOfInstitute}");
            Console.WriteLine($"Course Name: {courseName}");
            Console.WriteLine($"Duration: {duration} months");
            Console.WriteLine($"Fee: ₹{fee}");
        }


        // Class method to update institute name
        public static void UpdateInstituteName(string newInstituteName)
        {
            NameOfInstitute = newInstituteName;
        }

        public static void CourseManagement()
        {
            Course course1 = new Course("C# Full Stack", 6, 65000);
            Course course2 = new Course("Python Gen AI", 5, 55000);

            Course.UpdateInstituteName("BridgeLabz Solutions");

            course1.CourseDetailsDisplay();
            course2.CourseDetailsDisplay();
        }
    }
}
