using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.AddressBookSystem
{
    internal class AddressBookUtility
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

    }
}
