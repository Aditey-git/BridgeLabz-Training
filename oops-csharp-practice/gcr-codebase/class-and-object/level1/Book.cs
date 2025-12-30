using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.level1
{
    internal class Book
    {
        // Book attributes
        public string title;
        public string author;
        public double price;


        static void BookDetails()
        {
            //Object Creation
            Book book = new Book();

            book.title = "XYZ";
            book.author = "Abc";
            book.price = 500;

            book.DisplayDetails();
        }


        //Method to display book details
        public void DisplayDetails()
        {
            Console.WriteLine("Book Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price);
        }
    }
}
