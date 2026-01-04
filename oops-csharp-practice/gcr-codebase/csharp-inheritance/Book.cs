using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.Inheritance
{
    internal class Book
    {
        public string TitleOfBook;
        public int YearPublished;

        public Book(string titleOfBook, int publicationOfYear)
        {
            TitleOfBook = titleOfBook;
            YearPublished = publicationOfYear;
        }

        // Virtual method
        public virtual void InfoDisplay()
        {
            Console.WriteLine("Book Details:");
            Console.WriteLine($"Title            : {TitleOfBook}");
            Console.WriteLine($"Publication Year : {YearPublished}");
        }
    }

    // Subclass
    class AuthorSubclass : Book
    {
        public string NameOfBook;
        public string Biodata;

        public AuthorSubclass(string titleOfBook, int yearPublished, string nameOfBook, string bioOfBook)
            : base(titleOfBook, yearPublished)
        {
            NameOfBook = nameOfBook;
            Biodata = bioOfBook;
        }

        // Overridden method
        public override void InfoDisplay()
        {
            base.InfoDisplay();
            Console.WriteLine("Author Details:");
            Console.WriteLine($"Name : {NameOfBook}");
            Console.WriteLine($"Bio  : {Biodata}");
        }
    }

    class LIbraryManagement
    {
        static void BookManagement()
        {
            // Creating Author object (inherits Book)
            Book book1 = new AuthorSubclass(
                "Clean Code",
                2008,
                "Robert C. Martin",
                "Software engineer and author known for clean coding practices."
            );

            // Polymorphic call
            book1.InfoDisplay();
        }
    }
}
