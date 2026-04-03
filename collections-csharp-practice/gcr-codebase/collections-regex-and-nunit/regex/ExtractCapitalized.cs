using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTrainingCollectionsAAndFurther3.RegexQuestions
{
    internal class ExtractCapitalized
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the sentence: ");
            string inputString = Console.ReadLine();

            Regex regex = new Regex(@"\b[A-Z][a-z]*\b");

            MatchCollection matches = regex.Matches(inputString);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
