using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods
{
    internal class NumberOfHandShakes
    {
        public static void CountingHandShakes() {
            //Getting input from the user
            Console.Write("Enter number of students: ");
            int students = Convert.ToInt32(Console.ReadLine());

            //Calcualtion
            int numberOfHandshakes = (students*(students - 1))/2;

            Console.WriteLine("max possible handshakes is " + numberOfHandshakes);
        }
    }
}
