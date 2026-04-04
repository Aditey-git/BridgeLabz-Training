using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.LinkedList.student_record_management_system
{
    internal class SinglyLinkedList
    {
        private ListNode head;

        public void AddAtLast(int rollNum, string name, int age, char grade)
        {

            ListNode newNode = new ListNode(rollNum, name, age, grade);

            if (head == null)
            {
                head = newNode;
                return;
            }

            

            ListNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
        }


        public void AddAtStart(int rollNum, string name, int age, char grade)
        {
            ListNode newNode = new ListNode(rollNum, name, age, grade);

            newNode.Next = head;
            head = newNode;
        }


        public void AddAtIndex(int rollNum, string name, int age, char grade, int position)
        {

            if(position == 1)
            {
                AddAtStart(rollNum, name, age, grade);
                return;
            }

            ListNode newNode = new ListNode(rollNum, name, age, grade);

            ListNode temp = head;

            int count = 1;

            while (count < position - 1 && temp != null)
            {
                temp = temp.Next;
                count++;
            }

            if (temp == null) {
                Console.WriteLine("Position Invalid!");
                return;
            }

            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        public void DeleteByRollNumber(int rollNum) 
        {

            if(head == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }


            if(head.RollNumber == rollNum)
            {
                head = head.Next;
                return;
            }

            ListNode prev = null;
            ListNode temp = head;
            while (temp != null)
            {
                if(temp.RollNumber == rollNum)
                {
                    break;
                }
                prev = temp;
                temp = temp.Next;
            }

            if(temp == null)
            {
                Console.WriteLine("Roll Number not found");
                return;
            }

            prev.Next = temp.Next;
        }

        
        public void SearchByRollNumber(int rollNum)
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }


            if (head.RollNumber == rollNum)
            {
                Console.WriteLine($"Name: {head.Name}");
                Console.WriteLine($"Age: {head.Age}");
                Console.WriteLine($"Grade: {head.Grade}");
                return;
            }

            ListNode temp = head;

            while (temp != null)
            {
                if (temp.RollNumber == rollNum)
                {
                    break;
                }
                temp = temp.Next;
            }


            if( temp == null)
            {
                Console.WriteLine("Invalid RollNumber!");
                return;
            }

            Console.WriteLine($"Name: {temp.Name}");
            Console.WriteLine($"Age: {temp.Age}");
            Console.WriteLine($"Grade: {temp.Grade}");
        }


        public void DisplayAllDetails()
        {

            if (head == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }


            ListNode temp = head;
            while (temp != null)
            {
                Console.WriteLine($"Roll Number: {temp.RollNumber}");
                Console.WriteLine($"Name: {temp.Name}");
                Console.WriteLine($"Age: {temp.Age}");
                Console.WriteLine($"Grade: {temp.Grade}");
                Console.WriteLine("--------------------------");

                temp = temp.Next;
            }
        }


        public void ChangeUpgrade(int rollNum, char grade)
        {
            

            if(head == null)
            {
                Console.Write("List is Empty.");
                return;
            }

            ListNode temp = head;

            while (temp != null)
            {
                if(temp.RollNumber == rollNum)
                {
                    temp.Grade = grade;
                    return;
                }

                temp = temp.Next;
            }

            Console.WriteLine("Roll number not found");

        }
    }
}
