using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.VehicleRentalSystem
{
    internal class Truck : Vehicle
    {
        public Truck(string vehicleNumber, double rentalRate) : base(vehicleNumber, rentalRate)
        {
            this.TypeOfVehicle = "Truck";
        }

        public override double RentalCostCalculate(int days)
        {
            return (RateForRent * days) + 500;
        }
    }
}
