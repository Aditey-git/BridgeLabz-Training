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
        private Contact[] contactsArr;
        private int index = 0;

        public AddressBookUtility()
        {
            contactsArr = new Contact[20];
        }

        public void AddAContact()
        {

            if (index >= contactsArr.Length)
            {
                Console.WriteLine("Address Book is full!");
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
            contactsArr[index] = contact;
            index++;


            Console.WriteLine("Contact added successfully");
        }


        public void UpdateContact()
        {
            Console.Write("Enter the first name of the contact to be updated: ");
            string inputName = Console.ReadLine();

            int i = 0;

            while (i < index)
            {

                if (contactsArr[i].FirstName.Equals(inputName, StringComparison.OrdinalIgnoreCase))
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

                            contactsArr[i].UpdateName(newName, newLastName);

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

                            contactsArr[i].UpdateAddress(newAddress,
                                newCity, newState,
                                newZipCode);

                            Console.WriteLine("Address of the contact updated.");

                            break;


                        case 3:
                            Console.Write("Enter the new PhoneNumber:");
                            string newPhnNum = Console.ReadLine();

                            contactsArr[i].UpdatePhoneNumber(newPhnNum);

                            Console.WriteLine("Phone number updated.");
                            break;

                        case 4:
                            Console.Write("Enter the new email: ");
                            string newEmail = Console.ReadLine();

                            contactsArr[i].UpdateEmail(newEmail);

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
            Console.Write("Enter the contact name you want to delete:");
            string inputName = Console.ReadLine();

            int nameIndex = -1;
            for(int i =0; i < index; i++)
            {
                if (contactsArr[i].FirstName.Equals(inputName, StringComparison.OrdinalIgnoreCase))
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


            for(int i = nameIndex; i < index-1; i++)
            {
                contactsArr[i] = contactsArr[i + 1];
            }

            contactsArr[index - 1] = null;
            index = index - 1;

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
    }
}
