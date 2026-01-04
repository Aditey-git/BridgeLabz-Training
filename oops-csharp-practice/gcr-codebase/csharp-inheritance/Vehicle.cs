using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.Inheritance
{
    internal class Vehicle
    {
        public int MaximumSpeed;
        public string TypeOfFuel;

        public Vehicle(int maxSpeed, string typeOfFuel)
        {
            MaximumSpeed = maxSpeed;
            TypeOfFuel = typeOfFuel;
        }

        // Virtual method
        public virtual void InfoDisplay()
        {
            Console.WriteLine($"Max Speed : {MaximumSpeed} km/h");
            Console.WriteLine($"Fuel Type: {TypeOfFuel}");
        }
    }

    // Subclass: Car
    class CarSubclass : Vehicle
    {
        public int CapacityOfSeat;

        public CarSubclass(int maximumSpeed, string typeOfFuel, int capacityOfFuel)
            : base(maximumSpeed, typeOfFuel)
        {
            CapacityOfSeat = capacityOfFuel;
        }

        public override void InfoDisplay()
        {
            Console.WriteLine("Car Details:");
            base.InfoDisplay();
            Console.WriteLine($"Seat Capacity: {CapacityOfSeat}");
        }
    }

    // Subclass: Truck
    class TruckSubclass : Vehicle
    {
        public int PayloadCapacity;

        public TruckSubclass(int maximumSpeed, string typeOfFuel, int capacityOfPayload)
            : base(maximumSpeed, typeOfFuel)
        {
            PayloadCapacity = capacityOfPayload;
        }

        public override void InfoDisplay()
        {
            Console.WriteLine("Truck Details:");
            base.InfoDisplay();
            Console.WriteLine($"Payload Capacity: {PayloadCapacity} kg");
        }
    }

    // Subclass: Motorcycle
    class MotorcycleSubclass : Vehicle
    {
        public bool Sidecar;

        public MotorcycleSubclass(int maximumSpeed, string typeOfFuel, bool SideCar)
            : base(maximumSpeed, typeOfFuel)
        {
            Sidecar = SideCar;
        }

        public override void InfoDisplay()
        {
            Console.WriteLine("Motorcycle Details:");
            base.InfoDisplay();
            Console.WriteLine($"Has Sidecar: {Sidecar}");
        }
    }


    class VehicleManagementSystem
    {
        static void VehicleManagement(string[] args)
        {
            // Polymorphism: Vehicle reference holding different objects
            Vehicle[] vehiclesArr ={
                new CarSubclass(180, "Petrol", 5),
                new TruckSubclass(120, "Diesel", 10000),
                new MotorcycleSubclass(160, "Petrol", false)
            };

            foreach (Vehicle vehicle in vehiclesArr){
                vehicle.InfoDisplay();
                Console.WriteLine();
            }
        }
    }
}
