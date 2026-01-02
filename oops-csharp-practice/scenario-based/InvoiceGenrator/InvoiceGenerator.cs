using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 Summary =>
 The InvoiceGenerator class serves as the entry point of the Invoice Generator application.
 It displays a menu-driven interface allowing users to generate invoices or exit the program.
User input is collected in a specific format and passed to the Invoice class for processing.
The class uses a continuous loop to allow multiple invoice generations in one session.
Switch-case logic ensures clear and controlled execution flow.
This design keeps the UI logic separate from invoice processing logic.
 */

namespace BridgeLabzTraining.Scenario_Based.InvoiceGenrator
{
    // Main class responsible for running the Invoice Generator application
    internal class InvoiceGenerator
    {
        // Entry point of the application
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n==============================");
                Console.WriteLine(" Freelancer Invoice Generator ");
                Console.WriteLine("==============================");
                Console.WriteLine("1. Generate Invoice");
                Console.WriteLine("2. Exit the program");
                Console.Write("Enter your option: ");

                int option = Convert.ToInt32(Console.ReadLine());


                // Handling menu options using switch case
                switch (option)
                {
                    case 1:
                        Console.Write("\nEnter invoice details: ");
                        Console.WriteLine("(Example: Logo Design - 3000 INR, Web Page - 4500 INR)");
                        string inputString = Console.ReadLine();

                        Invoice.DisplayInvoice(inputString);
                        break;

                    case 2:
                        Console.WriteLine("Exiting application...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

        }
    }
}
