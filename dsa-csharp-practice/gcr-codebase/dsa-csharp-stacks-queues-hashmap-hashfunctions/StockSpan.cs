using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.StackQueueHasmap
{
    internal class StockSpan
    {
        public static int[] SpanCalculate(int[] pricesArr)
        {
            int n = pricesArr.Length;
            int[] spanArr = new int[n];

            Stack<int> st = new Stack<int>(); 

            for (int i = 0; i < n; i++)
            {
               
                while (st.Count > 0 && pricesArr[st.Peek()] <= pricesArr[i])
                {
                    st.Pop();
                }

                
                spanArr[i] = (st.Count == 0) ? (i + 1) : (i - st.Peek());
                st.Push(i);
            }

            return spanArr;
        }


        static void Main()
        {
            int[] pricesArr = { 100, 80, 60, 70, 60, 75, 95 };

            int[] spanArr = StockSpan.SpanCalculate(pricesArr);

            Console.WriteLine("Stock Spans:");
            for (int i = 0; i < spanArr.Length; i++)
            {
                Console.Write(spanArr[i] + " ");
            }
        }
    }
}
