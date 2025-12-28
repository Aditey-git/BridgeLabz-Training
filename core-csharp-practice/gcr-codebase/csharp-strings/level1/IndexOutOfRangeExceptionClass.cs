using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.level1
{
    internal class IndexOutOfRangeExceptionClass
    {
        public static void ExceptionShow() {
            IndexOutOfRangeExceptionShow();

            IndexOutOfRangeExceptionHandle();
        }

        //Method to Show IndexOutOfRangeException
        public static void IndexOutOfRangeExceptionShow()
        {
            string textString = "Hello";

            //This line will throw Exception
            char character = textString[10];

            Console.WriteLine(character);
        }

        //Method to handle the exception
        public static void IndexOutOfRangeExceptionHandle(){
            try{
                string textString = "Hello";
                char character = textString[10];
                Console.WriteLine(character);
            }
            catch(IndexOutOfRangeException except){
                Console.WriteLine("IndexOutOfRangeException caught!");
                Console.WriteLine(except.Message);
            }
        }
    }
}
