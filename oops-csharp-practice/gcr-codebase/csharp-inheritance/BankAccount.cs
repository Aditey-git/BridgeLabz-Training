using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.Inheritance
{
    internal class BankAccount
    {
        public string AccountNo;
        public double AccountBalance;

        public BankAccount(string AccountNumber, double Accountbalance)
        {
            AccountNo = AccountNumber;
            AccountBalance = Accountbalance;
        }

        public virtual void AccountTypeDisplay()
        {
            Console.WriteLine("Generic Bank Account");
        }
    }

    // Subclass: SavingsAccount
    class SavingsAccountSubclass : BankAccount
    {
        public double RateOfInterest;

        public SavingsAccountSubclass(string accNumber, double bal, double roi)
            : base(accNumber, bal)
        {
            RateOfInterest = roi;
        }

        public override void AccountTypeDisplay()
        {
            Console.WriteLine("Account Type: Savings Account");
            Console.WriteLine($"Interest Rate: {RateOfInterest}%");
        }
    }

    // Subclass: CheckingAccount
    class CheckingAccountSubclass : BankAccount
    {
        public double LimitForWithdrawl;

        public CheckingAccountSubclass(string accNumber, double bal, double LimitForWithdrawl)
            : base(accNumber, bal)
        {
            this.LimitForWithdrawl = LimitForWithdrawl;
        }

        public override void AccountTypeDisplay()
        {
            Console.WriteLine("Account Type: Checking Account");
            Console.WriteLine($"Withdrawal Limit: {LimitForWithdrawl}");
        }
    }

    // Subclass: FixedDepositAccount
    class FixedDepositAccountSubclass : BankAccount
    {
        public int LockinPeriod; // in months

        public FixedDepositAccountSubclass(string accNumber, double bal, int lockinPeriod)
            : base(accNumber, bal)
        {
            LockinPeriod = lockinPeriod;
        }

        public override void AccountTypeDisplay()
        {
            Console.WriteLine("Account Type: Fixed Deposit Account");
            Console.WriteLine($"Lock-in Period: {LockinPeriod} months");
        }
    }


    class BankAccountManagement
    {
        static void BankManage()
        {
            BankAccount[] accountsArr =
            {
                new SavingsAccountSubclass("SAV123", 50000, 4.5),
                new CheckingAccountSubclass("CHK456", 30000, 20000),
                new FixedDepositAccountSubclass("FD789", 100000, 24)
            };

            foreach (BankAccount acc in accountsArr)
            {
                Console.WriteLine($"Account Number: {acc.AccountNo}");
                Console.WriteLine($"Balance: {acc.AccountBalance}");
                acc.AccountTypeDisplay();
                Console.WriteLine();
            }
        }
    }
}
