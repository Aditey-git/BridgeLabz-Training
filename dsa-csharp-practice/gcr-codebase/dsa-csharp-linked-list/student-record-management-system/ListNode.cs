using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.LinkedList.student_record_management_system
{
    internal class ListNode
    {
        public int RollNumber;
        public string Name;
        public int Age;
        public char Grade;
        public ListNode Next;

        public ListNode(int rollNum, string name,int age,char grade)
        {
            this.RollNumber = rollNum;
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
            Next = null;
        }


    }

}
