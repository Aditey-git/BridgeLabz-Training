using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.VehicleRentalSystem
{
    internal class Car : Vehicle
    {
        public Car(string numberOfVehicle, double rateForRent) : base(numberOfVehicle, rateForRent)
        {
            this.TypeOfVehicle = "Car";
        }

        public override double RentalCostCalculate(int numberOfDays)
        {
            return RateForRent * numberOfDays;
        }
    }

}
