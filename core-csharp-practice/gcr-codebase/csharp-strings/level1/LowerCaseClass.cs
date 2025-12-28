using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.level1
{
    internal class LowerCaseClass
    {
        public static void ConvertLowerCase() {
            //Getting user Input
            Console.Write("Enter text: ");
            string inputString = Console.ReadLine();
            //Calling the methods
            string lowerUsingMethod = ConvertToLower(inputString);

            string lowerBuiltIn = inputString.ToLower();

            Console.WriteLine("Lowercase using ASCII: " + lowerUsingMethod);
            Console.WriteLine("Lowercase using ToLower(): " + lowerBuiltIn);
        }


        //Custom made Method to convert string to lowercase
        public static string ConvertToLower(string inputString){

            char[] resultArr = new char[inputString.Length];
            for (int i = 0; i < inputString.Length; i++){
                char character = inputString[i];
                if (character >= 'A' && character <= 'Z'){
                    resultArr[i] = (char)(character + 32);
                }
                else{
                    resultArr[i] = character;
                }
            }

            return new string(resultArr);

        }
    }
}
