using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.Extras
{
    internal class SubstringOccurence
    {
        public static void FindSubstringOccurrence() {
            //Getting input from the user
            Console.Write("Enter the main string: ");
            string inputString = Console.ReadLine();

            Console.Write("Enter the substring to search: ");
            string patternString = Console.ReadLine();

            int countNumber = 0;

            for (int i = 0; i <= inputString.Length - patternString.Length; i++){
                bool matchStr = true;

                for (int j = 0; j < patternString.Length; j++)
                {
                    if (inputString[i + j] != patternString[j])
                    {
                        matchStr = false;
                        break;
                    }
                }

                if (matchStr)
                {
                    countNumber++;
                }
            }

            Console.WriteLine("Number of occurrences: " + countNumber);
        }
    }
}
