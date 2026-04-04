using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.Constructor_Instance.level1
{
    internal class Vehicle
    {
        //Attributes
        public string ownerName;
        public string vehicleType;

        //Class variable (shared by all vehicles)
        public static double registrationFee = 5000;

        // Constructor
        public Vehicle(string ownerName, string vehicleType){
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }

      
        public void DisplayVehicle(){
            Console.WriteLine($"Owner Name: {ownerName}");
            Console.WriteLine($"Vehicle Type: {vehicleType}");
            Console.WriteLine($"Registration Fee: ₹{registrationFee}");
        }

        // Class (static) method
        public static void UpdateRegistrationFee(double feeNew)
        {
            registrationFee = feeNew;
        }

        public static void VehicalRegistration()
        {
            Vehicle vehicle1 = new Vehicle("Aditey Rai", "Two Wheeler");
            Vehicle vehicle2 = new Vehicle("Sambhav Tiwari", "Four Wheeler");

            // Update registration fee for all vehicles
            Vehicle.UpdateRegistrationFee(6500);

            vehicle1.DisplayVehicle();
            vehicle2.DisplayVehicle();
        }
    }
}
