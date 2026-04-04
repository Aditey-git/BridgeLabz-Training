using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.Constructor_Instance.level1
{
    internal class Book
    {
        // Attributes
        public string Title;
        public string Author;
        public double Price;


        // Method to display book details
        public void DisplayBookDetails()
        {
            Console.WriteLine("Title  : " + Title);
            Console.WriteLine("Author : " + Author);
            Console.WriteLine("Price  : " + Price);
        }

        //Default constructor
        public Book()
        {
            Title = "All in One";
            Author = "xyz";
            Price = 100.0;
        }

        // Parameterized constructor
        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

    }
}
