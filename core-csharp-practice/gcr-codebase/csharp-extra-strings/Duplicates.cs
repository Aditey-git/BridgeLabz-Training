using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.Extras
{
    internal class Duplicates
    {
        public static void RemoveDuplicates() {
            //Getting input from the user
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            string resultString = "";

            for (int i = 0;i < inputString.Length;i++){
                bool DuplicateCheck = false;
                for (int j = 0; j < resultString.Length; j++){
                    if (inputString[i] == resultString[j]){
                        DuplicateCheck = true;
                        break;
                    }
                }
                if (!DuplicateCheck){
                    resultString += inputString[i];
                }
            }

            Console.WriteLine("String after removing duplicates: " + resultString);
        }
    }
}
