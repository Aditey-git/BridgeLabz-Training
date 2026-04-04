using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 <summary>
This program implements a simple library management system using a 2D string array.
It allows users to search for books by title and check them out if available.
An admin can securely add or remove books using a passkey.
Each book stores its title, author, and availability status.
The system supports partial title search with case-insensitive matching.
Array resizing logic is used to handle dynamic addition and removal of books.
</summary>
*/

namespace BridgeLabzTraining.Scenario_Based.day3
{
    internal class Library
    {
        // 2D array to store book details
        string[,] books = {
                            { "Clean Code", "Robert C. Martin", "available" },
                            { "The Pragmatic Programmer", "Andrew Hunt", "available" },
                            { "C# in Depth", "Jon Skeet", "available" },
                            { "Design Patterns", "Erich Gamma", "available" },
                            { "Refactoring", "Martin Fowler", "available" },
                            { "Head First Java", "Kathy Sierra", "available" }
                            };


        //Private passkey for admin authentication
        private int passkey = 1234;


        //Entry method for library management
        public void LibraryManagement()
        {
            Console.WriteLine(" Enter whether you are an user or admin: ");
            string inputString = Console.ReadLine();

            if(string.Equals(inputString.ToLower(), "admin"))
            {
                Console.WriteLine("Enter the passkey to proceed: ");
                int passkeyInput = Convert.ToInt32(Console.ReadLine());
                if(passkeyInput != passkey)
                {
                    Console.WriteLine("Invalid passkey! You cannot proceed.");
                    return;
                }
                else
                {
                    //Admin options
                    Console.WriteLine("Enter 1 to Add Book.");
                    Console.WriteLine("Enter 2 to remove a Book.");
                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            AddABook();
                            break;
                        case 2:
                            RemoveABook();
                            break;
                    }
                }
            }

            else
            {
                // Normal user can search for books
                SearchBook();
            }
        }


        // Method to search a book by title or partial title
        public void SearchBook()
        {
            Console.WriteLine("Enter the title or partial title of book to be searched");
            string titleOfBook = Console.ReadLine();

            for (int i = 0; i < this.books.GetLength(0); i++)
            {
                if (this.books[i, 0].ToLower().StartsWith(titleOfBook.ToLower()))
                {
                    DisplayBook(i);
                    if (isAvailableCheck(i))
                    {
                        Console.WriteLine("Do you want to checkout this book? Enter 1 for Yes AND 2 for No");
                        int answer = Convert.ToInt32(Console.ReadLine());
                        if (answer == 1)
                        {
                            CheckoutBook(i);
                            Console.WriteLine("You have checked out this book");
                        }
                        else
                        {
                            Console.WriteLine("Thanks For Visiting!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The book is not available for checkout!");
                    }
                }

            }
        }


        // Method to display book details
        public void DisplayBook (int i)
        {
            Console.WriteLine("Title: " + this.books[i,0]);
            Console.WriteLine("Author: " + this.books[i,1]);
            Console.WriteLine("Status: " + this.books[i,2]);
        }


        // Method to check availability status of a book
        public bool isAvailableCheck(int i)
        {
            return this.books[i, 2] == "available";
        }


        // Method to checkout a book
        public void CheckoutBook(int i)
        {
            this.books[i, 2] = "checked out";
        }


        // Method to add a book by title (admin only)
        public void AddABook()
        {
            string[,] newBooks = new string[this.books.GetLength(0) + 1, 3];

            for(int i = 0; i < this.books.GetLength(0); i++)
            {
                for(int j = 0; j < this.books.GetLength(1); j++)
                {
                    newBooks[i, j] = this.books[i, j];
                }
            }

            Console.WriteLine("Enter Title of new book: ");
            newBooks[this.books.GetLength(0) , 0] = Console.ReadLine();

            Console.WriteLine("Enter Author of the book: ");
            newBooks[this.books.GetLength(0) , 1] = Console.ReadLine();

            newBooks[this.books.GetLength(0) , 2] = "available";


            this.books = newBooks;
        }


        // Method to remove a book by title (admin only)
        public void RemoveABook()
        {

            string[,] newBooks = new string[this.books.GetLength(0) - 1, 3];

            int newBooksI = 0;
        

            Console.WriteLine("Enter the title of the book to be removed: ");
            string titleToBeRemoved = Console.ReadLine();

            for(int i = 0; i < this.books.GetLength(0); i++)
            {
                if (this.books[i, 0].ToLower() != titleToBeRemoved.ToLower())
                {
                    for (int j = 0; j < this.books.GetLength(1); j++)
                    {
                        newBooks[newBooksI, j] = this.books[i, j];
                    }
                    newBooksI++;
                }
            }

            this.books = newBooks;
        }
    }
}
