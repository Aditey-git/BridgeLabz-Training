using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Summary:-
This MathOperations utility class provides multiple mathematical functionalities using separate static methods.
It allows the user to choose operations like factorial calculation, prime number checking, GCD of two numbers, and finding the nth Fibonacci number through a menu-driven approach.
Each operation is handled by a dedicated method, ensuring modular and reusable code.
The factorial method handles negative input by displaying a warning message.
The prime check efficiently verifies primality using iteration up to the square root of the number.
The GCD method uses the Euclidean algorithm and supports negative values.
The Fibonacci method computes the sequence iteratively while handling base cases like 0 and 1.
    */

namespace BridgeLabzTraining.Scenario_Based.MathematicalOperations
{
    internal class MathOperations
    {


        //Method for calling all other methods
        public static void OperationsOfMath()
        {
            Console.WriteLine("Enter 1. to find Factorial");
            Console.WriteLine("Enter 2. for Prime Check");
            Console.WriteLine("Enter 3. to find GCD");
            Console.WriteLine("Enter 4. to find nth fibonacci number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the number:");
                    int numberInput = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Factorial of the number: " + FindFactorial(numberInput));
                    break;
                case 2:
                    Console.WriteLine("Enter the number:");
                    int primeInput = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The number is prime: " + IsPrimeCheck(primeInput));
                    break;
                case 3:
                    Console.WriteLine("Enter the first number:");
                    int gcdInput1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the second number:");
                    int gcdInput2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The GCD of the number is:" + FindGCD(gcdInput1, gcdInput2));
                    break;
                 case 4:
                    Console.WriteLine("Enter the number:");
                    int fibonacciInput = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The nth fibonacci is: " + FindFibonacci(fibonacciInput));
                    break;
            }
        }

        //Method to find Factorial of a number
        public static int FindFactorial(int numberInput)
        {
            if (numberInput < 0)
            {
                Console.WriteLine("Number entered is negative!");
                return 0;
            }

            int fact = 1;

            for(int i = 1; i <= numberInput; i++)
            {
                fact *= i;
            }

            return fact;
        }


        //Method to Check if a number is prime
        public static bool IsPrimeCheck(int numberInput)
        {
            if (numberInput <= 1)
            {
                return false;
            }

            for(int i = 2; i <= Math.Sqrt(numberInput); i++)
            {
                if(numberInput % i == 0)
                {
                    return false;
                }
            }

            return true;
        }


        //Method to Find GCD of two numbers
        public static int FindGCD(int num1, int num2)
        {

            num1 = Math.Abs(num1);
            num2 = Math.Abs(num2);

            while (num2 != 0)
            {
                int rem = num1 % num2;
                num1 = num2;
                num2 = rem;
            }
            return num1;

        }

        //Method to Find nth Fibonacci number
        public static int FindFibonacci(int numberInput)
        {

            if (numberInput < 0)
            {
                Console.WriteLine("Try Again with positive number");
            }

            if (numberInput == 0) return 0;
            if (numberInput == 1) return 1;

            int first = 0, second = 1, current = 0;
            for (int i = 2; i <= numberInput; i++)
            {
                current = first + second;
                first = second;
                second = current;
            }

            return current;

        }

    }
}
