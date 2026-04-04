using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.BuiltIn.level2
{
    internal class Calculator
    {
        public static void CalculatorMethod() {
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Choose an option (1–4): ");

            int option = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double resultAnswer = 0;

            switch (option){
                case 1:
                    resultAnswer = Addition(number1, number2);
                    break;
                case 2:
                    resultAnswer = Subtractraction(number1, number2);
                    break;
                case 3:
                    resultAnswer = Multiplication(number1, number2);
                    break;
                case 4:
                    if(number2 == 0){
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return;
                    }
                    resultAnswer = Divide(number1, number2);
                    break;
                default:
                    Console.WriteLine("Invalid operation choice.");
                    return;
            }

            Console.WriteLine("Result: " + resultAnswer);
        }


        //Addition Method
        public static double Addition(double num1, double num2){
            return num1 + num2;
        }

        //Subtraction Method
        public static double Subtractraction(double num1, double num2){
            return num1 - num2;
        }

        // Multiplication
        static double Multiplication(double num1, double num2){
            return num1 * num2;
        }

        // Division
        static double Divide(double num1, double num2){
            return num1 / num2;
        }
    }
}
