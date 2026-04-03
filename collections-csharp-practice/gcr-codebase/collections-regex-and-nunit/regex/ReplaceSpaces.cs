using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTrainingCollectionsAAndFurther3.RegexQuestions
{
    internal class ReplaceSpaces
    {
        public static void Main(string[] args)
        {
            string inputString = "This   is    an   example   with   multiple   spaces.";

            Regex regex = new Regex(@"\s+");

            string result = regex.Replace(inputString, " ");

            Console.WriteLine(result);
        }
    }
}
