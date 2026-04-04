using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Arrays.level1
{
    internal class FizzBuzz
    {
        public static void fizzBuzz() {
            //Getting Input from User
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("Not a positive number");
                return;
            }

            string[] result = new string[num + 1];

            for(int i = 0;i <= num;i++){
                if(i % 3 == 0 && i % 5 == 0){
                    result[i] = "FizzBuzz";
                }
                else if(i % 3 == 0){
                    result[i] = "Fizz";
                }
                else if (i % 5 == 0){
                    result[i] = "Buzz";
                }
                else{
                    result[i] = i.ToString();
                }
            }

            // Displaying the results 
            for (int i = 0;i <= num;i++){
                Console.WriteLine(result[i]);
            }

        }
    }
}
