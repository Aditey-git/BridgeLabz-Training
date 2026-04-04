using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.StackQueueHasmap
{
    internal class SlidingWindowMaximum
    {
        public static int[] SlidingWindowMax(int[] numsArr, int kk)
        {
            if (numsArr == null || numsArr.Length == 0 || kk <= 0)
                return new int[0];

            int n = numsArr.Length;
            int[] resultArr = new int[n - kk + 1];

            LinkedList<int> dequeList = new LinkedList<int>(); 

            for (int i = 0; i < n; i++)
            {
                if (dequeList.Count > 0 && dequeList.First.Value <= i - kk)
                {
                    dequeList.RemoveFirst();
                }

                while (dequeList.Count > 0 && numsArr[dequeList.Last.Value] <= numsArr[i])
                {
                    dequeList.RemoveLast();
                }

                dequeList.AddLast(i);

                if (i >= kk - 1)
                {
                    resultArr[i - kk + 1] = numsArr[dequeList.First.Value];
                }
            }

            return resultArr;
        }


        public static void Main()
        {
            int[] numsArr = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;

            int[] resultArr = SlidingWindowMaximum.SlidingWindowMax(numsArr, k);

            Console.WriteLine("Sliding Window Maximums:");
            foreach (int val in resultArr)
            {
                Console.Write(val + " ");
            }
        }
    }
}
