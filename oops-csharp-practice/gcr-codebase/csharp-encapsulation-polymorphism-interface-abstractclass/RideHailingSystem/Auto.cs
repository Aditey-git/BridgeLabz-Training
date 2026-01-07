using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.RideHailingSystem
{
    internal class Auto : Vehicle
    {
        public Auto(string autoId, string autoDriver)
           : base(autoId, autoDriver, 10)
        {
        }

        public override double FareCalculate(double dist)
        {
            return (dist * PerKmRate) + 20;
        }
    }
}
