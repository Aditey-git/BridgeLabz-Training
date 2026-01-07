using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.LibraryManagement
{
    internal class Book : LibraryItem
    {
        public Book(string bookId, string bookTitle, string bookAuthor)
            : base(bookId, bookTitle, bookAuthor)
        {
        }

        public override int LoanDurationGetter()
        {
            return 14;
        }
    }
}
