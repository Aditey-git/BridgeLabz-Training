using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.ThisSealedStatic
{
    internal class BankAccount
    {
        // static variable shared by all accounts
        public static string bankName = "State Bank of India";
        private static int totalNumberOfAccounts = 0;

        //readonly variable
        public readonly string AccountNumber;

        //instance variable
        public string AccountHolderName;


        public BankAccount(string AccountHolderName, string AccountNumber)
        {
            this.AccountHolderName = AccountHolderName;
            this.AccountNumber = AccountNumber;
            totalNumberOfAccounts++;
        }

        // static method
        public static void GetTotalAccounts(){
            Console.WriteLine("Total Accounts Created: " + totalNumberOfAccounts);
        }

        // instance method
        public void AccountDetailsDisplay(object obj)
        {
            if (obj is BankAccount){
                Console.WriteLine("Bank Name: " + bankName);
                Console.WriteLine("Account Holder: " + AccountHolderName);
                Console.WriteLine("Account Number: " + AccountNumber);
            }
            else{
                Console.WriteLine("Object is not a BankAccount instance");
            }
        }
    }


    internal class BankAccountManagement
    {
        static void BankManage()
        {

            BankAccount account1 = new BankAccount("Aditey Rai", "ABCDE");
            BankAccount account2 = new BankAccount("Sambhav Tiwari", "FGHIJ");

            account1.AccountDetailsDisplay(account1);
            Console.WriteLine();
            account2.AccountDetailsDisplay(account2);

            Console.WriteLine();
            BankAccount.GetTotalAccounts();

        }
    }

}
