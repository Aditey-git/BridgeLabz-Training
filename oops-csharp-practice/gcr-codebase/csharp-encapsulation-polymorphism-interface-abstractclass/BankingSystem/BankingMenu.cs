using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.BankingSystem
{
    internal class BankingMenu 
    {
        private Iloanable loanUtilityVar;

        public void BankMenu()
        {
            loanUtilityVar = new LoanUtility();

            BankAccount acc =
                new SavingsAccount("SB101", "Aditey", 60000);

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Press 1 : Deposit");
                Console.WriteLine("Press 2 : Withdraw");
                Console.WriteLine("Press 3 : Check balance");
                Console.WriteLine("Press 4 : Calculate interest");
                Console.WriteLine("Press 5 : Loan eligibility");
                Console.WriteLine("Press 6 : Exit");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        acc.MoneyDeposit(5000);
                        Console.WriteLine("Amount deposited");
                        break;

                    case 2:
                        acc.MoneyWithdraw(3000);
                        Console.WriteLine("Amount withdrawn");
                        break;

                    case 3:
                        Console.WriteLine(acc.AccountBalance);
                        break;

                    case 4:
                        Console.WriteLine(acc.InterestCalculate());
                        break;

                    case 5:
                        loanUtilityVar.ApplyLoan(acc);
                        Console.WriteLine(loanUtilityVar.LoanEligibility(acc));
                        break;

                    case 6:
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}
