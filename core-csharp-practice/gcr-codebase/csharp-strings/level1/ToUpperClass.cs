using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.level1
{
    internal class ToUpperClass
    {
        public static void UpperClassConvert() {
            //Getting input from user
            Console.Write("Enter string: ");
            string inputString = Console.ReadLine();
            //Calling the methods
            string upperUsingMethod = ConvertToUpper(inputString);

            string upperBuiltIn = inputString.ToUpper();

            Console.WriteLine("Uppercase using ASCII: " + upperUsingMethod);
            Console.WriteLine("Uppercase using ToUpper(): " + upperBuiltIn);
        }

        //Method to convert string to uppercase
        public static string ConvertToUpper(string inputString){
            char[] resultArr = new char[inputString.Length];
            for (int i = 0; i < inputString.Length; i++){
                char character = inputString[i];
                if(character >= 'a' && character <= 'z'){
                    resultArr[i] = (char)(character - 32);
                }
                else{
                    resultArr[i] = character;
                }
            }

            return new string(resultArr);

        }

    }
}
