using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.Extras
{
    internal class ToggleCase
    {
        public static void Toggle() {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            char[] resultArr = new char[inputString.Length];

            for(int i = 0; i < inputString.Length; i++){
                char character = inputString[i];

                // Uppercase to Lowercase
                if(character >= 'A' && character <= 'Z'){
                    resultArr[i] = (char)(character + 32);
                }
                // Lowercase to Uppercase
                else if(character >= 'a' && character <= 'z'){
                    resultArr[i] = (char)(character - 32);
                }
                else{
                    resultArr[i] = character;
                }
            }

            Console.WriteLine("Toggled string: " + new string(resultArr));
        }
    }
}
