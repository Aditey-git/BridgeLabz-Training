using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.level1
{
    internal class ReturnAllCharacters
    {
        public static void CharactersReturn() {
            //Getting Input from the user
            Console.Write("Enter the string: ");
            string inputString = Console.ReadLine();

            //methods calling
            char[] customCharsArr = WithoutToCharArray(inputString);
            char[] builtInCharsArr = inputString.ToCharArray();

            Console.WriteLine("Characters using Without ToCharArray method:");
            for (int i = 0; i < customCharsArr.Length; i++){
                Console.Write(customCharsArr[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Characters using ToCharArray():");
            for (int i = 0; i < builtInCharsArr.Length; i++){
                Console.Write(builtInCharsArr[i] + " ");
            }
            Console.WriteLine();
        }

        // Method to return characters without using ToCharArray()
        public static char[] WithoutToCharArray(string str){
            char[] charsArr = new char[str.Length];

            for(int i = 0;i < str.Length; i++){
                charsArr[i] = str[i];
            }

            return charsArr;

        }
    }
}
