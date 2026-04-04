using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.StackQueueHasmap
{
    internal class CircularTourProblem
    {
        public static int FindStartPump(int[] petrolArr, int[] distanceArr)
        {
            int n = petrolArr.Length;

            int startIndex = 0;
            int bal = 0;
            int deficit = 0;

            for (int i = 0; i < n; i++)
            {
                bal += petrolArr[i] - distanceArr[i];

                if (bal < 0)
                {
                    deficit += bal;
                    startIndex = i + 1;
                    bal = 0;
                }
            }

            // Check if total petrol is sufficient
            return (bal + deficit >= 0) ? startIndex : -1;
        }

        public static void Main()
        {
            int[] petrolArr = { 6, 3, 7 };
            int[] distanceArr = { 4, 6, 3 };

            int start = CircularTourProblem.FindStartPump(petrolArr, distanceArr);

            if (start != -1)
                Console.WriteLine("Start tour at petrol pump index: " + start);
            else
                Console.WriteLine("No possible circular tour");
        }
    }
}
