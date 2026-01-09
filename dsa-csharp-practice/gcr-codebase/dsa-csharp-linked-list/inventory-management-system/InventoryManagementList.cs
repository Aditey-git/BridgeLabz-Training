using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.LinkedList.inventory_management_system
{
    internal class InventoryManagementList
    {
        private Node head;

        public void AddItemToList(string name, int id, int quantity, double price, int position)
        {
            Node newNode = new Node(name, id, quantity, price);

            if (position <= 0 || head == null)
            {
                newNode.Next = head;
                head = newNode;
                return;
            }

            Node curr = head;
            for (int i = 0; curr.Next != null && i < position - 1; i++)
            {
                curr = curr.Next;
            }

            newNode.Next = curr.Next;
            curr.Next = newNode;
        }

        public void RemoveItemFromList(int id)
        {
            if (head == null) return;

            if (head.ID == id)
            {
                head = head.Next;
                return;
            }

            Node curr = head;
            while (curr.Next != null && curr.Next.ID != id)
            {
                curr = curr.Next;
            }

            if (curr.Next != null)
            {
                curr.Next = curr.Next.Next;
            }
        }

        public void UpdateQuantityOfProduct(int id, int newQuantity)
        {
            Node curr = head;
            while (curr != null)
            {
                if (curr.ID == id)
                {
                    curr.Quantity = newQuantity;
                    return;
                }
                curr = curr.Next;
            }
        }

        public void SearchByName(int? id = null, string name = null)
        {
            Node curr = head;
            while (curr != null)
            {
                if ((id.HasValue && curr.ID == id.Value) ||
                    (name != null && curr.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine($"Found: {curr.Name} (ID: {curr.ID}), Qty: {curr.Quantity}, Price: ${curr.Price}");
                    return;
                }
                curr = curr.Next;
            }
            Console.WriteLine("Item not found.");
        }

        public void TotalValueDisplay()
        {
            double total = 0;
            Node curr = head;
            while (curr != null)
            {
                total += (curr.Price * curr.Quantity);
                curr = curr.Next;
            }
            Console.WriteLine($"Total Inventory Value: ${total:F2}");
        }

        public void SortList(bool byName, bool ascending)
        {
            if (head == null || head.Next == null) return;

            bool swapped;
            do
            {
                swapped = false;
                Node current = head;
                Node prev = null;

                while (current != null && current.Next != null)
                {
                    bool shouldSwap = false;
                    if (byName)
                    {
                        int comparison = string.Compare(current.Name, current.Next.Name);
                        shouldSwap = ascending ? comparison > 0 : comparison < 0;
                    }
                    else
                    {
                        shouldSwap = ascending ? current.Price > current.Next.Price : current.Price < current.Next.Price;
                    }

                    if (shouldSwap)
                    {
                        Node nextNode = current.Next;
                        current.Next = nextNode.Next;
                        nextNode.Next = current;

                        if (prev == null) head = nextNode;
                        else prev.Next = nextNode;

                        prev = nextNode;
                        swapped = true;
                    }
                    else
                    {
                        prev = current;
                        current = current.Next;
                    }
                }
            } while (swapped);
        }

        public void DisplayDetails()
        {
            Node curr = head;
            while (curr != null)
            {
                Console.WriteLine($"ID: {curr.ID} | {curr.Name} | Qty: {curr.Quantity} | Price: ${curr.Price}");
                curr = curr.Next;
            }
        }

        public static void Main()
        {
            InventoryManagementList inv = new InventoryManagementList();
            inv.AddItemToList("Laptop", 1, 10, 1200.00, 0);
            inv.AddItemToList("Mouse", 2, 50, 25.50, 1);
            inv.AddItemToList("Keyboard", 3, 30, 45.00, 1);

            Console.WriteLine("Original Inventory:");
            inv.DisplayDetails();

            inv.TotalValueDisplay();

            Console.WriteLine("Sorting by Price (Descending):");
            inv.SortList(false, false);
            inv.DisplayDetails();

            Console.WriteLine("Updating Quantity of ID 2 to 60 and searching for 'Laptop':");
            inv.UpdateQuantityOfProduct(2, 60);
            inv.SearchByName(name: "Laptop");
        }
    }
}
