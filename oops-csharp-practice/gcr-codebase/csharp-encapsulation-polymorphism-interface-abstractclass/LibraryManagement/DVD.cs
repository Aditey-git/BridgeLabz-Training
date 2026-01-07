using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.LibraryManagement
{
    internal class DVD : LibraryItem
    {
        public DVD(string dvdId, string dvdTitle, string dvdAuthor)
            : base(dvdId, dvdTitle, dvdAuthor)
        {
        }

        public override int LoanDurationGetter()
        {
            return 3;
        }
    }
}
