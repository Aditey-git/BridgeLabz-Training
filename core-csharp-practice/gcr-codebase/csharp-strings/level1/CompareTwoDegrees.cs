using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.level1
{
    internal class CompareTwoDegrees
    {
        public static void Compare() {
            //Getting Input from user
            Console.Write("Enter first String: ");
            string first = Console.ReadLine();
            Console.Write("Enter second String: ");
            string second = Console.ReadLine();

            //calling the Method
            bool resultCharAt = CompareStrings(first, second);
            bool resultEquals = first.Equals(second);

            Console.WriteLine("Comparison using charAt logic: " + resultCharAt);
            Console.WriteLine("Comparison using string.Equals(): " + resultEquals);

        }

        // Method to compare two strings
        public static bool CompareStrings(string string1, string string2){

            if (string1.Length != string2.Length) return false;

            for(int i = 0; i < string1.Length; i++){
                if(string1[i] != string2[i]) return false;
            }

            return true;

        }
    }
}
