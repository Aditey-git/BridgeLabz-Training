using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.BuiltIn.level2
{
    internal class Fibonacci
    {
        public static void FibonacciNumber() {
            Console.Write("Enter the number: ");
            int termsInt = Convert.ToInt32(Console.ReadLine());

            FibonacciFind(termsInt);
        }


        //Method to calculate and print Fibonacci series
        static void FibonacciFind(int num){
            if(num <= 0){
                Console.WriteLine("Enter a positive number.");
                return;
            }

            int firstNum = 0, secondNum = 1;

            Console.WriteLine("Fibonacci Sequence:");

            for (int i = 1; i <= num; i++){
                Console.Write(firstNum + " ");

                int nextNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = nextNum;
            }
        }
    }
}
