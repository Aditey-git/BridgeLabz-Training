using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.Extras
{
    internal class Palindrome
    {
        public static void PalindromeCheck() {
            //Getting input from the user
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            bool isPalindromeCheck = true;
            int leftSide = 0;
            int rightSide = inputString.Length - 1;

            //Palindrome check logic
            while(leftSide < rightSide){
                if(inputString[leftSide] != inputString[rightSide]){
                    isPalindromeCheck = false;
                    break;
                }
                leftSide++;
                rightSide--;
            }

            if(isPalindromeCheck) Console.WriteLine("The string is a Palindrome.");
            else Console.WriteLine("The string is NOT a Palindrome.");
        }
    }
}
