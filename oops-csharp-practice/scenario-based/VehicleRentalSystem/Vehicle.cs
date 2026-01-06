using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.Scenario_bases.VehicleRentalSystem
{
    abstract class Vehicle
    {
        // Protected fields
        protected int idOfVehicle;
        protected string brandOfVehicle;
        protected string modelOfVehicle;
        protected double perDayRent;
        protected bool isAvailableOrNot;

        // Constructor
        public Vehicle(int vehicleId, string brand, string model, double rentPerDay)
        {
            this.idOfVehicle = vehicleId;
            this.brandOfVehicle = brand;
            this.modelOfVehicle = model;
            this.perDayRent = rentPerDay;
            this.isAvailableOrNot = true;
        }

        // Abstract method
        public abstract double RentCalculate(int days);

        // Concrete method
        public void DetailsDisplay()
        {
            Console.WriteLine("Vehicle ID: " + idOfVehicle);
            Console.WriteLine("Brand: " + brandOfVehicle);
            Console.WriteLine("Model: " + modelOfVehicle);
            Console.WriteLine("Rent/Day: " + perDayRent);
            Console.WriteLine("Available: " + isAvailableOrNot);
        }

    }
}
