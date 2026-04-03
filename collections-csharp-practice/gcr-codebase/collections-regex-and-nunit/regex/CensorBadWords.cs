using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTrainingCollectionsAAndFurther3.RegexQuestions
{
    internal class CensorBadWords
    {
        public static void Main(string[] args)
        {
            string inputString = "This is a damn bad example with some stupid words.";

            // List of bad words
            string pattern = @"\b(damn|stupid)\b";

            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

            string result = regex.Replace(inputString, "****");

            Console.WriteLine(result);
        }
    }
}
