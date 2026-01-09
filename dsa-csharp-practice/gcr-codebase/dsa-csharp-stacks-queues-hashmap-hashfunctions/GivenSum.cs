using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.StackQueueHasmap
{
    internal class GivenSum
    {
        public static bool HasPair(int[] arr, int target)
        {
            HashSet<int> hashset = new HashSet<int>();

            foreach (int number in arr)
            {
                int req = target - number;

                if (hashset.Contains(req))
                    return true;

                hashset.Add(number);
            }

            return false;
        }


        static void Main()
        {
            int[] arr = { 8, 7, 2, 5, 3, 1 };
            int target = 10;

            bool result = GivenSum.HasPair(arr, target);

            Console.WriteLine(result
                ? "Pair with given sum exists"
                : "No such pair exists");
        }
    }
}
