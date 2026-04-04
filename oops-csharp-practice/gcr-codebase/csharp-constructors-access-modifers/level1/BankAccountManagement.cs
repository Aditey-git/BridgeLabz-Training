using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.Constructor_Instance.level1
{
    internal class BankAccountManagement
    {
        public string accountNumber;

        protected string accountHolder;

        private double balance;

        // Constructor
        public BankAccountManagement(string accountNumber, string accountHolder, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
        }

        // Public method to access balance
        public double BalanceGetter()
        {
            return balance;
        }

        // Public method to modify balance (deposit/withdraw)
        public void Deposit(double amountToCredit){
            if (amountToCredit > 0){
                balance += amountToCredit;
            }
            else{
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(double amountToDebit)
        {
            if (amountToDebit > 0 && amountToDebit <= balance){
                balance -= amountToDebit;
            }
            else{
                Console.WriteLine("Invalid or insufficient balance.");
            }
        }
    }

    // Subclass to demonstrate access modifiers
    internal class SavingsAccountManagement : BankAccountManagement
    {
        public double rateOfInterest;

        public SavingsAccountManagement(string accNumber, string holderName, double balance, double interestRate)
            : base(accNumber, holderName, balance)
        {
            this.rateOfInterest = interestRate;
        }

        public void DisplaySavingsAccountDetails(){
            Console.WriteLine($"Account Number: {accountNumber}"); 
            Console.WriteLine($"Account Holder: {accountHolder}"); 
            Console.WriteLine($"Balance: ₹{BalanceGetter()}"); 
            Console.WriteLine($"Interest Rate: {rateOfInterest}%");
        }
    }


    internal class ProgramClassBank
    {
        static void BankManage(){
            SavingsAccountManagement savingsA =
               new SavingsAccountManagement("SB12345", "Aditey Rai", 50000, 4.5);

            savingsA.DisplaySavingsAccountDetails();

            savingsA.Deposit(10000);
            savingsA.Withdraw(5000);

            Console.WriteLine("Updated Balance: ₹" + savingsA.BalanceGetter());
        }
    }
}
