using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.level2
{
    internal class Factors
    {
        public static void FactorsOps() {
            //getting input from user
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Method calls
            int[] factorsArr = FindFactors(num);
            int sumOfFactors = FindSum(factorsArr);
            long productOfFactors = FindProduct(factorsArr);
            double sumOfSqs = FindSumOfSquares(factorsArr);


            Console.WriteLine("Factors are:");
            for(int i = 0; i < factorsArr.Length; i++){
                Console.WriteLine(factorsArr[i] + " ");
            }

            Console.WriteLine("Sum of factors = " + sumOfFactors);
            Console.WriteLine("Product of factors = " + productOfFactors);
            Console.WriteLine("Sum of squares of factors = " + sumOfSqs);
        }


        //Method to find factors
        public static int[] FindFactors(int num){
            int counter = 0;

            for (int i = 1; i <= num; i++){
                if (num % i == 0){
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

        //Method to find sum
        public static int FindSum(int[] factorsArr)
        {
            int sumOfFactors = 0;
            for(int i = 0; i < factorsArr.Length; i++){
                sumOfFactors += factorsArr[i];
            }
            return sumOfFactors;
        }

        //Method to find product
        public static long FindProduct(int[] factors)
        {
            long productOfFactors = 1;
            for(int i = 0; i < factors.Length; i++){
                productOfFactors *= factors[i];
            }
            return productOfFactors;
        }

        // Method to find sum of squares
        public static double FindSumOfSquares(int[] factorsArr){
            double sumOfSquares = 0;
            for(int i = 0; i < factorsArr.Length; i++){
                sumOfSquares += Math.Pow(factorsArr[i], 2);
            }
            return sumOfSquares;
        }
    }
}
