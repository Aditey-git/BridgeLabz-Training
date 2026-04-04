using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.BookBuddy
{
    internal interface IBookShelf
    {
        public void AddABook(ref string[] books, string bookFromUser);
        public string[] BookFetch();
        public void BooksSort(ref string[] books);
        public void SearchAuthor(string[] books, string author);
        public void DisplayBooks(string[] books);
    }
}
