using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.level3
{
    internal class Euclidean
    {
        public static void EuclideanDistance() {
            //Getting input from the user
            Console.Write("Enter x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            //Calling Methods
            double dist = EuclideanDistanceFind(x1, y1, x2, y2);
            double[] lineArr = LineEquationFind(x1, y1, x2, y2);

            Console.WriteLine("Euclidean Distance = " + dist);
            Console.WriteLine("Equation of line: y = " + lineArr[0] + "x + " + lineArr[1]);
        }


        //Method to find Euclidean distance
        public static double EuclideanDistanceFind(double x1, double y1, double x2, double y2){
            double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            return dist;

        }

        //Method to find slope (m) and y-intercept (b)
        public static double[] LineEquationFind(double x1, double y1, double x2, double y2){
            double m = (y2 - y1) / (x2 - x1);   
            double b = y1 - m * x1;             

            return new double[] { m, b };

        }
    }
}
