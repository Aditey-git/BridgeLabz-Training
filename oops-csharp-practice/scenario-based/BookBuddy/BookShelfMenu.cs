using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.BookBuddy
{
    internal class BookShelfMenu
    {
        private IBookShelf booksShelf;

        public void Menu()
        {
            booksShelf = new BookShelfUtility();

            bool isTrueOrNot = true;

            string[] booksArr = booksShelf.BookFetch();



            while (isTrueOrNot)
            {
                Console.WriteLine("Press 1 : To add books");
                Console.WriteLine("Press 2 : To Sort Books");
                Console.WriteLine("Press 3 : To search a book with author name");
                Console.WriteLine("Press 4 : Exit");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter book in the format title - author ");
                        string book = Console.ReadLine();
                        booksShelf.AddABook(ref booksArr, book);
                        booksShelf.DisplayBooks(booksArr);
                        break;

                    case 2:
                        booksShelf.BooksSort(ref booksArr);
                        booksShelf.DisplayBooks(booksArr);
                        break;

                    case 3:
                        Console.WriteLine("Enter the name of the author");
                        string author = Console.ReadLine();
                        booksShelf.SearchAuthor(booksArr, author);
                        break;

                    case 4:
                        isTrueOrNot = false;
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }
            }
        }
    }
}
