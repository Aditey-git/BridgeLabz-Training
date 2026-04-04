using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods
{
    internal class SumOfNaturalNumbers
    {
        public static void NaturalNumbers()
        {
            //Getting input from the user
            Console.Write("Enter a natural number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int answer = Sum(num);//Calling the method
            Console.WriteLine("The sum is " + answer);
        }


        //The method for calculating the sum 
        public static int Sum(int num){
            int sum = 0;

            for(int i = 1;i <= num;i++){
                sum = sum + i;
            }

            return sum;
        }
    }
}
