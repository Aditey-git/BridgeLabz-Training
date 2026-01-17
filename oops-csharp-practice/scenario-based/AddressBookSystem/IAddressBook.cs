using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.AddressBookSystem
{
    internal interface IAddressBook
    {
        void AddAContact();

        void UpdateContact();

        void DeleteContactUsingName();

        void AddMultipleContacts();

        void SearchByCityOrState();

        void DisplayCityAndName();

        void DisplayStateAndName();
    }
}
