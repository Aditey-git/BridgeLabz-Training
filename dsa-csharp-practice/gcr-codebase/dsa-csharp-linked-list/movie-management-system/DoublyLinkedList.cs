using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.LinkedList.Movie_management_system
{
    internal class DoublyLinkedList
    {
        private ListNode head;
        private ListNode tail;

        public void AddAtStart(string title, string director, int yearOfRelease, int rating)
        {
            ListNode newNode = new ListNode(title, director, yearOfRelease, rating);

            if(head == null)
            {
                head = newNode;
                tail = newNode;
                return;
            }

            newNode.next = head;
            head.prev = newNode;
            head = newNode;
        }

        public void AddAtEnd(string title, string director, int yearOfRelease, int rating)
        {
            ListNode newNode = new ListNode(title, director, yearOfRelease, rating);

            if(tail == null)
            {
                tail = newNode;
                head = newNode;
                return;
            }

            tail.next = newNode;
            newNode.prev = tail;
            tail = newNode;
        }


        public void AddAtPosition(string title, string director, int year, int rating, int position)
        {
            if (position <= 1)
            {
                AddAtStart(title, director, year, rating);
                return;
            }

            ListNode temp = head;
            int count = 1;

            while (count < position - 1 && temp != null)
            {
                temp = temp.next;
                count++;
            }

            if (temp == null || temp.next == null)
            {
                AddAtEnd(title, director, year, rating);
                return;
            }

            ListNode newNode = new ListNode(title, director, year, rating);

            newNode.next = temp.next;
            newNode.prev = temp;

            temp.next.prev = newNode;
            temp.next = newNode;
        }


        public void RemoveByTitle(string title)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            ListNode temp = head;

            while (temp != null)
            {
                if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    // If only one node
                    if (temp == head && temp == tail)
                    {
                        head = null;
                        tail = null;
                    }
                    // If head node
                    else if (temp == head)
                    {
                        head = head.next;
                        head.prev = null;
                    }
                    // If tail node
                    else if (temp == tail)
                    {
                        tail = tail.prev;
                        tail.next = null;
                    }
                    // Middle node
                    else
                    {
                        temp.prev.next = temp.next;
                        temp.next.prev = temp.prev;
                    }

                    Console.WriteLine("Movie removed successfully.");
                    return;
                }

                temp = temp.next;
            }

            Console.WriteLine("Movie not found.");
        }

        public void SearchByDirector(string director)
        {
            ListNode temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Director.Equals(director, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayMovie(temp);
                    found = true;
                }
                temp = temp.next;
            }

            if (!found)
                Console.WriteLine("No movies found for this director.");
        }


        public void SearchByRating(int rating)
        {
            ListNode temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Rating == rating)
                {
                    DisplayMovie(temp);
                    found = true;
                }
                temp = temp.next;
            }

            if (!found)
                Console.WriteLine("No movies found with this rating.");
        }


        public void UpdateRating(string title, int newRating)
        {
            ListNode temp = head;

            while (temp != null)
            {
                if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    temp.Rating = newRating;
                    Console.WriteLine("Rating updated successfully.");
                    return;
                }
                temp = temp.next;
            }

            Console.WriteLine("Movie not found.");
        }


        public void ForwardDisplay()
        {
            if (head == null)
            {
                Console.WriteLine("No movies to display.");
                return;
            }

            ListNode temp = head;

            Console.WriteLine("\nMovies (Forward Order):");
            while (temp != null)
            {
                DisplayMovie(temp);
                temp = temp.next;
            }
        }


        public void ReverseDisplay()
        {
            if (tail == null)
            {
                Console.WriteLine("No movies to display.");
                return;
            }

            ListNode temp = tail;

            Console.WriteLine("\nMovies (Reverse Order):");
            while (temp != null)
            {
                DisplayMovie(temp);
                temp = temp.prev;
            }
        }



        private void DisplayMovie(ListNode node)
        {
            Console.WriteLine($"Title: {node.Title}, Director: {node.Director}, Year: {node.YearOfRelease}, Rating: {node.Rating}");
        }
    }
}
