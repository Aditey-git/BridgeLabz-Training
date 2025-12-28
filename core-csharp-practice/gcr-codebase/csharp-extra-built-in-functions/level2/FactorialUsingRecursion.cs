using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.BuiltIn.level2
{
    internal class FactorialUsingRecursion
    {
        public static void FactoriaRecursion() {
            int numberInput = GetInputString();
            long resultNumber = FactorialCalculate(numberInput);
            ResultDisplay(numberInput, resultNumber);
        }


        //Method to take input from the user
        public static int GetInputString(){
            Console.Write("Enter positive integer: ");
            return Convert.ToInt32(Console.ReadLine());
        }


        //Method to calculate factorial
        static long FactorialCalculate(int num){
            if(num < 0) return -1;

            if(num == 0 || num == 1) return 1;

            return num * FactorialCalculate(num - 1);
        }

        //Method to display the result
        static void ResultDisplay(int number, long result){
            if (result == -1) Console.WriteLine("Factorial is not defined for negative numbers.");
            else Console.WriteLine($"Factorial of {number} is {result}");
        }
    }
}
