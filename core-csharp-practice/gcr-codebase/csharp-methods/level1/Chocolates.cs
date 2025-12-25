using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods
{
    internal class Chocolates
    {
        public static void NumberOfChocolates() {
            // Get input from user
            Console.Write("Enter the number of chocolates: ");
            int Chocolates = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of children: ");
            int Children = Convert.ToInt32(Console.ReadLine());

            int[] answer = FindRemainderAndQuotient(Chocolates, Children);//Calling the method

            Console.WriteLine("Amount of Chocolate each child gets: " + answer[0]);
            Console.WriteLine("Remaining: " + answer[1]);

        }

        public static int[] FindRemainderAndQuotient(int number, int divisor)
        {

            int quotient = number/divisor;
            int remainder = number%divisor;

            return new int[] { quotient, remainder };
        }
    }
}
