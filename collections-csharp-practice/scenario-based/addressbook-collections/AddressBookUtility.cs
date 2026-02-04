using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBookUtility : IAddressBook
    {
        Dictionary<string, HashSet<Contact>> AddressBooks = new Dictionary<string, HashSet<Contact>>();

        Dictionary<string, string> cityAndName = new Dictionary<string, string>();
        Dictionary<string, string> stateAndName = new Dictionary<string, string>();

        public void AddAAddressBook()
        {
            Console.Write("Enter the name of Address Book:");
            string newAddressBook = Console.ReadLine();

            AddressBooks.Add(newAddressBook, new HashSet<Contact>());

            Console.WriteLine("Address Book Added successfully.");
        }

        public void AddAContact()
        {
            Console.Write("Enter the name of Address Book you want the contact to be addded in: ");
            string inputAddressBook = Console.ReadLine();

            bool bookFound = false;

            foreach(string key in AddressBooks.Keys)
            {
                if(key.Equals(inputAddressBook, StringComparison.OrdinalIgnoreCase))
                {
                    bookFound = true;
                    inputAddressBook = key;
                    break;
                }
            }

            if(bookFound == false)
            {
                Console.WriteLine("Address Book Not found.");
                return;
            }

            
            Console.Write("Enter the first name of the contact:");
            string name = Console.ReadLine();

            Console.Write("Enter the last name of the contact:");
            string lastName = Console.ReadLine();

            Console.Write("Enter the address:");
            string address = Console.ReadLine();

            Console.Write("Enter the city:");
            string city = Console.ReadLine();

            Console.Write("Enter the state:");
            string state = Console.ReadLine();

            Console.WriteLine("Enter the zipcode:");
            string zipcode = Console.ReadLine();

            Console.Write("Enter the phone number:");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter the email:");
            string email = Console.ReadLine(); 

             Contact contact = new Contact(name, lastName, address, city, state, zipcode, phoneNumber, email);

             AddressBooks[inputAddressBook].Add(contact);

             Console.WriteLine("Contact added successfully.");
        }

        public void UpdateContact()
        {
            Console.WriteLine("Enter the name of address book you want to the contact to be updated in: ");
            string inputAddressBook = Console.ReadLine();

            bool bookFound = false;

            foreach(string key in AddressBooks.Keys)
            {
                if(key.Equals(inputAddressBook, StringComparison.OrdinalIgnoreCase))
                {
                    bookFound = true;
                    inputAddressBook = key;
                    break;
                }
            }

            if(bookFound == false)
            {
                Console.WriteLine("Address Book Not found.");
                return;
            }

            Console.Write("Enter the first name of the contact to be updated: ");
            string inputName = Console.ReadLine();

            foreach(Contact contact in AddressBooks[inputAddressBook])
            {
                if(contact.FirstName.Equals(inputName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Choose What you want to update =>");
                    Console.WriteLine("1. Update Name");
                    Console.WriteLine("2. Update Address");
                    Console.WriteLine("3. Update phone number");
                    Console.WriteLine("4. Update email");
                    Console.Write("Enter: ");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                        Console.Write("Enter new first name: ");
                        string newName = Console.ReadLine();

                        Console.Write("Enter new last name: ");
                        string newLastName = Console.ReadLine();

                        contact.UpdateName(newName, newLastName);
                        break;

                        case 2:
                        Console.Write("Enter the address: ");
                        string newAddress = Console.ReadLine();

                        Console.Write("Enter the city: ");
                        string newCity = Console.ReadLine();

                        Console.Write("Enter the state: ");
                        string newState = Console.ReadLine();

                        Console.Write("Enter the new Zip Code: ");
                        string newZipCode = Console.ReadLine();

                        contact.UpdateAddress(newAddress, newCity, newState, newZipCode);

                        Console.WriteLine("Address of the contact updated.");

                        break;


                        case 3:
                        Console.Write("Enter the new PhoneNumber:");
                        string newPhnNum = Console.ReadLine();

                        contact.UpdatePhoneNumber(newPhnNum);

                        Console.WriteLine("Phone number updated.");
                        break;

                    case 4:
                        Console.Write("Enter the new email: ");
                        string newEmail = Console.ReadLine();

                        contact.UpdateEmail(newEmail);

                        Console.WriteLine("Email updated.");
                        break;
                    default:
                        Console.WriteLine("Wrong choice!");
                        break;
                    }
                    Console.WriteLine("Contact updated successfully.");
                    return;
                }
            }

            Console.WriteLine("Contact not found.");
        }


        public void DeleteContactUsingName()
        {
            Console.WriteLine("Enter the name of address book you want to the contact to be deleted from: ");
            string inputAddressBook = Console.ReadLine();

            bool bookFound = false;

            foreach(string key in AddressBooks.Keys)
            {
                if(key.Equals(inputAddressBook, StringComparison.OrdinalIgnoreCase))
                {
                    bookFound = true;
                    inputAddressBook = key;
                    break;
                }
            }

            if(bookFound == false)
            {
                Console.WriteLine("Address Book Not found.");
                return;
            }

            

            Console.Write("Enter the contact name you want to delete:");
            string inputName = Console.ReadLine();

            foreach(Contact contact in AddressBooks[inputAddressBook])
            {
                if(contact.FirstName.Equals(inputName, StringComparison.OrdinalIgnoreCase))
                {
                    AddressBooks[inputAddressBook].Remove(contact);
                    Console.WriteLine("Contact deleted successfully.");
                    return;
                }
            }
            Console.WriteLine("Contact not found.");
        }


        public void AddMultipleContacts()
        {
            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("Do you want to add a contact in the address book?(Yes/No)");
                string inputAnswer = Console.ReadLine();

                if (inputAnswer.Equals("Yes"))
                {
                    AddAContact();
                }
                else if (inputAnswer.Equals("No"))
                {
                    isTrue = false;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }


        public void SearchByCityOrState()
        {

            Console.WriteLine("Press preffred button:");
            Console.WriteLine("1. City");
            Console.WriteLine("2. State");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Enter the city to be searched:");
                    string inputCity = Console.ReadLine();

                    foreach(KeyValuePair<string, HashSet<Contact>> item in AddressBooks)
                    {
                        foreach(Contact contact in item.Value)
                        {
                            if(contact.City.Equals(inputCity, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine(contact.ToString());
                                Console.WriteLine("============================================");
                            }
                        }
                    }
                    break;



                case 2:
                    Console.Write("Enter the state to be searched:");
                    string inputState = Console.ReadLine();


                    
                    foreach(KeyValuePair<string, HashSet<Contact>> item in AddressBooks)
                    {
                        foreach(Contact contact in item.Value)
                        {
                            if(contact.State.Equals(inputState, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine(contact.ToString());
                                Console.WriteLine("=============================================");
                            }
                        }
                    } 
                    

                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        public void StoreCityAndName()
        {
            cityAndName.Clear();
            foreach(KeyValuePair<string, HashSet<Contact>> item in AddressBooks)
            {
                foreach(Contact contact in item.Value)
                {
                    cityAndName.Add(contact.FirstName + " " + contact.LastName, contact.City);
                }
            }
        }


        public void StoreStateAndName()
        {
            stateAndName.Clear();
            foreach(KeyValuePair<string, HashSet<Contact>> item in AddressBooks)
            {
                foreach(Contact contact in item.Value)
                {
                    stateAndName.Add(contact.FirstName + " " + contact.LastName, contact.State);
                }
            }
        }


        public void DisplayCityAndName()
        {
            StoreCityAndName();

            foreach(KeyValuePair<string, string> item in cityAndName)
            {
                Console.WriteLine("Name => " + item.Key + " City => " + item.Value);
            }
        }


        public void DisplayStateAndName()
        {
            StoreStateAndName();

            foreach(KeyValuePair<string, string> item in stateAndName)
            {
                Console.WriteLine("Name => " + item.Key + " State => " + item.Value);
            }
        }


        public void CountContactByCityOrState()
        {
            int count = 0;
            
            Console.Write("Count by city or state(1/2)");
            int input = int.Parse(Console.ReadLine());


            switch (input) {
                case 1:
                    Console.Write("Enter the name of the city:");
                    string inputCity = Console.ReadLine();
                    foreach(KeyValuePair<string, HashSet<Contact>> item in AddressBooks)
                    {
                       foreach (Contact contact in item.Value)
                        {
                            if(contact.City.Equals(inputCity, StringComparison.OrdinalIgnoreCase))
                            {
                                count++;
                            }
                        } 
                    }

                    break;


                case 2:
                    Console.Write("Enter the name of the state: ");
                    string inputState = Console.ReadLine();

                    foreach(KeyValuePair<string, HashSet<Contact>> item in AddressBooks)
                    {
                       foreach (Contact contact in item.Value)
                        {
                            if(contact.State.Equals(inputState, StringComparison.OrdinalIgnoreCase))
                            {
                                count++;
                            }
                        } 
                    }

                    break;
            }

            Console.WriteLine($"Number of Contacts: {count}");

        }

        public void SortAnAddressBook()
        {
            Console.Write("Enter the Address Book You want to sort:");

            string inputAddressBook = Console.ReadLine();

            bool bookFound = false;

            foreach(string key in AddressBooks.Keys)
            {
                if(key.Equals(inputAddressBook, StringComparison.OrdinalIgnoreCase))
                {
                    bookFound = true;
                    inputAddressBook = key;
                    break;
                }
            }

            if(bookFound == false)
            {
                Console.WriteLine("Address Book Not found.");
                return;
            }

            List<Contact> sortedContacts = AddressBooks[inputAddressBook].ToList();

            sortedContacts = sortedContacts.OrderBy(contact => contact.FirstName)
                            .ThenBy(contact => contact.LastName).ToList();

            Console.WriteLine("The sorted contacts are: ");
            foreach (Contact contact in sortedContacts)
            {
                Console.WriteLine(contact.ToString());
                Console.WriteLine();
            }

        }

        public void SortAnAddressBookByCityStateOrZip()
        {
            Console.Write("Enter the Address Book You want to sort:");

            string inputAddressBook = Console.ReadLine();

            bool bookFound = false;

            foreach(string key in AddressBooks.Keys)
            {
                if(key.Equals(inputAddressBook, StringComparison.OrdinalIgnoreCase))
                {
                    bookFound = true;
                    inputAddressBook = key;
                    break;
                }
            }

            if(bookFound == false)
            {
                Console.WriteLine("Address Book Not found.");
                return;
            }


            Console.WriteLine("Enter the means by which you want to sort the Address Book:");
            Console.WriteLine("1. City");
            Console.WriteLine("2. State");
            Console.WriteLine("3. Zip");
            Console.Write("Choose(1/2/3): ");

            int choice = int.Parse(Console.ReadLine());

            List<Contact> sortedContacts = AddressBooks[inputAddressBook].ToList();



            switch (choice)
            {
                case 1:
                    sortedContacts = sortedContacts.OrderBy(contact => contact.City).ToList();
                    break;
                case 2:
                    sortedContacts = sortedContacts.OrderBy(contact => contact.State).ToList();
                    break;
                case 3:
                    sortedContacts = sortedContacts.OrderBy(contact => contact.ZipCode).ToList();
                    break;
                default:
                    Console.WriteLine("Wrong Choice! Choose 1,2 or 3.");
                    break;
            }

            Console.WriteLine("The sorted contacts are: \n");

            foreach (Contact contact in sortedContacts)
            {
                Console.WriteLine(contact.ToString());
            }
        }


    }
}