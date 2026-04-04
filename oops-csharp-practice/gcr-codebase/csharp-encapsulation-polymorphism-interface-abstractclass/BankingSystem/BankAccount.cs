using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.BankingSystem
{
    internal abstract class BankAccount
    {
        public string AccountNumber { get; private set; }
        public string NameOfHolder { get; private set; }
        public double AccountBalance { get; protected set; }

        protected BankAccount(string accNumber, string nameOfHolder, double accBalance)
        {
            this.AccountNumber = accNumber;
            this.NameOfHolder = nameOfHolder;
            this.AccountBalance = accBalance;
        }

        public void MoneyDeposit(double amt)
        {
            AccountBalance += amt;
        }

        public void MoneyWithdraw(double amt)
        {
            if (amt <= AccountBalance)
            {
                AccountBalance -= amt;
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }

        public abstract double InterestCalculate();
    }
}
