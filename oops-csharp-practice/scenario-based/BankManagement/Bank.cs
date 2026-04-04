using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

/*
 Summary:-
 This project is a console-based Bank Management System in C# designed using object-oriented principles.
The Bank class acts as the controller and manages user interaction and role selection.
Admin-related operations are handled in a separate BankAccountManager class.
User-related operations such as balance check, deposit, and withdrawal are implemented in the BankUser class.
The application follows a modular structure, making the code easy to maintain and extend.
 */

namespace BridgeLabzTraining.Scenario_Based.BankManagement
{

    // Main Bank class that controls admin and user operations
    internal class Bank
    {

        // Method that handles all banking functionalities
        public void BankFunctions()
        {
            Console.Write("Enter 1 for admin and 2 for user.(1/2)");
            int option = Convert.ToInt32(Console.ReadLine());
            bool isRunning = true;

            BankAccountManager manager = new BankAccountManager();
            BankUser user = new BankUser();

            while (isRunning)
            {
                //Admin menu
                if (option == 1)
                {
                    Console.WriteLine("Here are the features of Admin:");
                    Console.WriteLine("1. Display any particular account details.");
                    Console.WriteLine("2. Delete any particular bank account.");
                    Console.WriteLine("3. Exit the system.");

                    Console.Write("Choose the option you want to go with(1/2/3): ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    

                    switch (choice)
                    {
                        case 1:
                            manager.DisplayAccountDetails();
                            break;
                        case 2:
                            manager.DeleteAccount();
                            break;
                        case 3:
                            isRunning = false;
                            break;
                    }
                }

                // User menu
                else if (option == 2) 
                {
                    Console.WriteLine("Here are the features of user:");
                    Console.WriteLine("1. Display bank balance and details.");
                    Console.WriteLine("2. Add money into your bank account.");
                    Console.WriteLine("3. Withdraw money from your account.");
                    Console.WriteLine("4. Exit the system.");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    

                    switch (choice)
                    {
                        case 1:
                            user.CheckBalance();
                            break;
                        case 2:
                            user.AddMoney();
                            break;
                        case 3:
                            user.WithdrawMoney();
                            break;
                        case 4:
                            isRunning = false;
                            break;
                    }
                }

                // Handles invalid role selection
                else
                {
                    Console.WriteLine("You Entered the wrong choice!");
                    break;
                }
            }

        }


        // Entry point of the application
        public static void Main(string[] args)
        {
            Bank obj = new Bank();
            obj.BankFunctions();
        }
    }
}
