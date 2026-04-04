using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.BuiltIn.level2
{
    internal class Palindrome
    {
        public static void IsPalindrome() {
            string inputString = GetInputFromUser();
            bool isPalindromeCheck = PalindromeCheck(inputString);
            ResultDisplay(inputString, isPalindromeCheck);
        }



        //Method to take input from the user
        static string GetInputFromUser(){
            Console.Write("Enter a string: ");
            return Console.ReadLine();
        }


        //Method to check if the string is a palindrome
        static bool PalindromeCheck(string inputString){
            int leftSide = 0;
            int rightSide = inputString.Length - 1;

            while (leftSide < rightSide){
                if (inputString[leftSide] != inputString[rightSide])
                    return false;

                leftSide++;
                rightSide--;
            }

            return true;
        }

        //Method to display the result
        static void ResultDisplay(string text, bool isPalindrome){
            if (isPalindrome) Console.WriteLine($"\"{text}\" is a Palindrome.");
            else Console.WriteLine($"\"{text}\" is NOT a Palindrome.");
        }
    }
}
