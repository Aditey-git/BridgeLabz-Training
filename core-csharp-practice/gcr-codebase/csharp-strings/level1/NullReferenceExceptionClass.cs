using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.level1
{
    internal class NullReferenceExceptionClass
    {
        public static void ExceptionShow() {

            NullReferenceExceptionShow();

        }

        // Method to demonstrate NullReferenceException
        public static void NullReferenceExceptionShow(){
            try{

                string stringText = null;

                //This line will throw NullReferenceException
                int length = stringText.Length;

                Console.WriteLine(length);

            }
            catch (NullReferenceException except){

                Console.WriteLine("NullReferenceException occured!");
                Console.WriteLine(except.Message);

            }
        }

    }
}
