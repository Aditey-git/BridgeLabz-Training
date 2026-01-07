using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.VehicleRentalSystem
{
    internal abstract class Vehicle
    {
        public string NumberOfVehicle { get; private set; }
        public string TypeOfVehicle { get; protected set; }
        public double RateForRent { get; private set; }

        protected Vehicle(string vehicleNumber, double rentalRate)
        {
            this.NumberOfVehicle = vehicleNumber;
            this.RateForRent = rentalRate;
        }

        public abstract double RentalCostCalculate(int numberOfDays);
    }
}
