using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

     /*
     Summary:-
     The BankUser class handles all user-side banking operations in the system.
    It allows users to check balance, deposit money, and withdraw money securely.
    Account verification is done using account number and password validation.
    All operations directly update the shared account data stored in BankAccountManager.
    The class enforces basic rules such as overdraft limits and input validation.
    This separation ensures clean structure and better maintainability of the application.
     */

namespace BridgeLabzTraining.Scenario_Based.BankManagement
{

    // Class that handles all user-related banking operations
    internal class BankUser
    {

        // Method to check bank balance and account details
        public void CheckBalance()
        {

            BankAccountManager obj = new BankAccountManager();

            Console.WriteLine("Give Account Number: ");
            string accountNumber = Console.ReadLine();

      
                for (int i = 0; i < BankAccountManager.accountDetails.GetLength(0); i++)
                {
                    if (string.Equals(accountNumber, BankAccountManager.accountDetails[i, 0], StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Enter the password:");
                        string password = Console.ReadLine();
                        if (password == BankAccountManager.accountDetails[i, 2]) 
                        {
                            Console.WriteLine("Account Number: " + BankAccountManager.accountDetails[i, 0]);
                            Console.WriteLine("Account Holder Name: " + BankAccountManager.accountDetails[i, 1]);
                            Console.WriteLine("Balance: " + BankAccountManager.accountDetails[i, 3]);
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Password entered is Wrong!");
                            return;
                        }
                    }
                }

            Console.WriteLine("Account Not Found!");
        }


        // Method to add money to the user's account
        public void AddMoney()
        {
            BankAccountManager obj = new BankAccountManager();
            Console.Write("Enter Account Number: ");
            string accountNumber = Console.ReadLine();

            for (int i = 0; i < BankAccountManager.accountDetails.GetLength(0); i++)
            {
                if (string.Equals(accountNumber, BankAccountManager.accountDetails[i, 0], StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Enter the password:"); 
                    string password = Console.ReadLine();
                    if (password == BankAccountManager.accountDetails[i, 2])
                    {
                        Console.Write("Enter Amount to be added: ");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        int oldAmount = Convert.ToInt32(BankAccountManager.accountDetails[i, 3]);
                        int newAmount = amount + oldAmount;
                        string finalAmount = Convert.ToString(newAmount);
                        BankAccountManager.accountDetails[i, 3] = finalAmount;
                        Console.WriteLine("Account details after updation: ");
                        Console.WriteLine("Account Number: " + BankAccountManager.accountDetails[i, 0]);
                        Console.WriteLine("Account Holder Name: " + BankAccountManager.accountDetails[i, 1]);
                        Console.WriteLine("Balance: " + BankAccountManager.accountDetails[i, 3]);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("You Entered the wrong password");
                        return;
                    }
                }
            }

            Console.WriteLine("Account Not Found!");

        }


        // Method to withdraw money from the user's account
        public void WithdrawMoney()
        {
            // Overdraft limit for withdrawal
            int overdraft = 5000;

            BankAccountManager obj = new BankAccountManager();
            Console.Write("Enter Account Number: ");

            string accountNumber = Console.ReadLine();

            for (int i = 0; i < BankAccountManager.accountDetails.GetLength(0); i++)
            {
                if (string.Equals(accountNumber, BankAccountManager.accountDetails[i, 0], StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Enter the password:");
                    string password = Console.ReadLine();
                    if (password == BankAccountManager.accountDetails[i, 2])
                    {
                        Console.Write("Enter amount to be debited: ");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        int oldAmount = Convert.ToInt32(BankAccountManager.accountDetails[i, 3]);
                        if(amount < overdraft)
                        {
                            string newAmount = Convert.ToString(oldAmount - amount);
                            BankAccountManager.accountDetails[i, 3] = newAmount;
                            Console.WriteLine("Account details after updation: ");
                            Console.WriteLine("Account Number: " + BankAccountManager.accountDetails[i, 0]);
                            Console.WriteLine("Account Holder Name: " + BankAccountManager.accountDetails[i, 1]);
                            Console.WriteLine("Balance: " + BankAccountManager.accountDetails[i, 3]);
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Your overdraft limit is 5000. Please visit the bank in order to increase this!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong password Entered!");
                    }
                }
            }
            Console.WriteLine("Account Not found");
        }
    }
}
