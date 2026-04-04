using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.RideHailingSystem
{
    internal abstract class Vehicle
    {
        public string IdOfVehicle { get; private set; }
        public string NameOfDriver { get; private set; }
        public double PerKmRate { get; protected set; }

        protected Vehicle(string idOfVehicle, string nameOfDriver, double perKmRate)
        {
            this.IdOfVehicle = idOfVehicle;
            this.NameOfDriver = nameOfDriver;
            this.PerKmRate = perKmRate;
        }

        public void VehicleDetailsGetter()
        {
            Console.WriteLine($"Vehicle ID : {IdOfVehicle}");
            Console.WriteLine($"Driver Name : {NameOfDriver}");
            Console.WriteLine($"Rate/Km : {PerKmRate}");
        }

        public abstract double FareCalculate(double distance);
    }
}
