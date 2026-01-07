using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.LibraryManagement
{
    internal class Magazine : LibraryItem
    {
        public Magazine(string id, string title, string author)
            : base(id, title, author)
        {
        }

        public override int LoanDurationGetter()
        {
            return 7;
        }
    }
}
