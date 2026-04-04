using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.level3
{
    internal class ColinearPoints
    {
        public static void CollinearPoints() {
            //Getting input from user
            Console.Write("Enter x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter x3: ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y3: ");
            double y3 = Convert.ToDouble(Console.ReadLine());



            //Calling Methods
            bool slope = CollinearUsingSlopeCheck(x1, y1, x2, y2, x3, y3);
            bool area = CollinearUsingAreaCheck(x1, y1, x2, y2, x3, y3);

            Console.WriteLine("\nUsing Slope Method: " +(slope ? "Points are Collinear" : "Points are NOT Collinear"));
            Console.WriteLine("Using Area Method: " + (area ? "Points are Collinear" : "Points are NOT Collinear"));
        }


        //Method to check collinearity using slope formula
        public static bool CollinearUsingSlopeCheck(double x1, double y1, double x2, double y2, double x3, double y3){

            double ABslope = (y2 - y1)/(x2 - x1);
            double BCslope = (y3 - y2)/(x3 - x2);
            double ACslope = (y3 - y1)/(x3 - x1);

            return (ABslope == BCslope && BCslope == ACslope);

        }

        //Method to check collinearity using area of triangle
        public static bool CollinearUsingAreaCheck(double x1, double y1, double x2, double y2, double x3, double y3){

            double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

            return area == 0;

        }
    }
}
