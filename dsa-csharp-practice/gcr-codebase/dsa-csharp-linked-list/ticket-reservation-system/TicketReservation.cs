using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.LinkedList.ticket_reservation_system
{
    internal class TicketReservation
    {
        private Node head = null;
        private Node tail = null;

        public void AddTicket(int id, string name, string movie, string seat, string time)
        {
            Node newTicketNode = new Node(id, name, movie, seat, time);

            if (head == null)
            {
                head = newTicketNode;
                tail = newTicketNode;
                newTicketNode.Next = head;
            }
            else
            {
                tail.Next = newTicketNode;
                tail = newTicketNode;
                tail.Next = head;
            }
        }

        public void RemoveTicketFromList(int id)
        {
            if (head == null) return;

            Node curr = head;
            Node prev = tail;

            do
            {
                if (curr.TicketID == id)
                {
                    if (curr == head && curr == tail)
                    {
                        head = null;
                        tail = null;
                    }
                    else
                    {
                        prev.Next = curr.Next;
                        if (curr == head) head = prev.Next;
                        if (curr == tail) tail = prev;
                    }
                    Console.WriteLine($"Ticket {id} removed.");
                    return;
                }
                prev = curr;
                curr = curr.Next;
            } while (curr != head);

            Console.WriteLine("Ticket ID not found.");
        }

        public void TicketsDisplay()
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked.");
                return;
            }

            Node temp = head;
            Console.WriteLine(" Current Booked Tickets ");
            do
            {
                Console.WriteLine($"ID: {temp.TicketID} | Customer: {temp.CustomerName} | Movie: {temp.MovieName} | Seat: {temp.SeatNumber} | Time: {temp.BookingTime}");
                temp = temp.Next;
            } while (temp != head);
        }

        public void SearchTicket(string query)
        {
            if (head == null) return;

            bool isFound = false;
            Node temp = head;
            do
            {
                if (temp.CustomerName.Equals(query, StringComparison.OrdinalIgnoreCase) ||
                    temp.MovieName.Equals(query, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Found: Ticket {temp.TicketID} for {temp.CustomerName} - {temp.MovieName}");
                    isFound = true;
                }
                temp = temp.Next;
            } while (temp != head);

            if (!isFound) Console.WriteLine($"No records found for: {query}");
        }

        public int TotalTicketsGet()
        {
            if (head == null) return 0;

            int count = 0;
            Node temp = head;
            do
            {
                count++;
                temp = temp.Next;
            } while (temp != head);

            return count;
        }

        public static void Main()
        {
            TicketReservation system = new TicketReservation();

            system.AddTicket(101, "John Doe", "Avatar 2", "A12", "14:30");
            system.AddTicket(102, "Jane Smith", "Inception", "B05", "18:00");
            system.AddTicket(103, "Sam Wilson", "Avatar 2", "A13", "14:30");

            system.TicketsDisplay();

            Console.WriteLine($"Total Booked Tickets: {system.TotalTicketsGet()}");

            Console.WriteLine("Searching for 'Avatar 2':");
            system.SearchTicket("Avatar 2");

            Console.WriteLine("Removing Ticket 102...");
            system.RemoveTicketFromList(102);
            system.TicketsDisplay();
        }
    }
}

