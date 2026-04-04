using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Arrays.level2
{
    internal class ReverseNumber
    {
        public static void Reverse() {
            //Getting Input from user
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int temprorary = num;
            int counter = 0;
            while(temprorary != 0){
                counter++;
                temprorary = temprorary / 10;
            }

            int[] digitsArr = new int[counter];
            int index = 0;

            //Stroring in the array
            while(num != 0){
                digitsArr[index] = num % 10;
                num = num / 10;
                index++;
            }

            int[] reverse = new int[counter];

            for(int i = 0; i < counter; i++){
                reverse[i] = digitsArr[counter-1-i];
            }

            // Displaying resultant reversed number
            Console.Write("Reversed number is: ");
            for(int i = 0;i < counter;i++){
                Console.Write(reverse[i]);
            }
        } 
    }
}
