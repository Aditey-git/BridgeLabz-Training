using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.level1
{
    internal class WordSplit
    {
        public static void SplitWord() {
            //Getting Input from the User
            Console.Write("Enter string: ");
            string inputString = Console.ReadLine();

            string[,] wordsLengthsArr = WordsSplitAndLengths(inputString);//Calling the Method 

            for(int i = 0; i < wordsLengthsArr.GetLength(0); i++){
                Console.WriteLine(wordsLengthsArr[i, 0] + "\t" + wordsLengthsArr[i, 1]);
            }
        }


        //Method to find length of String
        public static int StringLength(string text){
            int counting = 0;

            foreach (char c in text){
                counting++;
            }

            return counting;
        }

        //Method to split text into words
        public static string[,] WordsSplitAndLengths(string inputString){
            int countOfWord = 0;
            bool wordIn = false;

            for(int i = 0; i < StringLength(inputString); i++){
                if(inputString[i] != ' ' && !wordIn){
                    countOfWord++;
                    wordIn = true;
                }
                else if(inputString[i] == ' '){
                    wordIn = false;
                }
            }

            string[,] resultantArr = new string[countOfWord, 2];

            int index = 0;
            string wordCurrent = "";

            //Word extraction
            for(int i = 0; i <= StringLength(inputString); i++){
                if(i < StringLength(inputString) && inputString[i] != ' '){
                    wordCurrent += inputString[i];
                }
                else if(wordCurrent != ""){
                    resultantArr[index, 0] = wordCurrent;
                    resultantArr[index, 1] = StringLength(wordCurrent).ToString();
                    index++;
                    wordCurrent = "";
                }
            }

            return resultantArr;

        }
    }
}
