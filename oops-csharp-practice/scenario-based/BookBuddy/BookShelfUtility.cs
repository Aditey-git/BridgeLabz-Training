using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.BookBuddy
{
    internal class BookShelfUtility : IBookShelf
    {
        public string[] BookFetch()
        {
            string[] booksArray =
            {
                "The Hidden River - Vikram Joshi",
                "Echoes of Tomorrow - Pooja Nair",
                "Shadows in the Rain - Rohit Khanna",
                "The Forgotten Path - Sneha Iyer",
                "Logic & Legends - Aditya Mishra",
                "Whispers of the Night - Kavya Menon",
                "Roads Untraveled - Saurabh Patel"
            };

            return booksArray;
        }

        public void AddABook(ref string[] booksArr, string bookUser)
        {
            if (!bookUser.Contains(" - "))
            {
                Console.WriteLine("Invalid format! Use: Title - Author");
                return;
            }

            string[] partsArr = bookUser.Split(" - ");

            if (partsArr.Length != 2 ||
                string.IsNullOrWhiteSpace(partsArr[0]) ||
                string.IsNullOrWhiteSpace(partsArr[1]))
            {
                Console.WriteLine("Invalid format! Title or Author missing.");
                return;
            }

            int newSize = booksArr.Length + 1;
            string[] newBooks = new string[newSize];

            for (int i = 0; i < booksArr.Length; i++)
            {
                newBooks[i] = booksArr[i];
            }

            newBooks[newSize - 1] = bookUser;
            booksArr = newBooks;

            Console.WriteLine("Book added successfully!");
        }

        public void BooksSort(ref string[] booksArr)
        {
            int n = booksArr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    string title1 = booksArr[j].Split(" - ")[0];
                    string title2 = booksArr[j + 1].Split(" - ")[0];

                    if (string.Compare(title1, title2) > 0)
                    {
                        string temp = booksArr[j];
                        booksArr[j] = booksArr[j + 1];
                        booksArr[j + 1] = temp;
                    }
                }
            }
        }

        public void SearchAuthor(string[] booksArr, string author)
        {
            bool foundOrNot = false;

            for (int i = 0; i < booksArr.Length; i++)
            {
                string[] partsArr = booksArr[i].Split(" - ");

                if (partsArr.Length == 2 &&
                    partsArr[1].ToLower() == author.ToLower())
                {
                    Console.WriteLine(booksArr[i]);
                    foundOrNot = true;
                }
            }

            if (!foundOrNot)
                Console.WriteLine("No books found for this author.");
        }

        public void DisplayBooks(string[] booksArr)
        {
            for (int i = 0; i < booksArr.Length; i++)
            {
                Console.WriteLine(booksArr[i]);
            }
        }
    }
}