using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.Extras
{
    internal class VowelsAndConsonants
    {
        public static void VowelsAndConsonantsCount() {
            //Getting input from the user
            Console.Write("Enter the string:");
            string inputString = Console.ReadLine();

            int vowelCount = 0;
            int consonantCount = 0;

            for (int i = 0; i < inputString.Length; i++){
                char character = inputString[i];
                if(character >= 'A' && character <= 'Z'){
                    character = (char)(character + 32);
                }

                if(character >= 'a' && character <= 'z'){
                    if(character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u'){
                        vowelCount++;
                    }
                    else{
                        consonantCount++;
                    }
                }
            }

            Console.WriteLine("Number of Vowels: " + vowelCount);
            Console.WriteLine("Number of Consonants: " + consonantCount);
        }
    }
}
