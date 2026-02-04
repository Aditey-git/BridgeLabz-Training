using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AddressBook
{
    interface IAddressBook
    {
        void AddAAddressBook();
        void AddAContact();
        void UpdateContact();
        void DeleteContactUsingName();
        void AddMultipleContacts();
        void SearchByCityOrState();
        void DisplayCityAndName();
        void DisplayStateAndName();
        void CountContactByCityOrState();
        void SortAnAddressBook();
        void SortAnAddressBookByCityStateOrZip();
    }
}