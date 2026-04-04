using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.level1
{
    internal class IndexOutOfRangeClass
    {
        public static void ExceptionShow() {
            ArrayIndexOutOfRangeExceptionShow();
        }


        // Method to demonstrate IndexOutOfRangeException
        public static void ArrayIndexOutOfRangeExceptionShow(){
            try{

                int[] numsArr = { 10, 20, 30 };

                //This will throw IndexOutOfRangeException
                int val = numsArr[5];

                Console.WriteLine(val);

            }
            catch (IndexOutOfRangeException except){
                Console.WriteLine("IndexOutOfRangeException occured");
                Console.WriteLine(except.Message);
            }
        }
    }
}
