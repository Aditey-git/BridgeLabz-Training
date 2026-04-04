using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.level2
{
    internal class NaturalNumbers
    {
        public static void NaturalNumbersSum() {
            //Getting user input
            Console.Write("Enter a natural number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num <= 0){
                Console.WriteLine("Not a natural number");
                return;
            }

            //Calling the methods
            int recursionSum = RecursionSumFind(num);
            int formulaSum = FormulaSumFind(num);

            Console.WriteLine("Sum using recursion = " + recursionSum);
            Console.WriteLine("Sum using formula = " + formulaSum);

            //Comapring the results
            if (recursionSum == formulaSum){
                Console.WriteLine("Both sums are equal");
            }
            else{
                Console.WriteLine("Both sums are not equal");
            }
        }

        // Method to find sum using recursion
        public static int RecursionSumFind(int num){
            if (num == 0) return 0;
            return num + RecursionSumFind(num - 1);
        }

        // Method to find sum using formula
        public static int FormulaSumFind(int num){
            return num * (num + 1) / 2;
        }
    }
}
