using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.level1
{
    internal class FormatExceptionShow
    {
        public static void ExceptionShow() {

            FormatExceptionDisplay();

        }

        //Method to show FormatException
        public static void FormatExceptionDisplay(){
            try{
                string inputString = "ABC123"; // Non-numeric string

                //This line will throw FormatException
                int num = int.Parse(inputString);

                Console.WriteLine(num);
            }
            catch(FormatException except){
                Console.WriteLine("FormatException caught!");
                Console.WriteLine(except.Message);
            }
        }

    }
}
