using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.LinkedList.Movie_management_system
{
    internal class ListNode
    {
        public string Title;
        public string Director;
        public int YearOfRelease;
        public int Rating;
        public ListNode prev;
        public ListNode next;

        public ListNode(string title, string director, int yearOfRelease, int rating)
        {
            this.Title = title;
            this.Director = director;
            this.YearOfRelease = yearOfRelease;
            this.Rating = rating;
            prev = null;
            next = null;
        }
    }
}
