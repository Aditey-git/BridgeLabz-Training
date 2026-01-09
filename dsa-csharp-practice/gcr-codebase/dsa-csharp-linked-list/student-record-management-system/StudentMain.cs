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

            //Adding elements in the linked list at the last
            list.AddAtLast(101, "Rahul Sharma", 20, 'A'); 
            list.AddAtLast(102, "Neha Verma", 21, 'B');
            list.AddAtLast(103, "Amit Kumar", 22, 'A');
            list.AddAtLast(104, "Priya Singh", 19, 'C');

            list.DisplayAllDetails(); //Display students record

            //Adding element at the start
            list.AddAtStart(201, "Ankit Verma", 20, 'A');


            Console.WriteLine("Displaying details after adding a student at start");
            list.DisplayAllDetails();

            //Adding student at a particular index
            list.AddAtIndex(103, "Amit Kumar", 22, 'A', 3);

            Console.WriteLine("Displaying details after adding a student at position 3");
            list.DisplayAllDetails();

            //Deleting Student's record by roll number
            list.DeleteByRollNumber(102);

            Console.WriteLine("Displaying details after deleting a student by roll number 102");
            list.DisplayAllDetails();
            Console.WriteLine("<------------------------>");

            //Searching student by roll number 103
            list.SearchByRollNumber(103);

            
            //Changing the grade of student with roll number 103
            list.ChangeUpgrade(103, 'C');

            Console.WriteLine("Displaying details after changing grade of student with roll number 103:");
            list.DisplayAllDetails();
        }
    }
}
