using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.level3
{
    internal class NumberChecker2
    {
        public static void NumberCheckerFn() {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            //Method calling
            int countOfDigits = CountOfDigits(num);
            int[] digitsArr = StoringDigits(num);
            int addition = digitsSum(digitsArr);
            double SumOfSquares = squaresSum(digitsArr);
            bool isHarshadNum = HarshadNumberCheck(num, digitsArr);
            int[,] freq = DigitFrequencyFind(digitsArr);
           
            Console.WriteLine("Count of digits = " + countOfDigits);

            Console.Write("Digits are: ");
            for (int i = 0; i < digitsArr.Length; i++){
                Console.Write(digitsArr[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Sum of digits = " + addition);

            Console.WriteLine("Sum of squares of digits = " + SumOfSquares);

            Console.WriteLine("Is Harshad Number: " + isHarshadNum);

            Console.WriteLine("Digit Frequency:");
            for (int i = 0; i < 10; i++){
                if (freq[i, 1] > 0){
                    Console.WriteLine("Digit " + freq[i, 0] + " occurs " + freq[i, 1] + " times");
                }
            }
        }


        //Method to find count of digits
        public static int CountOfDigits(int num){
            int countD = 0;
            int temporary = num;

            while (temporary != 0){
                countD++;
                temporary = temporary / 10;
            }

            return countD;
        }

        //Method to store digits in an array
        public static int[] StoringDigits(int num){
            int countD = CountOfDigits(num);
            int[] digitsArr = new int[countD];
            int index = 0;

            while (num != 0)
            {
                digitsArr[index] = num % 10;
                num = num / 10;
                index++;
            }

            return digitsArr;
        }

        //Method to find sum of digits
        public static int digitsSum(int[] digitsArr){
            int sumDigit = 0;

            for(int i = 0; i < digitsArr.Length; i++){
                sumDigit += digitsArr[i];
            }

            return sumDigit;
        }

        //Method to find sum of squares of digits
        public static double squaresSum(int[] digitsArr){
            double sum = 0;

            for (int i = 0; i < digitsArr.Length; i++){
                sum += Math.Pow(digitsArr[i], 2);
            }

            return sum;
        }

        //Method to check Harshad number
        public static bool HarshadNumberCheck(int num, int[] digitsArr)
        {
            int sum = digitsSum(digitsArr);

            return num % sum == 0;
        }

        //Method to find frequency of each digit
        public static int[,] DigitFrequencyFind(int[] digitsArr){
            int[,] freq = new int[10, 2];



            for(int i = 0; i < 10; i++){
                freq[i, 0] = i;
                freq[i, 1] = 0;
            }

            for (int i = 0; i < digitsArr.Length; i++){
                freq[digitsArr[i], 1]++;
            }

            return freq;
        }
    }
}
