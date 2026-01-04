using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.Inheritance
{
    internal class Course
    {
        public string NameOfCourse;
        public int TimeDuration; // in hours

        public Course(string NameOfCourse, int TimeDuration)
        {
            this.NameOfCourse = NameOfCourse;
            this.TimeDuration = TimeDuration;
        }

        public virtual void DetailsDisplay()
        {
            Console.WriteLine("Course Details:");
            Console.WriteLine($"Course Name : {NameOfCourse}");
            Console.WriteLine($"Duration    : {TimeDuration} hours");
        }
    }

    // Subclass: OnlineCourse
    class OnlineCourseSubclass : Course
    {
        public string CoursePlatform;
        public bool RecordedOrNot;

        public OnlineCourseSubclass(string NameOfCourse, int TimeDuration, string platformOfCourse, bool RecordedOrNot)
            : base(NameOfCourse, TimeDuration)
        {
            CoursePlatform = platformOfCourse;
            this.RecordedOrNot = RecordedOrNot;
        }

        public override void DetailsDisplay()
        {
            base.DetailsDisplay();
            Console.WriteLine("Online Course Details:");
            Console.WriteLine($"Platform    : {CoursePlatform}");
            Console.WriteLine($"Is Recorded : {RecordedOrNot}");
        }
    }

    // Subclass: PaidOnlineCourse (Multilevel)
    class PaidOnlineCourseSubclass : OnlineCourseSubclass
    {
        public double CourseFee;
        public double DiscountOnFee; 

        public PaidOnlineCourseSubclass(string NameOfCourse, int courseDuration, string coursePlatform, bool RecordedOrNot,
                                double fee, double discount)
            : base(NameOfCourse, courseDuration, coursePlatform, RecordedOrNot)
        {
            CourseFee = fee;
            DiscountOnFee = discount;
        }

        public override void DetailsDisplay()
        {
            base.DetailsDisplay();
            Console.WriteLine("Payment Details:");
            Console.WriteLine($"Course Fee : {CourseFee}");
            Console.WriteLine($"Discount  : {DiscountOnFee}%");
            Console.WriteLine($"Final Fee : {CourseFee - (CourseFee * DiscountOnFee / 100)}");
        }
    }


    class CourseManagement
    {
        static void CourseManage()
        {
            Course cor1 = new Course("Data Structures", 40);
            Course cor2 = new OnlineCourseSubclass("C# Fundamentals", 30, "Udemy", true);
            Course cor3 = new PaidOnlineCourseSubclass("ASP.NET Core", 45, "Coursera", true, 8000, 20);

            cor1.DetailsDisplay();
            Console.WriteLine();

            cor2.DetailsDisplay();
            Console.WriteLine();

            cor3.DetailsDisplay();
        }
    }
}
