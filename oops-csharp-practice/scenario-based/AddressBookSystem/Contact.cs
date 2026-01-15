using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.AddressBookSystem
{

    //This is the encapsulated class which give layout for Address book
    internal class Contact
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Address{ get; private set; }
        public string City{ get; private set; }
        public string State   { get; private set; }
        public string ZipCode { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }

        public Contact(string firstName, string lastName, string address, string city, string state, string zipCode, string phoneNumber, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }
        
        public void UpdateName(string name, string lastName)
        {
            FirstName = name;
            LastName = lastName;
        }

        public void UpdateAddress(string address,string city,string state,string zipcode)
        {
            Address = address;
            City = city;
            State = state;
            ZipCode = zipcode;
        }

        public void UpdatePhoneNumber(string phoneNumber)
        {
            PhoneNumber = phoneNumber; 
        }

        public void UpdateEmail(string email) 
        { 
            Email = email;
        }
        
    }
}
