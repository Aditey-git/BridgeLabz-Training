using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.StackQueueHasmap
{
    internal class SortStackUsingRecursion
    {
        // Sort the stack in ascending order
        public static void StackSortUsingRecursion(Stack<int> st)
        {
      
            if (st.Count <= 1)
                return;

            int topE = st.Pop();

           
            StackSortUsingRecursion(st);

            
            SortedInsertion(st, topE);
        }

        // Insert an element into a sorted stack
        private static void SortedInsertion(Stack<int> st, int ele)
        {
            if (st.Count == 0 || st.Peek() <= ele)
            {
                st.Push(ele);
                return;
            }

            
            int topE = st.Pop();
            SortedInsertion(st, ele);

            
            st.Push(topE);
        }


        static void Main()
        {
            Stack<int> st = new Stack<int>();
            st.Push(45);
            st.Push(15);
            st.Push(55);
            st.Push(25);

            SortStackUsingRecursion.StackSortUsingRecursion(st);

            Console.WriteLine("Sorted Stack (Top to Bottom):");
            while (st.Count > 0)
            {
                Console.WriteLine(st.Pop());
            }
        }
    }
}
