using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 Summary =>
This C# program implements a simple menu-driven Cafeteria Management System using arrays.
It stores predefined food items in an array and allows users to view the menu, order items, or finish ordering.
Ordered items are saved in a fixed-size string array, and a counter is used to track the number of orders.
The program validates menu item selection to ensure only valid items are ordered.
It displays the final list of ordered items when the user chooses to finish the order.
 */

namespace BridgeLabzTraining.Scenario_Based.Cafeteria
{
    internal class CafteriaManagement
    {
        // Menu items
        string[] itemMenu =
        {
            "Chilli Potato",
            "Noodles",
            "Coke",
            "Burger",
            "Aloo Parantha",
            "Pizza",
            "Paneer Roll",
            "Dosa",
            "Idli Sambhar",
            "Vada Pao"
        };

        // Stores ordered items
        // Array to store ordered items (max 20 orders)
        string[] orderArray = new string[20];
        int orderCount = 0;

        public void Cafeteria()
        {
            int option;

            do
            {
                Console.WriteLine("\n-------------------- Welcome To My Cafeteria ----------------");
                Console.WriteLine("1. Display Menu");
                Console.WriteLine("2. Order Item");
                Console.WriteLine("3. Finish Order");
                Console.Write("Enter your choice: ");

                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        MenuDisplay(itemMenu);
                        break;

                    case 2:
                        MenuDisplay(itemMenu);
                        Console.Write("Enter item number to order: ");
                        int index = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (index >= 0 && index < itemMenu.Length)
                        {
                            if (orderCount < orderArray.Length)
                            {
                                orderArray[orderCount] = itemMenu[index];
                                orderCount++;
                                Console.WriteLine(itemMenu[index] + " added to your order.");
                            }
                            else
                            {
                                Console.WriteLine("Order limit reached!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid item number!");
                        }
                        break;

                    case 3:
                        FinalOrder();
                        Console.WriteLine("Thank you for visiting GLA Cafeteria!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

            } while (option != 3);
        }
        // Writing a Method to display the menu of the Cafeteria
        public void MenuDisplay(string[] arr)
        {
            Console.WriteLine("\n--------- Cafeteria Menu ---------");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + arr[i]);
            }
        }


        // Writing a method to Print Final Order
        public void FinalOrder()
        {
            Console.WriteLine("\n----------- Your Order -----------");

            if (orderCount == 0)
            {
                Console.WriteLine("No items ordered.");
                return;
            }

            for (int i = 0; i < orderCount; i++)
            {
                Console.WriteLine((i + 1) + ". " + orderArray[i]);
            }
        }


        public static void Main(string[] args)
        {
            CafteriaManagement cafeObj = new CafteriaManagement();
            cafeObj.Cafeteria();
        }
    }
}
