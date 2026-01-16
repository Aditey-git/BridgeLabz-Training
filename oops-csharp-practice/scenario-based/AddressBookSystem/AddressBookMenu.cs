using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.AddressBookSystem
{
    internal class AddressBookMenu
    {
        private IAddressBook addressBook;
        private MultipleAddressBookUtility multipleAddressBook;

        public void Menu()
        {
            multipleAddressBook = new MultipleAddressBookUtility();
            addressBook = new AddressBookUtility(multipleAddressBook);

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("=============================================================");
                Console.WriteLine("\n\nBelow are the functionalities of the address book =>");
                Console.WriteLine("1. Add a contact.");
                Console.WriteLine("2. Update a contact.");
                Console.WriteLine("3. Delete a contact.");
                Console.WriteLine("4. Add Multiple contacts.");
                Console.WriteLine("5. Add A Address Book.");
                Console.WriteLine("6. Search a Contact by city or state.");
                Console.WriteLine("7. Exit.");

                Console.Write("Choose:");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        addressBook.AddAContact();
                        break;
                    case 2:
                        addressBook.UpdateContact();
                        break;
                    case 3:
                        addressBook.DeleteContactUsingName();
                        break;
                    case 4:
                        addressBook.AddMultipleContacts();
                        break;
                    case 5:
                        multipleAddressBook.AddAAddressBook();
                        break;
                    case 6:
                        addressBook.SearchByCityOrState();
                        break;
                    case 7:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Wrong Choice!");
                        break;
                }
            }
        }
    }
}
