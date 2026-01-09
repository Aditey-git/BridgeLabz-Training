using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.LinkedList.inventory_management_system
{
    internal class Node
    {
        public string Name;
        public int ID;
        public int Quantity;
        public double Price;
        public Node Next;

        public Node(string name, int id, int quantity, double price)
        {
            Name = name;
            ID = id;
            Quantity = quantity;
            Price = price;
            Next = null;
        }
    }
}
