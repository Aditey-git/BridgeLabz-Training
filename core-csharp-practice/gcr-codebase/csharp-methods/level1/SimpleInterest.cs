using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods
{
    internal class SimpleInterest
    {
        public static void SI() {
            //Getting input from the user
            Console.Write("Enter Principal: ");
            double princ = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Rate of Interest: ");
            double rateOfInterest = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Time: ");
            double timeInYears = Convert.ToDouble(Console.ReadLine());

            //Calling the method
            double SI = siCal(princ, rateOfInterest, timeInYears);

            Console.WriteLine($"The Simple Interest is {SI}");
        }

        public static double siCal(double princ, double rateOfInterest, double timeInYears) { //Function for calculating Simple Interest
            return (princ * rateOfInterest * timeInYears) / 100;
        }
    }
}
