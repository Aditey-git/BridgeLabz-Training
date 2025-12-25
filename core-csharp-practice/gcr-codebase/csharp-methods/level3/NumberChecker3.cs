using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.level3
{
    internal class NumberChecker3
    {
        public static void NumberChecker3fn() {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            //Method calls
            int digitCounter = digitsCount(num);
            int[] digitsArr = digitsStore(num);
            int[] reversedDigitsArr = DigitsReverse(digitsArr);
            bool Palindrome = PalindromeCheck(digitsArr);
            bool Duck = DuckNumberCheck(digitsArr);

            Console.WriteLine("Count of digits = " + digitCounter);

            Console.Write("Digits: ");
            for (int i = 0; i < digitsArr.Length; i++){
                Console.Write(digitsArr[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Reversed Digits: ");
            for (int i = 0; i < reversedDigitsArr.Length; i++){
                Console.Write(reversedDigitsArr[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Is Palindrome Number: " + Palindrome);
            Console.WriteLine("Is Duck Number: " + Duck);
        }

        //Method to find count of digits
        public static int digitsCount(int num){
            int counter = 0;
            int temporary = num;

            while (temporary != 0){
                counter++;
                temporary = temporary / 10;
            }

            return counter;
        }

        //Method to store digits in an array
        public static int[] digitsStore(int num){
            int counter = digitsCount(num);
            int[] digitsArr = new int[counter];
            int index = 0;

            while (num != 0){
                digitsArr[index] = num % 10;
                num = num / 10;
                index++;
            }

            return digitsArr;
        }

        //Method to reverse the digits array
        public static int[] DigitsReverse(int[] digitsArr){
            int[] reversedArr = new int[digitsArr.Length];

            for (int i = 0; i < digitsArr.Length; i++){
                reversedArr[i] = digitsArr[digitsArr.Length - 1 - i];
            }

            return reversedArr;
        }

        //Method to compare two arrays
        public static bool CompareArrays(int[] array1, int[] array2){
            if (array1.Length != array2.Length)
                return false;

            for (int i = 0; i < array1.Length; i++){
                if (array1[i] != array2[i])
                    return false;
            }

            return true;
        }

        //Method to check Palindrome Number
        public static bool PalindromeCheck(int[] digitsArr){
            int[] reversedArr = DigitsReverse(digitsArr);
            return CompareArrays(digitsArr, reversedArr);
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



        //Method to check Prime Number
        public static bool PrimeNumberCheck(int num){
            if (num <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++){
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        //Method to check Neon Number
        public static bool NeonNumberCheck(int num){
            int sq = num * num;
            int sum = 0;

            while (sq != 0){
                sum += sq % 10;
                sq = sq / 10;
            }

            return sum == num;
        }

        //Method to check Spy Number
        public static bool SpyNumberCheck(int num){
            int sum = 0;
            int productOfNumber = 1;

            while (num != 0){
                int digit = num % 10;
                sum += digit;
                productOfNumber *= digit;
                num = num / 10;
            }

            return sum == productOfNumber;
        }

        //Method to check Automorphic Number
        public static bool AutomorphicNumberCheck(int num){
            int sq = num * num;
            int temporary = num;

            while (temporary != 0){
                if (temporary % 10 != sq % 10)
                    return false;

                temporary = temporary / 10;
                sq = sq / 10;
            }

            return true;
        }

        //Method to check Buzz Number
        public static bool BuzzNumberCheck(int num){
            return (num % 7 == 0 || num % 10 == 7);
        }



        // Method to find factors of a number
        public static int[] FindFactors(int num){
            int counter = 0;
            for(int i = 1; i <= num; i++){
                if(num % i == 0){
                    counter++;
                }
            }

            int[] factorsArr = new int[counter];
            int index = 0;

            for(int i = 1; i <= num; i++){
                if(num % i == 0){
                    factorsArr[index] = i;
                    index++;
                }
            }

            return factorsArr;

        }

        //Method to find greatest factor
        public static int GreatestFactor(int[] factorsArr){
            int greatestNumber = factorsArr[0];

            for (int i = 1; i < factorsArr.Length; i++){
                if (factorsArr[i] > greatestNumber){
                    greatestNumber = factorsArr[i];
                }
            }

            return greatestNumber;

        }

        //Method to find sum of factors
        public static int SumOfFactors(int[] factorsArr){
            int sum = 0;

            for(int i = 0; i < factorsArr.Length; i++){
                sum += factorsArr[i];
            }

            return sum;
        }

        //Method to find product of factors
        public static long ProductOfFactors(int[] factorsArr){
            long pro = 1;

            for(int i = 0; i < factorsArr.Length; i++){
                pro *= factorsArr[i];
            }

            return pro;

        }

        //Method to find product of cube of factors
        public static double ProductOfCubeOfFactors(int[] factors){
            double product = 1;

            for (int i = 0; i < factors.Length; i++){
                product *= Math.Pow(factors[i], 3);
            }

            return product;
        }

        // f. Method to check Perfect Number
        public static bool PerfectNumberCheck(int num){
            int addition = 0;

            for (int i = 1; i <= num / 2; i++){
                if (num % i == 0){
                    addition += i;
                }
            }

            return addition == num;

        }



    }
}
