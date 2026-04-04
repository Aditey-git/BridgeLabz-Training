using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.LinkedList.task_scheduler
{
    internal class ListNode
    {
        public int TaskID;
        public string TaskName;
        public int Priority;
        public string DueDate;
        public ListNode Next;

        public ListNode(int id, string name, int priority, string dueDate)
        {
            TaskID = id;
            TaskName = name;
            Priority = priority;
            DueDate = dueDate;
            Next = null;
        }
    }
}
