using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.AddressBookSystem
{
    internal class AddressBook
    {
        public Contact[] ContactsArr;
        public int Index;
        public string AddressBookName;

        public AddressBook(string addressBookName)
        {
            ContactsArr = new Contact[20];
            Index = 0;
            this.AddressBookName = addressBookName;
        }
    }
}
