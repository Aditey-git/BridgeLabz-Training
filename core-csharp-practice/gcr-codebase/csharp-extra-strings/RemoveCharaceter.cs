using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.Extras
{
    internal class RemoveCharaceter
    {
        public static void CharacterRemove() {
            //Getting input from the user
            Console.Write("Enter the string: ");
            string inputString = Console.ReadLine();

            Console.Write("Enter the character to remove: ");
            char charRemove = Convert.ToChar(Console.ReadLine());

            char[] resultArray = new char[inputString.Length];
            int ind = 0;
            for(int i = 0; i < inputString.Length; i++){
                if(inputString[i] != charRemove){
                    resultArray[ind] = inputString[i];
                    ind++;
                }
            }

            string modifiedString = new string(resultArray, 0, ind);
            Console.WriteLine("Modified String: " + modifiedString);
        }
    }
}
