using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.Extras
{
    internal class Reverse
    {
        public static void ReverseString() {
            //Getting input from the user
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            char[] reversedArr = new char[inputString.Length];
            int index = 0;

            // Reverse logic
            for(int i = inputString.Length - 1; i >= 0; i--){
                reversedArr[index] = inputString[i];
                index++;
            }

            string resultSting = new string(reversedArr);

            Console.WriteLine("Reversed string: " + resultSting);
        }
    }
}
