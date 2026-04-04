using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.Extras
{
    internal class LexiographicalComparison
    {
        public static void Comparision() {
            Console.Write("Enter first string: ");
            string inputStr1 = Console.ReadLine();

            Console.Write("Enter second string: ");
            string inputStr2 = Console.ReadLine();

            int minimumLength = inputStr1.Length < inputStr2.Length ? inputStr1.Length : inputStr2.Length;
            bool difference = false;

            for(int i = 0; i < minimumLength; i++){
                if(inputStr1[i] < inputStr2[i]){
                    Console.WriteLine("String 1 comes before String 2");
                    difference = true;
                    break;
                }
                else if (inputStr1[i] > inputStr2[i]){
                    Console.WriteLine("String 1 comes after String 2");
                    difference = true;
                    break;
                }
            }

            //If all compared characters are equal
            if(!difference){
                if (inputStr1.Length < inputStr2.Length) Console.WriteLine("String 1 comes before String 2");
                else if (inputStr1.Length > inputStr2.Length) Console.WriteLine("String 1 comes after String 2");
                else Console.WriteLine("Both strings are equal");
            }
        }
    }
}
