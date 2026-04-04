using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.Extras
{
    internal class Anagrams
    {
        public static void IsAnagram() {
            //Getting input from the user
            Console.Write("Enter first string: ");
            string inputStr1 = Console.ReadLine();

            Console.Write("Enter second string: ");
            string inputStr2 = Console.ReadLine();

            if(inputStr1.Length != inputStr2.Length){
                Console.WriteLine("The strings are not anagrams.");
                return;
            }

            int[] frequencyArray = new int[256];

            //Count characters of first string
            for(int i = 0; i < inputStr1.Length; i++){
                frequencyArray[inputStr1[i]]++;
            }
            for(int i = 0; i < inputStr2.Length; i++){
                frequencyArray[inputStr2[i]]--;
            }
            for(int i = 0; i < frequencyArray.Length; i++){
                if(frequencyArray[i] != 0){
                    Console.WriteLine("The strings are not anagrams.");
                    return;
                }
            }

            Console.WriteLine("The strings are anagrams.");
        }
    }
}
