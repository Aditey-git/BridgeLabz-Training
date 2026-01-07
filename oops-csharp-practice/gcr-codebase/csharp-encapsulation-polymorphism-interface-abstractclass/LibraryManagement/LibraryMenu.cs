using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.LibraryManagement
{
    internal class LibraryMenu
    {
        private IReservable reservationUtility;

        public void Menu()
        {
            reservationUtility = new ReservationUtility();

            LibraryItem item =
                new Book("B101", "Clean Code", "Robert C. Martin");

            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("Press 1 : Show item details");
                Console.WriteLine("Press 2 : Check availability");
                Console.WriteLine("Press 3 : Reserve item");
                Console.WriteLine("Press 4 : Loan duration");
                Console.WriteLine("Press 5 : Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        item.ItemDetailsGetter();
                        break;

                    case 2:
                        Console.WriteLine(reservationUtility.AvailbilityCheck(item));
                        break;

                    case 3:
                        reservationUtility.ItemReserve(item);
                        break;

                    case 4:
                        Console.WriteLine(item.LoanDurationGetter());
                        break;

                    case 5:
                        isTrue = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}
