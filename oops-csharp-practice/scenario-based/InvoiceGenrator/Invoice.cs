using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 Summary => 
 This Invoice class is used to generate and display invoice details from a single input string.
It parses the input into individual tasks using string splitting techniques.
Each task’s amount is extracted, cleaned, and converted into an integer for calculation.
The class calculates the total invoice amount by summing all task values.
Finally, it displays the invoice items along with the total amount in INR.
 */

namespace BridgeLabzTraining.Scenario_Based.InvoiceGenrator
{
    internal class Invoice
    {
        // Method to parse the input and return an array of tasks
        public static string[] InvoiceParse(string inputString){
            return inputString.Split(',');
        }

        // Method to calculate total amount from tasks
        public static int TotalAmountGet(string[] tasksArray){

            int totalAmount = 0;

            foreach (string t in tasksArray){
                string[] partsArray = t.Split('-');

                if (partsArray.Length == 2)
                {
                    string partAmount = partsArray[1].ToLower();
                    partAmount = partAmount.Replace("inr", "");
                    partAmount = partAmount.Trim();
                    int amt = int.Parse(partAmount);
                    totalAmount = totalAmount + amt;
                }
            }

            return totalAmount;

        }


        // Method to displays invoice details
        public static void DisplayInvoice(string inputString)
        {
            string[] tasksArray = InvoiceParse(inputString);
            int amountTotal = TotalAmountGet(tasksArray);

            Console.WriteLine("\nInvoice Details:");
            foreach (string task in tasksArray){
                Console.WriteLine(task.Trim());
            }

            Console.WriteLine($"\nTotal Invoice Amount: {amountTotal} INR");

        }

    }
}
