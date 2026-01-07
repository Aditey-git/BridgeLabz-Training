using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.VehicleRentalSystem
{
    internal class Bike : Vehicle
    {
        public Bike(string numberOfVehicle, double rateForRental) : base(numberOfVehicle, rateForRental)
        {
            this.TypeOfVehicle = "Bike";
        }

        public override double RentalCostCalculate(int numberOfDays)
        {
            return RateForRent * numberOfDays;
        }
    }
}
