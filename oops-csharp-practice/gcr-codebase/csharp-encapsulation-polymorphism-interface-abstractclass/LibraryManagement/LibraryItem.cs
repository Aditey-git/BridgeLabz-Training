using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.LibraryManagement
{
    internal abstract class LibraryItem
    {
        public string ItemId { get; private set; }
        public string ItemTitle { get; private set; }
        public string ItemAuthor { get; private set; }

        protected LibraryItem(string itemId, string title, string author)
        {
            this.ItemId = itemId;
            this.ItemTitle = title;
            this.ItemAuthor = author;
        }

        public void ItemDetailsGetter()
        {
            Console.WriteLine($"ID : {ItemId}");
            Console.WriteLine($"Title : {ItemTitle}");
            Console.WriteLine($"Author : {ItemAuthor}");
        }

        public abstract int LoanDurationGetter();
    }
}
