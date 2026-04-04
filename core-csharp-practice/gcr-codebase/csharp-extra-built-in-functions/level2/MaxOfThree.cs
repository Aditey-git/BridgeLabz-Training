using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.BuiltIn.level2
{
    internal class MaxOfThree
    {
        public static void Max() {
            int[] numbersArr = TakeInput();
            int maximum = FindMaximum(numbersArr[0], numbersArr[1], numbersArr[2]);

            Console.WriteLine("The maximum number is: " + maximum);
        }


        //Method to take three integer inputs from the user
        static int[] TakeInput(){
            int[] numsArr = new int[3];

            for(int i = 0;i < 3;i++){
                Console.Write($"Enter number {i + 1}: ");
                numsArr[i] = Convert.ToInt32(Console.ReadLine());
            }

            return numsArr;
        }

        // Function to find the maximum of three numbers
        static int FindMaximum(int num1, int num2, int num3)
        {
            int maximum = num1;

            if (num2 > maximum) maximum = num2;

            if (num3 > maximum) maximum = num3;

            return maximum;
        }
    }
}
