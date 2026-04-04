using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.level2
{
    internal class PositiveAndNegative
    {
        public static void PositiveAndNegativeFn() {
            int[] numArr = new int[5];

            //Getting input from user
            Console.Write("Enter numbers:");
            for (int i = 0; i < numArr.Length; i++){
                numArr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Uisng and calling Methods
            for(int i = 0; i < numArr.Length; i++){
                if(PositiveCheck(numArr[i])){
                    Console.Write(numArr[i] + " is Positive and ");
                    if (EvenCheck(numArr[i])) Console.WriteLine("Even");
                    else Console.WriteLine("Odd");
                }
                else{
                    Console.WriteLine(numArr[i] + " is Negative");
                }
            }
            int answer = ComparingFunction(numArr[0], numArr[numArr.Length - 1]);

            if (answer == 1) Console.WriteLine("First element is greater than last element");
            else if (answer == 0) Console.WriteLine("First and last elements are equal");
            else Console.WriteLine("First element is less than last element");
        
        }

        public static int ComparingFunction(int num1, int num2){
            if (num1 > num2) return 1;
            else if (num1 == num2) return 0;
            else return -1;
        }



        //Method to check positive or negative
        public static bool PositiveCheck(int num){
            if (num >= 0) return true;
            return false;
        }

        //Method to check even or odd
        public static bool EvenCheck(int num){
            if(num % 2 == 0) return true;
            return false;
        }
    }
}
