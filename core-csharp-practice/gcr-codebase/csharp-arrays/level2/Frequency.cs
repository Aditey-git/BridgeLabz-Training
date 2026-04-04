using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Arrays.level2
{
    internal class Frequency
    {
        public static void FrequencyFind()
        {
            //Getting Input from User
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int temprorary = num;
            int counter = 0;



            //Calculations
            while(temprorary != 0){
                counter++;
                temprorary = temprorary/10;
            }

            int[] digitsArr = new int[counter];
            int index = 0;

            while(num != 0){
                digitsArr[index] = num%10;
                num = num/10;
                index++;
            }

            int[] frequencyArr = new int[10];

            for(int i = 0;i < counter;i++){
                frequencyArr[digitsArr[i]]++;
            }

            // Display frequency
            Console.WriteLine("Digit Frequency:");
            for(int i = 0;i < 10;i++){
                if(frequencyArr[i] > 0){
                    Console.WriteLine($"Digit {i} occurs {frequencyArr[i]} times");
                }
            }
        }
    }
}
