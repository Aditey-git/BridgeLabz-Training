using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.RideHailingSystem
{
    internal class Car : Vehicle
    {
        public Car(string carId, string carDriver)
            : base(carId, carDriver, 15)
        {
        }

        public override double FareCalculate(double distance)
        {
            return distance * RatePerKm;
        }
    }
}
