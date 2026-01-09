using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.StackQueueHasmap
{
    internal class TwoSum
    {
        public static int[] TwoSumFind(int[] numsArr, int target)
        {
            Dictionary<int, int> hashmap = new Dictionary<int, int>();
          

            for (int i = 0; i < numsArr.Length; i++)
            {
                int req = target - numsArr[i];

                if (hashmap.ContainsKey(req))
                {
                    return new int[] { hashmap[req], i };
                }

                if (!hashmap.ContainsKey(numsArr[i]))
                    hashmap.Add(numsArr[i], i);
            }

            return new int[] { -1, -1 };
        }

        static void Main()
        {
            int[] numsArr = { 2, 7, 11, 15 };
            int target = 9;

            int[] res = TwoSum.TwoSumFind(numsArr, target);

            Console.WriteLine($"Indices: {res[0]}, {res[1]}");
        }
    }
}
