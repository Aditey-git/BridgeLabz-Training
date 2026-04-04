using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.LinkedList.task_scheduler
{
    internal class ListMain
    {
        public static void Main()
        {
            CircularLinkedListTask scheduler = new CircularLinkedListTask();
            scheduler.AddTask(1, "Fix Bug", 1, "2026-01-10", 0);
            scheduler.AddTask(2, "Refactor", 2, "2026-01-15", 1);
            scheduler.AddTask(3, "Update Docs", 3, "2026-01-20", 2);

            Console.WriteLine("All Tasks:");
            scheduler.DisplayAll();


            scheduler.ViewAndNext();
            scheduler.ViewAndNext();


            scheduler.SearchByPriority(2);


            scheduler.RemoveTask(1);
            scheduler.DisplayAll();
        }
    }
}
}
