using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.level1
{
    internal class Substring
    {
        public static void SubstringCreate() {
            //getting input from user
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            Console.Write("Enter start index: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter end index: ");
            int end = Convert.ToInt32(Console.ReadLine());

            //Calling the methods
            string substringUsingMethod = substringCreation(str, start, end);
            string substringUsingBuiltIn = str.Substring(start, end - start);

            Console.WriteLine("Substring using method: " + substringUsingMethod);
            Console.WriteLine("Substring using Substring(): " + substringUsingBuiltIn);
        }


        // Method to create substring using charAt() logic
        public static string substringCreation(string text, int startInd, int endInd){
            string answer = "";

            for (int i = startInd;i < endInd;i++){
                answer += text[i];
            }

            return answer;

        }

    }
}
