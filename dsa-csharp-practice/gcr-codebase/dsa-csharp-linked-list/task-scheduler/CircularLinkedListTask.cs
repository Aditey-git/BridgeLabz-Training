using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.LinkedList.task_scheduler
{
    internal class CircularLinkedListTask
    {
        TaskNode newNode = new TaskNode(id, name, priority, dueDate);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
            newNode.Next = head;
            currentTask = head;
            return;
        }

        if (position <= 0) // Add at beginning
        {
            newNode.Next = head;
            tail.Next = newNode;
            head = newNode;
            return;
        }

        TaskNode current = head;
        int index = 0;
        // Traverse to find position or stop at tail
        while (index < position - 1 && current.Next != head)
        {
            current = current.Next;
            index++;
        }

        newNode.Next = current.Next;
        current.Next = newNode;

        if (current == tail)
        {
            tail = newNode;
        }
    }

    public void RemoveTask(int id)
    {
        if (head == null) return;

        TaskNode current = head;
        TaskNode prev = tail;

        do
        {
            if (current.TaskID == id)
            {
                if (current == head && current == tail)
                {
                    head = tail = currentTask = null;
                }
                else
                {
                    prev.Next = current.Next;
                    if (current == head) head = prev.Next;
                    if (current == tail) tail = prev;
                    if (current == currentTask) currentTask = prev.Next;
                }
                return;
            }
            prev = current;
            current = current.Next;
        } while (current != head);
    }

    public void ViewAndNext()
    {
        if (currentTask == null)
        {
            Console.WriteLine("No tasks in schedule.");
            return;
        }
        Console.WriteLine($"Current Task: [{currentTask.TaskID}] {currentTask.TaskName} | Priority: {currentTask.Priority}");
        currentTask = currentTask.Next;
    }

    public void DisplayAll()
    {
        if (head == null) return;

        TaskNode temp = head;
        do
        {
            Console.WriteLine($"ID: {temp.TaskID}, Name: {temp.TaskName}, Priority: {temp.Priority}, Due: {temp.DueDate}");
            temp = temp.Next;
        } while (temp != head);
    }

    public void SearchByPriority(int priority)
    {
        if (head == null) return;

        TaskNode temp = head;
        bool found = false;
        do
        {
            if (temp.Priority == priority)
            {
                Console.WriteLine($"Found: {temp.TaskName} (ID: {temp.TaskID})");
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);

        if (!found) Console.WriteLine($"No tasks found with priority {priority}");
    }
}
