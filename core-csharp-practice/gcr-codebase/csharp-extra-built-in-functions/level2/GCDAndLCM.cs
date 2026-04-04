using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.BuiltIn.level2
{
    internal class GCDAndLCM
    {
        public static void GCDandLCM()
        {
            //Getting input from the user
            Console.Write("Enter first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int gcdInteger = GCDCalculate(number1, number2);
            int lcmValue = LCMCalculate(number1, number2, gcdInteger);

            Console.WriteLine($"GCD of {number1} and {number2} is: {gcdInteger}");
            Console.WriteLine($"LCM of {number1} and {number2} is: {lcmValue}");
        }



        // Function to calculate GCD using Euclidean Algorithm
        public static int GCDCalculate(int num1, int num2){

            while(num2 != 0){
                int remainder = num1%num2;
                num1 = num2;
                num2 = remainder;
            }


            return Math.Abs(num1);
        }

        // Function to calculate LCM using GCD
        static int LCMCalculate(int num1, int num2, int gcd){

            return Math.Abs(num1 * num2)/gcd;

        }
    }
}
