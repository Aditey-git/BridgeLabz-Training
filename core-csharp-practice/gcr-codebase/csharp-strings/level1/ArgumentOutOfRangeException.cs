using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.level1
{
    internal class ArgumentOutOfRangeExceptionClass
    {
        public static void ExceptionShow() {

            argumentOutOfRangeExceptionShow();

        }


        // Method for demonstrating ArgumentOutOfRangeException
        public static void argumentOutOfRangeExceptionShow(){
            try{

                string textString = "HelloWorld";

                //This line will cause exception
                string answer = textString.Substring(5, 10);

                Console.WriteLine(answer);
            }
            catch(ArgumentOutOfRangeException except){

                Console.WriteLine("ArgumentOutOfRangeException occured");
                Console.WriteLine(except.Message);

            }
        }

    }
}
