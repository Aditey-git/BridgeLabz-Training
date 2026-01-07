using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.LibraryManagement
{
    internal class ReservationUtility : IReservable
    {
        private string BorrowerId = "BR-7788";
        private bool isAvailable = true;

        public void ItemReserve(LibraryItem item)
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine($"Item reserved by {BorrowerId}");
            }
            else
            {
                Console.WriteLine("Item already reserved");
            }
        }

        public bool AvailbilityCheck(LibraryItem item)
        {
            return isAvailable;
        }
    }
}
