using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.Constructor_Instance.level1
{
    internal class BookManagementSystem
    {
        public string ISBN;

        protected string title;

        private string author;

        // Constructor
        public BookManagementSystem(string isbn, string title, string author)
        {
            ISBN = isbn;
            this.title = title;
            this.author = author;
        }

        // Public method to set author
        public void AuthorSetter(string author)
        {
            this.author = author;
        }

        // Public method to get author
        public string AuthorGetter()
        {
            return author;
        }
    }

    // Subclass demonstrating protected and public access
    internal class BookE : BookManagementSystem
    {
        public string formatOfFile;

        public BookE(string isbn, string title, string author, string format)
            : base(isbn, title, author)
        {
            formatOfFile = format;
        }

        public void DisplayEBookDetails()
        {
            Console.WriteLine($"ISBN: {ISBN}");     
            Console.WriteLine($"Title: {title}");    
            Console.WriteLine($"Author: {AuthorGetter()}"); 
            Console.WriteLine($"Format: {formatOfFile}");
        }
    }

    internal class ProgramClassLibrary
    {
        static void BookManage()
        {
            BookE ebook = new BookE("978-0132350884", "Book1", "Aditey", "PDF");

            ebook.DisplayEBookDetails();

            // Modify author using setter
            ebook.AuthorSetter("Sambhav Tiwari");
            Console.WriteLine("Updated Author: " + ebook.AuthorGetter());
        }
    }
}
