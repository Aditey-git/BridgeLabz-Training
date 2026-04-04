using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.BankingSystem
{
    internal interface Iloanable
    {
        void ApplyLoan(BankAccount acc);
        double LoanEligibility(BankAccount acc);
    }
}
