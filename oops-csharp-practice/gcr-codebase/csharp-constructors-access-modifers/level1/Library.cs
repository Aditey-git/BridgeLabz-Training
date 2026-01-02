using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.Constructor_Instance.level1
{
    internal class Library
    {
        public string title;
        public string author;
        public double price;
        public bool availability;

        public Library(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            availability = true;  
        }

        // Method to borrow a book
        public void BorrowBook(){
            if (availability){
                availability = false;
                Console.WriteLine("You have borrowed this book.");
            }
            else{
                Console.WriteLine("Currently not available.");
            }
        }


        // Method to display book details
        public void BookDetailsDisplay()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: ₹{price}");
            Console.WriteLine($"Availability:{(availability ? "Available" : "Not Available")}");
        }

        public static void LibraryManagement()
        {
            Library book = new Library("book 1", "Aditey", 99);

            book.BookDetailsDisplay();
            book.BorrowBook();     
            book.BorrowBook();     
            book.BookDetailsDisplay();
        }
    }
}
