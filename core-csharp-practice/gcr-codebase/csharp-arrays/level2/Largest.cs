using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Arrays.level2
{
    internal class Largest
    {
        public static void LargestFind() {
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int maxDigit = 10;                 
            int[] digits = new int[maxDigit]; 
            int index = 0;                     

            // Storing Digits of the number 
            while(num != 0){
                digits[index] = num%10;  
                num = num/10;         
                index++;

                if(index == maxDigit){
                    break; 
                }
            }

            int largestDigit = 0;
            int secondLargestDigit = 0;

            // Finding the result
            for(int i = 0;i < index;i++){
                if(digits[i] > largestDigit){
                    secondLargestDigit = largestDigit;
                    largestDigit = digits[i];
                }
                else if(secondLargestDigit < digits[i] && digits[i] != largestDigit){
                    secondLargestDigit = digits[i];
                }
            }

            // Displaying the results
            Console.WriteLine("Largest digit: " + largestDigit);
            Console.WriteLine("Second largest digit: " + secondLargestDigit);
        }
    }
}
