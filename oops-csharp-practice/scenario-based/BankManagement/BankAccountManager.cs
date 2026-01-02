using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 Summary =>
 The BankAccountManager class handles all admin-level banking operations in the system.
It stores account information using a static 2D array shared across the application.
The class allows the admin to view account details and delete bank accounts securely.
All admin actions require passkey authentication for safety.
The class ensures controlled access and maintains data integrity.
This separation keeps admin logic independent from user operations.
 */

namespace BridgeLabzTraining.Scenario_Based.BankManagement
{
    // Class that handles all admin-level banking operations
    internal class BankAccountManager
    {
        // Private passkey required to perform admin operations
        private int managerPasskey = 1919;

        // Static 2D array storing account details
        // Columns: Account Number, Account Holder Name, Password, Balance
        internal static string[,] accountDetails = {
             { "ABCDE", "Rahul Sharma",   "1234", "50000" },
             { "FGHIJ", "Amit Verma",     "2345", "75000" },
             { "KLMNO", "Priya Singh",    "3456", "62000" },
             { "PQRST", "Neha Gupta",     "4567", "88000" },
             { "UVWXY", "Rohit Kumar",    "5678", "43000" },
             { "ZABCD", "Anjali Mehta",   "6789", "91000" },
             { "EFGHI", "Vikas Patel",    "7890", "56000" },
             { "JKLMN", "Sneha Iyer",     "8901", "77000" },
             { "OPQRS", "Arjun Malhotra", "9012", "66000" },
             { "TUVWX", "Pooja Nair",     "1122", "82000" }
            };

        //Manager methods

        //Method to display a particular account details
        public void DisplayAccountDetails()
        {
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();

            Console.Write("Enter the passkey to proceed:");
            int inputKey = Convert.ToInt32(Console.ReadLine());

            if (inputKey == managerPasskey)
            {
                for (int i = 0; i < accountDetails.GetLength(0); i++)
                {
                    if (string.Equals(accountNumber, accountDetails[i, 0], StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Account Number: " + accountDetails[i, 0]);
                        Console.WriteLine("Account Holder Name: " + accountDetails[i, 1]);
                        Console.WriteLine("Balance: " + accountDetails[i, 3]);
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine("Passkey INVALID!");
                return;
            }

            Console.WriteLine("Account Not Found!");
        }


        // Method to delete a specific bank account
        public void DeleteAccount()
        {
            Console.Write("Enter the account number to be deleted: ");
            string accountNumber = Console.ReadLine();

            bool accountFound = false;
            for (int i = 0; i < accountDetails.GetLength(0); i++)
            {
                
                if (string.Equals(accountNumber, accountDetails[i, 0], StringComparison.OrdinalIgnoreCase))
                {
                    accountFound = true;
                }
            }

            if (!accountFound)
            {
                Console.WriteLine("Account not found");
                return;
            }

            Console.Write("Enter the passkey to proceed: ");
            int passKeyUser = Convert.ToInt32(Console.ReadLine());


            string[,] newAccountDetails = new string[accountDetails.GetLength(0) - 1, 4];


            int row = 0;

            if (passKeyUser == managerPasskey)
            {
                for (int i = 0; i < accountDetails.GetLength(0); i++)
                {
                    if (!string.Equals(accountDetails[i, 0], accountNumber))
                    {
                        for (int j = 0; j < accountDetails.GetLength(1); j++)
                        {



                            newAccountDetails[row, j] = accountDetails[i, j];


                        }
                        row++;
                    }
                }


                Console.WriteLine("The account is deleted");
            }
            else
            {
                Console.WriteLine("Passkey Incorrect! Cannot proceed!");
            }


            accountDetails = newAccountDetails;
        }

    }
}
