using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods
{
    internal class MaxHandshakes
    {
        public static void HandShakes(){
            //Getting input from the user
            Console.Write("Enter number of students: ");
            int sts = Convert.ToInt32(Console.ReadLine());

            //Calling the method 
            int hs = Calculate(sts);

            //Displaying the result
            Console.WriteLine("Maximum number of handshakes is " + hs);
        }

        //Method for calculating the number of handshakes
        public static int Calculate(int n){
            return (n * (n - 1)) / 2;
        }
    }
}
