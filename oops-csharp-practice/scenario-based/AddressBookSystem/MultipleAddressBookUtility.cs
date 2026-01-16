using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.AddressBookSystem
{
    internal class MultipleAddressBookUtility : IAddressBookUtility
    {
        public AddressBook[] AddressBooksArr = new AddressBook[20];
        public int idx = 0;

        public void AddAAddressBook()
        {
            Console.Write("Enter the name of the Address Book:");
            string addressBookName = Console.ReadLine();

            AddressBook book = new AddressBook(addressBookName);
            AddressBooksArr[idx] = book;
            idx++;
            Console.WriteLine("Address Book Added succsefully.\n\n\n");
        }

   
        public AddressBook FetchAddressBook(string addressBookName)
        {
            
            for(int i = 0; i < idx;i++)
            {
                if (AddressBooksArr[i].AddressBookName.Equals(addressBookName, StringComparison.OrdinalIgnoreCase))
                {
                    return AddressBooksArr[i];
                }
            }
            return null;
        }
    }
}
