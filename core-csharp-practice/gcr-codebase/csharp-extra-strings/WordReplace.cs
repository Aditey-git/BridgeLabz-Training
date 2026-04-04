using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.Extras
{
    internal class WordReplace
    {
        public static void Replace() {
            //Getting input from the user
            Console.Write("Enter the sentence: ");
            string sentenceString = Console.ReadLine();

            Console.Write("Enter the word to replace: ");
            string olderWord = Console.ReadLine();

            Console.Write("Enter the new word: ");
            string newWordToBeReplaced = Console.ReadLine();

            string resultString = ReplaceWord(sentenceString, olderWord, newWordToBeReplaced);
            Console.WriteLine("Modified Sentence: " + resultString);
        }

        static string ReplaceWord(string sentenceString, string olderWord, string newWordToBeReplaced){
            string resultantString = "";
            int i = 0;

            while(i < sentenceString.Length){
                bool matchWord = true;

                if(i + olderWord.Length <= sentenceString.Length){
                    for(int j = 0; j < olderWord.Length; j++){
                        if(sentenceString[i + j] != olderWord[j]){
                            matchWord = false;
                            break;
                        }
                    }
                }
                else{
                    matchWord = false;
                }

                if(matchWord){
                    resultantString += newWordToBeReplaced;
                    i += olderWord.Length;
                }
                else{
                    resultantString += sentenceString[i];
                    i++;
                }
            }

            return resultantString;
        }
    }
}
