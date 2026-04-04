using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Summary => 
This program acts as the main entry point for a Hospital Patient Management System.
It uses a menu-driven loop to let the user manage hospital operations such as adding doctors and patients.
The Hospital class delegates all core functionalities to a UtilityClass, keeping the main method clean.
Separate classes like Patient, Doctor, and Bill are assumed to handle data storage and billing logic.
Users can view all registered patients and generate bills through dedicated options.
The system runs continuously until the user chooses to exit.
 */

namespace BridgeLabzTraining2.Oops.Scenario_bases
{


    //Main class for entry 
    internal class Hospital
    {
        static void Main(string[] args)
        {
            UtilityClass utility = new UtilityClass();
            bool exit = false;


            //Loop until the user exits
            while (!exit)
            {
                Console.WriteLine("\n===== Hospital Patient Management System =====");
                Console.WriteLine("1. Add Doctor");
                Console.WriteLine("2. Add Patient");
                Console.WriteLine("3. Display All Patients");
                Console.WriteLine("4. Generate Bill");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.AddADoctor();
                        break;

                    case 2:
                        utility.AddAPatient();
                        break;

                    case 3:
                                utility.DisplayPatients();
                                break;

                            case 4:
                                utility.GenerateBill();
                                break;

                            case 5:
                                exit = true;
                                Console.WriteLine("Exiting system. Thank you!");
                                break;

                            default:
                                Console.WriteLine("Invalid choice. Try again.");
                                break;
                        }
}
                }

    }
}
