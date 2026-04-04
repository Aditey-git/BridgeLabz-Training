using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.StackQueueHasmap
{
    internal class LongestCommonSeq
    {
        public static int FindLCQ(int[] numsArr)
        {
            if (numsArr.Length == 0)
                return 0;

            HashSet<int> hashset = new HashSet<int>(numsArr);
            int longestInt = 0;

            foreach (int num in hashset)
            {
                // Check if it's the start of a sequence
                if (!hashset.Contains(num - 1))
                {
                    int currNum = num;
                    int currLen = 1;

                    while (hashset.Contains(currNum + 1))
                    {
                        currNum++;
                        currLen++;
                    }

                    longestInt = Math.Max(longestInt, currLen);
                }
            }

            return longestInt;
        }

        public static void Main()
        {
            int[] numsArr = { 100, 4, 200, 1, 3, 2 };

            int result = LongestCommonSeq.FindLCQ(numsArr);

            Console.WriteLine("Longest Consecutive Sequence Length: " + result);
        }
    }
}
