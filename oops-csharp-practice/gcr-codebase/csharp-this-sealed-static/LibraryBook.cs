using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.ThisSealedStatic
{
    internal class LibraryBook
    {
        // static variable shared across all books
        public static string LibraryName = "GLA Library";

        //readonly variable
        public readonly string isbn;

        //instance variables
        public string Title;
        public string Author;

        //constructor using 'this' keyword
        public LibraryBook(string Title, string Author, string isbn)
        {
            this.Title = Title;
            this.Author = Author;
            this.isbn = isbn;
        }

        // static method
        public static void LibraryNameDisplay()
        {
            Console.WriteLine("Library Name: " + LibraryName);
        }

        // instance method
        public void BookDetailsDisplay(object obj)
        {
            // using 'is' operator
            if (obj is LibraryBook)
            {
                Console.WriteLine("Title: " + Title);
                Console.WriteLine("Author: " + Author);
                Console.WriteLine("ISBN: " + isbn);
            }
            else
            {
                Console.WriteLine("Object is not a Book instance");
            }
        }
    }


    internal class BookMangage
    {
        static void Library()
        {
            LibraryBook b1 = new LibraryBook("Clean Code", "Robert C. Martin", "ISBN001");
            LibraryBook b2 = new LibraryBook("The Pragmatic Programmer", "Andrew Hunt", "ISBN002");

            LibraryBook.LibraryNameDisplay();
            Console.WriteLine();

            b1.BookDetailsDisplay(b1);
            Console.WriteLine();
            b2.BookDetailsDisplay(b2);
        }
    }
}
