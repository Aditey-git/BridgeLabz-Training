using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods
{
    internal class SmallestAndLargest
    {
        public static void SmallestAndLargestNumber() {
            //Getting input from user
            Console.Write("Enter first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            int[] resultArr = FindSmallestAndLargest(n1, n2, n3);//Calling the method

            Console.WriteLine("Smallest number is: " + resultArr[0]);
            Console.WriteLine("Largest number is: " + resultArr[1]);
        }

        public static int[] FindSmallestAndLargest(int n1, int n2, int n3)
        {
            int smallestNum = n1;
            int largestNum = n1;

            if (n2 < smallestNum) smallestNum = n2;
            if (n3 < smallestNum) smallestNum = n3;
            if (n2 > largestNum) largestNum = n2;
            if (n3 > largestNum) largestNum = n3;

            return new int[] { smallestNum, largestNum };
        }

    }
}
