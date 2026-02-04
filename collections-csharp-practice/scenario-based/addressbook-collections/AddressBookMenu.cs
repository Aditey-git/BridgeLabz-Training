using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBookMenu
    {
        private IAddressBook addressBook;

        public void Menu()
        {
            
            addressBook = new AddressBookUtility();

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
                Console.WriteLine("7. Display Contacts using city or state.");
                Console.WriteLine("8. Count the number of contacts by city or state.");
                Console.WriteLine("9. Sort an address book by its contact's name.");
                Console.WriteLine("10. Sort an address book by its city, state or Zipcode");
                Console.WriteLine("11. Exit.");

                Console.Write("\nChoose:");

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
                        addressBook.AddAAddressBook();
                        break;

                    case 6:
                        addressBook.SearchByCityOrState();
                        break;

                    case 7:
                        Console.Write("Enter whether you want to Display by city or state: ");
                        string inputStr = Console.ReadLine();

                        if(inputStr.Equals("City", StringComparison.OrdinalIgnoreCase))
                        {
                            addressBook.DisplayCityAndName();
                        }
                        else if (inputStr.Equals("State",StringComparison.OrdinalIgnoreCase))
                        {
                            addressBook.DisplayStateAndName();
                        }
                        else
                        {
                            Console.WriteLine("Wrong Choice");
                        }
                        break;

                    case 8:
                        addressBook.CountContactByCityOrState();
                        break;

                    case 9:
                        addressBook.SortAnAddressBook();
                        break;

                    case 10:
                        addressBook.SortAnAddressBookByCityStateOrZip();
                        break;

                    case 11:
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
