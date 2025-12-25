using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods
{
    internal class AtheleteRounds
    {
        public static void Rounds() {
            //getting input from the user
            Console.Write("Enter 1st side: ");
            double s1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter 2nd side: ");
            double s2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter 3rd side: ");
            double s3 = Convert.ToDouble(Console.ReadLine());

            //calling the method
            double rounds = RoundsCalculate(s1, s2, s3);

            Console.WriteLine("The total number of rounds is " + rounds);
        }

        public static double RoundsCalculate(double s1, double s2, double s3){
            double peri = s1 + s2 + s3;
            double dis = 5000; 
            double noOfRounds = dis / peri;
            return noOfRounds;
        }
    }
}
