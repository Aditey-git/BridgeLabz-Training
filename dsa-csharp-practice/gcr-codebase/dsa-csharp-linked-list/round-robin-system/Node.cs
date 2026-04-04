using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.LinkedList.round_robin_system
{
    internal class Node
    {
        public int PID;
        public int BurstTime;
        public int RemainingTime;
        public int Priority;
        public int FinishTime;
        public Node Next;

        public Node(int id, int bt, int p)
        {
            PID = id;
            BurstTime = bt;
            RemainingTime = bt;
            Priority = p;
        }
    }

}
