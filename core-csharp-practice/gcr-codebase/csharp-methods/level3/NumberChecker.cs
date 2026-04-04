using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.level3
{
    internal class NumberChecker
    {
        public static void NumberCheckerFn() {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                //Calling the Methods
                int digitCounting = CountNumOfDigits(num);
                int[] digitsArr = StoretheDigits(num);

                bool isDuckNum = DuckNumberCheck(digitsArr);
                bool isArmstrongNum = ArmstrongNumberCheck(num, digitsArr);
                int[] largestValuesNum = FindLargestAndSecondLargest(digitsArr);

                //Displaying results
                Console.WriteLine("Count of digits = " + digitCounting);
                Console.Write("Digits are: ");
                for (int i = 0; i < digitsArr.Length; i++){
                    Console.Write(digitsArr[i] + " ");
                }


                Console.WriteLine();
                Console.WriteLine("Is Duck Number: " + isDuckNum);
                Console.WriteLine("Is Armstrong Number: " + isArmstrongNum);
                Console.WriteLine("Largest digit = " + largestValuesNum[0]);
                Console.WriteLine("Second largest digit = " + largestValuesNum[1]);
        }



        //Method to find count of digits
        public static int CountNumOfDigits(int num){
            int digitCount = 0;
            int temporary = num;

            while (temporary != 0){
                digitCount++;
                temporary = temporary / 10;
            }

            return digitCount;
        }

        //Method to store digits in an array
        public static int[] StoretheDigits(int num){
            int countDigits = CountNumOfDigits(num);
            int[] digitsArr = new int[countDigits];
            int index = 0;

            while (num != 0){
                digitsArr[index] = num % 10;
                num = num / 10;
                index++;
            }

            return digitsArr;
        }

        //Method to check Duck Number
        public static bool DuckNumberCheck(int[] digitsArr){
            for (int i = 0; i < digitsArr.Length; i++){
                if (digitsArr[i] != 0){
                    return true;
                }
            }
            return false;
        }

        //Method to check Armstrong Number
        public static bool ArmstrongNumberCheck(int num, int[] digitsArr){
            int pow = digitsArr.Length;
            int addition = 0;

            for (int i = 0; i < digitsArr.Length; i++){
                addition += (int)Math.Pow(digitsArr[i], pow);
            }

            return addition == num;
        }

        //Method to find largest and second largest digits


        public static int[] FindLargestAndSecondLargest(int[] digitsArr){
            int largestDigit = Int32.MinValue;
            int secondLargestDigit = Int32.MinValue;

            for (int i = 0; i < digitsArr.Length; i++){
                if (digitsArr[i] > largestDigit){
                    secondLargestDigit = largestDigit;
                    largestDigit = digitsArr[i];
                }
                else if(digitsArr[i] > secondLargestDigit && digitsArr[i] != largestDigit){
                    secondLargestDigit = digitsArr[i];
                }
            }

            return new int[] { largestDigit, secondLargestDigit };
        }

    }
}
