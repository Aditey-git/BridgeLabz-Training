using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


/*
 Summary => 
This class provides a menu-driven interface for a Vehicle Rental System.
It allows users to rent different types of vehicles such as bikes, cars, and trucks.
Based on the user’s choice, an appropriate vehicle object is created from subclasses that inherit from a common Vehicle base class.
Customer details and rental duration are collected and handled through the CustomerClass.
Polymorphism is demonstrated by treating all vehicle types using the Vehicle reference.
The program continues to run until the user chooses to exit the system.
 */

namespace BridgeLabzTraining2.Oops.Scenario_bases.VehicleRentalSystem
{

    //Main class for the entry of Vehicle rental system
    internal class VehicleDisplay
    {
        public void DisplayInfo()
        {
            int option;


            //Loop until the user exits
            do
            {
                Console.WriteLine("\n--- Vehicle Rental Menu ---");
                Console.WriteLine("1. Rent Bike");
                Console.WriteLine("2. Rent Car");
                Console.WriteLine("3. Rent Truck");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                option = Convert.ToInt32(Console.ReadLine());

                if (option == 4)
                {
                    Console.WriteLine("Thank you for using Vehicle Rental System!");
                    break;
                }

                Console.Write("Enter Customer Name: ");
                string nameOfCustomer = Console.ReadLine();
                CustomerClass customer = new CustomerClass(1, nameOfCustomer);

                Console.Write("Enter Number of Days: ");
                int numOfDays = Convert.ToInt32(Console.ReadLine());

                Vehicle vehicle = null;

                switch (option)
                {
                    case 1:
                        vehicle = new BikeClass(101, "Royal Enfield", "GT 650", 300);
                        break;

                    case 2:
                        vehicle = new CarClass(102, "Maruti Suzuki", "Alto", 1500);
                        break;

                    case 3:
                        vehicle = new TruckVehicle(103, "Ashok Leyland", "1616", 4000);
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        continue;
                }

                customer.RentVehicle(vehicle, numOfDays);

            } while (option != 4);
        }

    }
}
