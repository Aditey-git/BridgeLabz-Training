using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.RideHailingSystem
{
    internal class Bike : Vehicle
    {
        public Bike(string id, string driver)
            : base(id, driver, 8)
        {
        }

        public override double FareCalculate(double distance)
        {
            return distance * PerKmRate;
        }
    }
}
