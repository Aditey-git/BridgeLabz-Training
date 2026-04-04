using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Arrays.level1
{
    internal class OddAndEven
    {
        public static void OddEvenArray() {
            //Getting Input from user
            Console.Write("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 0){
                Console.WriteLine("Enter a natural number greater than zero");
                return;
            }

            int[] oddArr = new int[num/2+1];
            int[] evenArr = new int[num/2+1];

            int oddI = 0;
            int evenI = 0;

            // Storing result  in respective arrays
            for(int i = 1; i <= num; i++){
                if (i % 2 == 0){
                    evenArr[evenI] = i;
                    evenI++;
                }
                else{
                    oddArr[oddI] = i;
                    oddI++;
                }
            }

            // Printing the result arrays
            Console.WriteLine("Odd Numbers:");
            for(int i = 0; i < oddI; i++){
                Console.WriteLine(oddArr[i] + " ");
            }

            Console.WriteLine("Even Numbers:");
            for(int i = 0; i < evenI; i++) {
                Console.WriteLine(evenArr[i] + " ");
            }
        }
    }
}
