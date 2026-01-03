using BridgeLabzTraining.Oops.Constructor_Instance.level1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.ThisSealedStatic
{
    internal class Vehicle
    {
        // static variable common for all vehicles
        public static double FeeForRegistration = 2500.0;

        // static method to update registration fee
        public static void RegistrationFeeUpdater(double inputFee)
        {
            FeeForRegistration = inputFee;
        }

        // readonly variable for unique identification
        public readonly string RegistrationNumber;

        // instance variables
        public string NameOfOwner;
        public string TyoeOfVehicle;

        // constructor using 'this' keyword
        public Vehicle(string NameOfOwner, string TypeOfVehicle, string RegistrationNumber)
        {
            this.NameOfOwner = NameOfOwner;
            this.TyoeOfVehicle = TypeOfVehicle;
            this.RegistrationNumber = RegistrationNumber;
        }

        // instance method to display vehicle details using 'is' operator
        public void VehicleDetailsDisplay(object obj)
        {
            if (obj is Vehicle)
            {
                Console.WriteLine("Owner Name: " + NameOfOwner);
                Console.WriteLine("Vehicle Type: " + TyoeOfVehicle);
                Console.WriteLine("Registration Number: " + RegistrationNumber);
                Console.WriteLine("Registration Fee: " + FeeForRegistration);
            }
            else
            {
                Console.WriteLine("Object is not a Vehicle.");
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle("Aditey Rai", "Two-Wheeler", "UP62AB1234");
            Vehicle vehicle2 = new Vehicle("Sambhav Tiwari", "Four-Wheeler", "UP65CD5678");

            vehicle1.VehicleDetailsDisplay(vehicle1);
            Console.WriteLine();

            vehicle2.VehicleDetailsDisplay(vehicle2);
            Console.WriteLine();

            // Update registration fee for all vehicles
            Vehicle.RegistrationFeeUpdater(3000.0);
            Console.WriteLine("Updated Registration Fee: " + Vehicle.FeeForRegistration);
            Console.WriteLine();

            vehicle1.VehicleDetailsDisplay(vehicle1);
        }
    }
}
