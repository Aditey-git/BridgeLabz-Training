using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.Extras
{
    internal class LongestWordInString
    {
        public static void FindLongestWord() {
            //Getting input from the user
            Console.Write("Enter the sentence: ");
            string sentenceString = Console.ReadLine();

            string longest = "";
            string current = "";

            for(int i = 0; i < sentenceString.Length; i++){
                if (sentenceString[i] != ' '){
                    current += sentenceString[i];
                }
                else{
                    if(current.Length > longest.Length){
                        longest = current;
                    }
                    current = "";
                }
            }

            //Check last word
            if(current.Length > longest.Length){
                longest = current;
            }
            Console.WriteLine("Longest word: " + longest);
        }
    }
}
