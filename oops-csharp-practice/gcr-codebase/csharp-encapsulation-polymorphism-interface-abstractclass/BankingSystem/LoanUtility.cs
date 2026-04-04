using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.BankingSystem
{
    internal class LoanUtility : Iloanable
    {
        private string LoanId = "LN-9001";

        public void ApplyLoan(BankAccount account)
        {
            Console.WriteLine($"Loan applied for {account.AccountNumber}");
        }

        public double LoanEligibility(BankAccount account)
        {
            return account.AccountBalance * 5;
        }
    }
}
