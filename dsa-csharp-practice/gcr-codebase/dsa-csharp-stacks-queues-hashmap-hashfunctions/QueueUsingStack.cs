using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.StackQueueHasmap
{
    internal class QueueUsingStack
    {
        private Stack<int> stEn = new Stack<int>();
        private Stack<int> stDeq = new Stack<int>();

        // Enqueue operation
        public void Enqueue(int val)
        {
            stEn.Push(val);
        }

        // Dequeue operation
        public int Dequeue()
        {
            if (stDeq.Count == 0)
            {
                if (stEn.Count == 0)
                {
                    throw new InvalidOperationException("Queue is empty");
                }

                while (stEn.Count > 0)
                {
                    stDeq.Push(stEn.Pop());
                }
            }

            return stDeq.Pop();
        }

        // Peek front element
        public int Peek()
        {
            if (stDeq.Count == 0)
            {
                if (stEn.Count == 0)
                {
                    throw new InvalidOperationException("Queue is empty");
                }

                while (stEn.Count > 0)
                {
                    stDeq.Push(stEn.Pop());
                }
            }

            return stDeq.Peek();
        }

        // Check if queue is empty
        public bool IsEmpty()
        {
            return stEn.Count == 0 && stDeq.Count == 0;
        }


        static void Main()
        {
            QueueUsingStack queue = new QueueUsingStack();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine(queue.Dequeue()); 

            queue.Enqueue(40);

            Console.WriteLine(queue.Dequeue()); 
            Console.WriteLine(queue.Peek());    
        }
    }
}
