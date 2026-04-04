using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.level1
{
    internal class AreaOfCircle
    {
        // Attribute
        public double radius;
        public static void AreaOfCircleImplement()
        {
            //Object creation
            AreaOfCircle cir = new AreaOfCircle();

            //User Input
            Console.Write("Enter radius of circle: ");
            cir.radius = Convert.ToDouble(Console.ReadLine());

            //Display area and circumference
            cir.AreaCalculate();
            cir.CircumferenceCalculate();
        }

        // Method to calculate and display area
        public void AreaCalculate()
        {
            double areaOfCircle = Math.PI * radius * radius;
            Console.WriteLine("Area of the Circle: " + areaOfCircle);
        }

        // Method to calculate and display circumference
        public void CircumferenceCalculate(){
            double circumferenceOfCircle = 2 * Math.PI * radius;
            Console.WriteLine("Circumference of the Circle: " + circumferenceOfCircle);
        }

    }
}
