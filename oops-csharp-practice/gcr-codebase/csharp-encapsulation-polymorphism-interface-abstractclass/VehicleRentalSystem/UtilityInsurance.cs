using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.VehicleRentalSystem
{
    internal class UtilityInsurance : IInsurable
    {
        private string NumberOfPolicy = "INS-45879";

        public double CalculateInsurance(Vehicle vehicle)
        {
            return vehicle.RateForRent * 0.05;
        }

        public void GetInsuranceDetails(Vehicle vehicle)
        {
            Console.WriteLine($"Insurance applied on {vehicle.TypeOfVehicle}");
            Console.WriteLine($"Policy Number: {NumberOfPolicy}");
            Console.WriteLine($"Insurance Amount: {CalculateInsurance(vehicle)}");
        }
    }
}
