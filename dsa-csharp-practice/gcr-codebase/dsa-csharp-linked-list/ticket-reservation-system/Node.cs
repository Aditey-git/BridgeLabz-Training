using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.LinkedList.ticket_reservation_system
{
    internal class Node
    {
        public int TicketID;
        public string CustomerName;
        public string MovieName;
        public string SeatNumber;
        public string BookingTime;
        public Node Next;

        public Node(int id, string name, string movie, string seat, string time)
        {
            TicketID = id;
            CustomerName = name;
            MovieName = movie;
            SeatNumber = seat;
            BookingTime = time;
            Next = null;
        }
    }
}
