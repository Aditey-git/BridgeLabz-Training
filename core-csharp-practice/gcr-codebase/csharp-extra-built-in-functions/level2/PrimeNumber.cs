using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.BuiltIn.level2
{
    internal class PrimeNumber
    {
        public static void PrimeNumberCheck()
        {
            Console.Write("Enter the number: ");
            int numberInput = Convert.ToInt32(Console.ReadLine());

            bool isPrimeOrNot = IsPrimeCheck(numberInput);

            if (isPrimeOrNot) Console.WriteLine("Prime Number.");
            else Console.WriteLine("NOT a Prime Number.");
        }


        static bool IsPrimeCheck(int numberInput){
            if (numberInput <= 1) return false;

            for (int i = 2; i * i <= numberInput; i++){
                if (numberInput % i == 0) return false;
            }

            return true;
        }
    }
}
