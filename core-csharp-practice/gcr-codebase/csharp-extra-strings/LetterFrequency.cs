using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.Extras
{
    internal class LetterFrequency
    {
        public static void LetterFrequencyFind() {
            //Getting input from user
            Console.Write("Enter the string: ");
            string inputString = Console.ReadLine();

            int[] frequencyArr = new int[256];

            //Count frequency of each character
            for(int i = 0; i < inputString.Length; i++){
                frequencyArr[inputString[i]]++;
            }

            char mostFrequentChar = inputString[0];
            int maxCountOfChar = frequencyArr[mostFrequentChar];
            for(int i = 0; i < inputString.Length; i++){
                if(frequencyArr[inputString[i]] > maxCountOfChar){
                    maxCountOfChar = frequencyArr[inputString[i]];
                    mostFrequentChar = inputString[i];
                }
            }

            Console.WriteLine("Most Frequent Character: '" + mostFrequentChar + "'");
        }
    }
}
