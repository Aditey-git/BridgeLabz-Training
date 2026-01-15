using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.AddressBookSystem
{
    internal class AddressBookMenu
    {
        private IAddressBook AddressBook;

        public void Menu()
        {
            AddressBook = new AddressBookUtility();

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Below are the functionalities of the address book =>");
                Console.WriteLine("1. Add a contact.");
                Console.WriteLine("2. Update a contact.");
                Console.WriteLine("3. Delete a contact.");
                Console.WriteLine("4. Add Multiple contacts.");
                Console.WriteLine("5. Exit");

                Console.Write("Choose:");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddressBook.AddAContact();
                        break;
                    case 2:
                        AddressBook.UpdateContact();
                        break;
                    case 3:
                        AddressBook.DeleteContactUsingName();
                        break;
                    case 4:
                        AddressBook.AddMultipleContacts();
                        break;
                    case 5:
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
