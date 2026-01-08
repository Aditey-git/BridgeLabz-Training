using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.LinkedList.student_record_management_system
{
    internal class StudentMain
    {
        public static void Main(string[] args)
        {
            SinglyLinkedList list = new SinglyLinkedList();

            list.AddAtLast(101, "Rahul Sharma", 20, 'A');
            list.AddAtLast(102, "Neha Verma", 21, 'B');
            list.AddAtLast(103, "Amit Kumar", 22, 'A');
            list.AddAtLast(104, "Priya Singh", 19, 'C');

            list.AddAtStart(201, "Ankit Verma", 20, 'A');


            list.AddAtIndex(103, "Amit Kumar", 22, 'A', 3);

            list.DeleteByRollNumber(102);

            list.SearchByRollNumber(103);

            list.DisplayAllDetails();

            list.ChangeUpgrade(103, 'C');
        }
    }
}
