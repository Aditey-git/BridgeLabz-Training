using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.LinkedList.round_robin_system
{
    internal class RoundSystem
    {
        private Node head = null;
        private Node tail = null;
        private int totalCount = 0;

        public void AddAProcess(int id, int bt, int p)
        {
            Node newNode = new Node(id, bt, p);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
                newNode.Next = head;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
                tail.Next = head;
            }
            totalCount++;
        }

        public void SimulateList(int quant)
        {
            if (head == null) return;

            int currTime = 0;
            int completedCount = 0;
            double waitTimeTotal = 0;
            double totalTurnAroundTime = 0;

            // Arrays to store initial burst times and finish times for calculations without using List<T>
            int[] originalBurstsArr = new int[totalCount + 1];
            int[] pidsArr = new int[totalCount + 1];

            Node temp = head;
            for (int i = 0; i < totalCount; i++)
            {
                pidsArr[i] = temp.PID;
                originalBurstsArr[i] = temp.BurstTime;
                temp = temp.Next;
            }

            Node current = head;
            Node prev = tail;

            Console.WriteLine("Execution Start:");

            while (completedCount < totalCount)
            {
                int exeTime = (current.RemainingTime > quant) ? quant : current.RemainingTime;
                current.RemainingTime -= exeTime;
                currTime += exeTime;

                if (current.RemainingTime == 0)
                {
                    current.FinishTime = currTime;
                    int tat = current.FinishTime;
                    int wt = tat - current.BurstTime;

                    totalTurnAroundTime += tat;
                    waitTimeTotal += wt;
                    completedCount++;

                    Console.WriteLine($"[Time {currTime}] Process {current.PID} Finished. TAT: {tat}, WT: {wt}");

                    if (current == head && current == tail)
                    {
                        head = tail = null;
                    }
                    else
                    {
                        prev.Next = current.Next;
                        if (current == head) head = current.Next;
                        if (current == tail) tail = prev;
                        current = prev.Next;
                    }
                }
                else
                {
                    prev = current;
                    current = current.Next;
                }

                if (head != null) DisplayQueue();
            }

            Console.WriteLine($"Average Turnaround Time: {totalTurnAroundTime / totalCount:F2}");
            Console.WriteLine($"Average Waiting Time: {waitTimeTotal / totalCount:F2}");
        }

        public void DisplayQueue()
        {
            if (head == null) return;
            Node temp = head;
            Console.Write("Queue State: ");
            do
            {
                Console.Write($"P{temp.PID}({temp.RemainingTime}) ");
                temp = temp.Next;
            } while (temp != head);
            Console.WriteLine();
        }

        public static void Main()
        {
            RoundSystem scheduler = new RoundSystem();
            scheduler.AddAProcess(1, 10, 1);
            scheduler.AddAProcess(2, 5, 2);
            scheduler.AddAProcess(3, 8, 1);

            scheduler.SimulateList(4);
        }
    }
}
