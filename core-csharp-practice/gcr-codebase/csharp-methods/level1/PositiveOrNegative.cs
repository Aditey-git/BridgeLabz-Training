using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods
{
    internal class PositiveOrNegative
    {
        public static void PositiveOrNegativeCheck() {
            //getting input from the user
            Console.Write("Enter an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int answer = Check(num); //Calling the method

            // Displaying result 
            if (answer == 1) Console.WriteLine("Positive");
            else if (answer == -1) Console.WriteLine("Negative");
            else Console.WriteLine("Zero");
        }


        public static int Check(int num){
            if (num > 0) return 1;
            else if (num < 0) return -1;
            else return 0;
        }
    }
}
