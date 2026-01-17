using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.AddressBookSystem
{
    internal class AddressBookUtility : IAddressBook
    {

        MultipleAddressBookUtility AddressBookList;

        string[,] cityAndName = new string[20,2];
        int cityInd = 0;

        string[,] stateAndName = new string[20, 2];
        int stateInd = 0;

        public AddressBookUtility(MultipleAddressBookUtility multipleAddressBook)
        {
            this.AddressBookList = multipleAddressBook;
        }

        public void AddAContact()
        {
            Console.WriteLine("Enter the name of address book you want to the contact to be added in: ");
            string addressBookName = Console.ReadLine();

            AddressBook book = AddressBookList.FetchAddressBook(addressBookName);

            if(book == null)
            {
                Console.WriteLine("No such Address Book Exist.");
                return;
            }

            if (book.Index >= book.ContactsArr.Length)
            {
                Console.WriteLine("Address Book is full!");
                return;
            }

            Console.Write("Enter the first name of the contact:");
            string name = Console.ReadLine();

            Console.Write("Enter the last name of the contact:");
            string lastName = Console.ReadLine();


            for (int i = 0; i < book.Index; i++) {
                if (book.ContactsArr[i].FirstName.Equals(name, StringComparison.OrdinalIgnoreCase) && book.ContactsArr[i].LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Duplicate Entry! Contact already exists.");
                    return;
                }
            }


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
            book.ContactsArr[book.Index] = contact;
            book.Index++;


            Console.WriteLine("Contact added successfully");
        }


        public void UpdateContact()
        {
            Console.WriteLine("Enter the name of address book you want to the contact to be updated in: ");
            string addressBookName = Console.ReadLine();

            AddressBook book = AddressBookList.FetchAddressBook(addressBookName);

            if (book == null)
            {
                Console.WriteLine("No such Address Book Exist.");
                return;
            }

            Console.Write("Enter the first name of the contact to be updated: ");
            string inputName = Console.ReadLine();

            int i = 0;

            while (i < book.Index)
            {

                if (book.ContactsArr[i].FirstName.Equals(inputName, StringComparison.OrdinalIgnoreCase))
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

                            book.ContactsArr[i].UpdateName(newName, newLastName);

                            Console.WriteLine("Name of the contact updated");
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

                            book.ContactsArr[i].UpdateAddress(newAddress,
                                newCity, newState,
                                newZipCode);

                            Console.WriteLine("Address of the contact updated.");

                            break;


                        case 3:
                            Console.Write("Enter the new PhoneNumber:");
                            string newPhnNum = Console.ReadLine();

                            book.ContactsArr[i].UpdatePhoneNumber(newPhnNum);

                            Console.WriteLine("Phone number updated.");
                            break;

                        case 4:
                            Console.Write("Enter the new email: ");
                            string newEmail = Console.ReadLine();

                            book.ContactsArr[i].UpdateEmail(newEmail);

                            Console.WriteLine("Email updated.");
                            break;
                        default:
                            Console.WriteLine("Wrong choice!");
                            break;
                    }
                    return;
                }
                i++;
            }
            

            Console.WriteLine("Contact not found.");

        }


        public void DeleteContactUsingName()
        {
            Console.WriteLine("Enter the name of address book you want to the contact to be deleted from: ");
            string addressBookName = Console.ReadLine();

            AddressBook book = AddressBookList.FetchAddressBook(addressBookName);

            if (book == null)
            {
                Console.WriteLine("No such Address Book Exist.");
                return;
            }

            Console.Write("Enter the contact name you want to delete:");
            string inputName = Console.ReadLine();

            int nameIndex = -1;
            for(int i =0; i < book.Index; i++)
            {
                if (book.ContactsArr[i].FirstName.Equals(inputName, StringComparison.OrdinalIgnoreCase))
                {
                    nameIndex = i;
                    break;
                }
            }


            if(nameIndex == -1)
            {
                Console.WriteLine("Contact not found.");
                return;
            }


            for(int i = nameIndex; i < book.Index-1; i++)
            {
                book.ContactsArr[i] = book.ContactsArr[i + 1];
            }

            book.ContactsArr[book.Index - 1] = null;
            book.Index = book.Index - 1;

            Console.WriteLine("Contacts Deleted Successfully");
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

                    for(int i = 0; i < AddressBookList.idx; i++)
                    {
                        for(int j = 0; j < AddressBookList.AddressBooksArr[i].Index; j++)
                        {
                            if (AddressBookList.AddressBooksArr[i].ContactsArr[j].City.Equals(inputCity, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine(AddressBookList.AddressBooksArr[i].ContactsArr[j].ToString());
                                Console.WriteLine("=============================================");
                            }
                        }
                    }

                    break;


                case 2:
                    Console.Write("Enter the state to be searched:");
                    string inputState = Console.ReadLine();


                    for (int i = 0; i < AddressBookList.idx; i++)
                    {
                        for (int j = 0; j < AddressBookList.AddressBooksArr[i].Index; j++)
                        {
                            if (AddressBookList.AddressBooksArr[i].ContactsArr[j].State.Equals(inputState, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine(AddressBookList.AddressBooksArr[i].ContactsArr[j].ToString());
                                Console.WriteLine("=============================================");
                            }
                        }
                    }

                    break;
            }
        }

        public void StoreCityAndName()
        {
            cityInd = 0;
            for(int i = 0; i < AddressBookList.idx; i++)
            {
                for(int j = 0; j < AddressBookList.AddressBooksArr[i].Index; j++)
                {
                    cityAndName[cityInd, 0] = AddressBookList.AddressBooksArr[i].ContactsArr[j].City;
                    cityAndName[cityInd, 1] = AddressBookList.AddressBooksArr[i].ContactsArr[j].FirstName + " " + AddressBookList.AddressBooksArr[i].ContactsArr[j].LastName;
                    cityInd++;
                }
            }
        }


        public void StoreStateAndName()
        {
            stateInd = 0;
            for (int i = 0; i < AddressBookList.idx; i++)
            {
                for (int j = 0; j < AddressBookList.AddressBooksArr[i].Index; j++)
                {
                    stateAndName[stateInd, 0] = AddressBookList.AddressBooksArr[i].ContactsArr[j].State;
                    stateAndName[stateInd, 1] = AddressBookList.AddressBooksArr[i].ContactsArr[j].FirstName + " " + AddressBookList.AddressBooksArr[i].ContactsArr[j].LastName;
                    stateInd++;
                }
            }
        }



        public void DisplayCityAndName()
        {
            StoreCityAndName();
            for(int i = 0; i < cityInd; i++)
            {
                Console.WriteLine($"Name: {cityAndName[i,1]} & City: {cityAndName[i,0]}");
            }
        }


        public void DisplayStateAndName()
        {
            StoreStateAndName();
            for (int i = 0; i < stateInd; i++)
            {
                Console.WriteLine($"Name: {stateAndName[i, 1]} & State: {stateAndName[i, 0]}");
            }
        }
    }
}
