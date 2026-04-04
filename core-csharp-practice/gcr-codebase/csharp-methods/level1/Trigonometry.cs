using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods
{
    internal class Trigonometry
    {
        public static void TrigonometryFunctions() {
            //getting input from the user
            Console.Write("Enter angle: ");
            double ang = Convert.ToDouble(Console.ReadLine());

            double[] answer = FindTrigonometricFunctions(ang);//Calling the function

            Console.WriteLine("Sine value: " + answer[0]);
            Console.WriteLine("Cosine value: " + answer[1]);
            Console.WriteLine("Tangent value: " + answer[2]);
        }

        public static double[] FindTrigonometricFunctions(double ang)
        {
            //Doing all the calculations 

            double radians = ang * Math.PI / 180;
            double sine = Math.Sin(radians);
            double cosine = Math.Cos(radians);
            double tangent = Math.Tan(radians);

            return new double[] { sine, cosine, tangent };


        }
    }
}
