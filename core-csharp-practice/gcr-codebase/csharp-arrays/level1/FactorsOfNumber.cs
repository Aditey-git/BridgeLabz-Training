using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BridgeLabzTraining.Arrays.level1
{
    internal class FactorsOfNumber
    {
        public static void factors()
        {
            //Getting Input from User
            Console.Write("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int maxFactor = 10;
            int[] factors = new int[maxFactor];
            int index = 0;

            //  Calculations for finding factors
            for(int i = 1; i <= num; i++){
                if (num % i == 0){

                    if (index == maxFactor){
                        maxFactor = maxFactor * 2;
                        int[] tempFactors = new int[maxFactor];
                        for(int j = 0;j < factors.Length;j++){
                            tempFactors[j] = factors[j];
                        }
                        factors = tempFactors;
                    }

                    factors[index] = i;
                    index++;
                }
            }

            // Displaying the resultant factors
            Console.WriteLine("Factors are:");
            for(int i = 0; i < index; i++){
                Console.WriteLine(factors[i]);
            }
        }
    }
}
