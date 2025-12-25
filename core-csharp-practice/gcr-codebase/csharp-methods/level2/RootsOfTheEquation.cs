using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.level2
{
    internal class RootsOfTheEquation
    {
        public static void Roots() {
            //getting input from user
            Console.Write("Enter value of a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter value of b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter value of c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            //Calling the methods
            double[] rootsArr = FindRoots(a, b, c);

            if (rootsArr.Length == 0){
                Console.WriteLine("No real roots exist.");
            }
            else if (rootsArr.Length == 1){
                Console.WriteLine("Only one root exists: " + rootsArr[0]);
            }
            else{
                Console.WriteLine("Root 1 = " + rootsArr[0]);
                Console.WriteLine("Root 2 = " + rootsArr[1]);
            }
        }



        //Method to find roots of quadratic equation
        public static double[] FindRoots(double a, double b, double c) { 
            double del = Math.Pow(b, 2) - 4 * a * c;

            if (del < 0){
                return new double[0];
            }
            if (del == 0){
                double root = -b / (2 * a);
                return new double[] { root };
            }
            double sqrtDel = Math.Sqrt(del);
            double r1 = (-b + sqrtDel) / (2 * a);
            double r2 = (-b - sqrtDel) / (2 * a);

            return new double[] { r1, r2 };
        }
    }
}
