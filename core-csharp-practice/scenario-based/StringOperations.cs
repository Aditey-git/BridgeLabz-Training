using BridgeLabzTraining.Strings.Extras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

/*
 Summary:-
 This program is a menu-driven C# application that performs multiple string operations on a user-entered paragraph.
It allows formatting text by adding spaces after punctuation, capitalizing letters after sentence endings, and removing extra spaces.
The program can also count the number of words, find the longest word, and replace a word in the paragraph.
Each operation is implemented using separate methods, demonstrating modular programming.
Overall, it showcases basic string manipulation and control flow without relying heavily on built-in functions.
 */


namespace BridgeLabzTraining.Scenario_Based
{
    internal class StringOperations
    {
        //Method to perform different string operations based on user choice
        public static void StringFunctions() {
            //Getting input from the user
            string paragraph = Console.ReadLine();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Format for Space after punctuation");
            Console.WriteLine("2. Format for Capital letter after punctuation");
            Console.WriteLine("3. Format for extra spaces");
            Console.WriteLine("4. Format Paragraph with all functions");
            Console.WriteLine("5. Count the number of words in the function");
            Console.WriteLine("6. To find longest word in the paragraph");
            Console.WriteLine("7. Replace any word with another word in the paragraph");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Formatted Paragraph: " + FormatterForSpaceAfterPunctuation(paragraph));
                    break;
                case 2:
                    Console.WriteLine("Formatted Paragraph: " + FormatterForCapitalLetterAfterPunctuation(paragraph));
                    break;
                case 3:
                    Console.WriteLine("Formatted Paragraph: " + FormatterToRemoveExtraSpaces(paragraph));
                    break;
                case 4:
                    string convertedPara = FormatterToRemoveExtraSpaces(paragraph);
                    convertedPara = FormatterForSpaceAfterPunctuation(convertedPara);
                    convertedPara = FormatterForCapitalLetterAfterPunctuation(convertedPara);
                    Console.WriteLine("Formatted Paragraph: " + convertedPara);
                    break;
                case 5:
                    Console.WriteLine("Number of Words: " + NumberOfWords(paragraph));
                    break;
                case 6: 
                    LongestWordInParagraph(paragraph);
                    break;
                case 7:
                    Console.WriteLine(WordReplace(paragraph));
                    break;
            }
        }


        //Ensures exactly one space after punctuation marks
        public static string FormatterForSpaceAfterPunctuation(string para ) {
            string result = "";

            for (int i = 0; i < para.Length; i++)
            {
                char ch = para[i];
                result += ch;

                if ((ch == ',' || ch == '.' || ch == '?' || ch == '!' || ch == ':' || ch == ';') &&
                    i + 1 < para.Length &&
                    para[i + 1] != ' ')
                {
                    result += ' ';
                }
            }

            return result;
        }


        // Capitalizes first letter and letter after '.', '?' and '!
        public static string FormatterForCapitalLetterAfterPunctuation(string para)
        {
            string result = "";
            bool makingCapital = true; 

            foreach (char ch in para)
            {
                if (char.IsLetter(ch) && makingCapital)
                {
                    result += char.ToUpper(ch);
                    makingCapital = false;
                }
                else
                {
                    result += ch;
                }
                if (ch == '.' || ch == '?' || ch == '!')
                {
                    makingCapital = true;
                }
            }

            return result;

        }


        // Removes leading, trailing and multiple spaces
        public static string FormatterToRemoveExtraSpaces(string para)
        {  
            string result = "";
            bool IfSpaceFound = true;
            for (int i = 0; i < para.Length; i++)
            {
                if (para[i] != ' ')
                {
                    result = result + para[i];
                    IfSpaceFound = false;
                }
                else if (!IfSpaceFound)
                {
                    result = result + ' ';
                    IfSpaceFound = true;
                }
            }
            if (result.Length > 0 && result[result.Length - 1] == ' ')
            {
                result = result.Substring(0, result.Length - 1);
            }
            return result;
        }


        // Counts number of words in the paragraph
        public static int NumberOfWords(string para)
        {
            int count = 0;
            bool wordIn = false;

            foreach (char ch in para){
                if (ch != ' ' && !wordIn){
                    count++;
                    wordIn = true;
                }
                else if (ch == ' '){
                    wordIn = false;
                }
            }
            return count;
        }


        // Finds and prints the longest word in the paragraph
        public static void LongestWordInParagraph(string para)
        {
            int c1 = 0;
            int c2 = 0;
            string str1 = "";
            string str2 = "";
            foreach(char ch in para){
                if(ch == ' '){
                    if (c1 > c2)
                    {
                        c2 = c1;
                        str2 = str1;
                    }
                    c1 = 0;
                    str1 = "";
                }
                else
                {
                    c1++;
                    str1 += ch;
                }
            } 
            if (c1 > c2)
            {
                c2 = c1;
                str2 = str1;
            }
            Console.WriteLine("The longest word in paragraph is " + str2);
        }


        //Replaces a given word with another word
        public static string WordReplace(string para)
        {
            Console.WriteLine("Enter old word: ");
            string old = Console.ReadLine();

            Console.WriteLine("Enter new word: ");
            string newW = Console.ReadLine();

            string result = "";
            string currentWord = "";
            for (int i = 0; i < para.Length; i++){
                char ch = para[i];
                if (ch != ' ')
                {
                    currentWord += ch;
                }
                else
                {
                    if (currentWord == old) result += newW;
                    else result += currentWord;

                    result += " ";
                    currentWord = "";
                }
            }
            if (currentWord == old) result += newW;
            else result += currentWord;

            return result;
        }



    }
}
