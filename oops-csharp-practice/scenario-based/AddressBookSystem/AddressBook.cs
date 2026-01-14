using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.AddressBookSystem
{

    //This is the encapsulated class which give layout for Address book
    internal class AddressBook
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;   
        private string zipCode;
        private string phoneNumber;
        private string email;

        public AddressBook(string firstName, string lastName, string address, string city, string state, string zipCode,string phoneNumber,string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
        

        //Getters and Setters Method 
        public string FirstName { 
            get { return firstName; }
            set { firstName = value; } 
        }
        
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        
        public string City
        {
            get { return city; }
            set { city = value; }
        }


        public string State
        {
            get{ return state; }
            set { state = value; }
        }

        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }


        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
