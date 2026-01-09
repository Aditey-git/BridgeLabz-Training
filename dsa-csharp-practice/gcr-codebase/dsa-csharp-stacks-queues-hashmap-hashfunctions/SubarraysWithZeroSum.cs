using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.StackQueueHasmap
{
    internal class SubarraysWithZeroSum
    {
        public static void ZeroSumSubarrays(int[] arr)
        {
            
            Dictionary<int, List<int>> hashmap = new Dictionary<int, List<int>>();

            int prefixSum = 0;

            hashmap[0] = new List<int> { -1 };

            for (int i = 0; i < arr.Length; i++)
            {
                prefixSum += arr[i];

                if (hashmap.ContainsKey(prefixSum))
                {
                    foreach (int sIndex in hashmap[prefixSum])
                    {
                        Console.WriteLine($"Subarray found from index {sIndex + 1} to {i}");
                    }
                    hashmap[prefixSum].Add(i);
                }
                else
                {
                    hashmap[prefixSum] = new List<int> { i };
                }
            }
        }

        static void Main()
        {
            int[] arr = { 3, 4, -7, 3, 1, 3, 1, -4 };

            SubarraysWithZeroSum.ZeroSumSubarrays(arr);
        }
    }
}
