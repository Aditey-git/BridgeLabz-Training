using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods
{
    internal class QuotientAndRemainder
    {
        public static void RemainderAndQuotient() {
            //Getting input from the user
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int[] answer = FindRemainderAndQuotient(num, divisor); //Calling the method

            // Display result
            Console.WriteLine("Quotient is " + answer[0]);
            Console.WriteLine("Remainder is " + answer[1]);
        }
    }
    }
}
