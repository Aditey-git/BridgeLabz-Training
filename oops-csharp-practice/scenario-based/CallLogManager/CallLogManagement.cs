using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.Scenario_bases.CallLogManager
{

    internal class CallLogManagement
    {

        public static void Main(string[] args)
        {

            CallLogManager manager = new CallLogManager(20);
            bool exit = false;

            while (!exit)
            {


                Console.WriteLine("===== CUSTOMER SERVICE CALL LOG MANAGER =====");
                Console.WriteLine("1. Add Call Log");
                Console.WriteLine("2. Search Call Logs by Keyword");
                Console.WriteLine("3. Filter Call Logs by Time Range");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {

                    case 1:
                        manager.CallLogAdder();
                        break;

                    case 2:
                        Console.Write("Enter keyword to search: ");
                        string word = Console.ReadLine();
                        manager.Search(word);
                        break;

                    case 3:
                        Console.Write("Enter start date & time (yyyy-MM-dd HH:mm): ");
                        DateTime start;

                        if (!DateTime.TryParse(Console.ReadLine(), out start))
                        {
                            Console.WriteLine("Invalid start date/time.");
                            break;
                        }

                        Console.Write("Enter end date & time (yyyy-MM-dd HH:mm): ");
                        DateTime end;

                        if (!DateTime.TryParse(Console.ReadLine(), out end)){
                            Console.WriteLine("Invalid end date/time.");
                            break;
                        }

                        manager.FilterUsingTime(start, end);
                        break;

                    case 4:
                        exit = true;
                        Console.WriteLine("Exiting application...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

    }
}
