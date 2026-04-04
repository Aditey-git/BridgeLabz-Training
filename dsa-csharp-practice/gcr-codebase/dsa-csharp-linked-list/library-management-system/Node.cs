using BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.LibraryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.LinkedList.library_management_system
{
    internal class Node
    {
        public string Title;
        public string Author;
        public string Genre;
        public int BookID;
        public bool IsAvailable;
        public Node Next;
        public Node Prev;

        public Node(string title, string author, string genre, int id, bool status)
        {
            Title = title;
            Author = author;
            Genre = genre;
            BookID = id;
            IsAvailable = status;
            Next = null;
            Prev = null;
        }
    }
}
