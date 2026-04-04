using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.Inheritance
{
    internal class VehicleHybrid
    {
        public int MaximumSpeed;
        public string VehicleModel;

        public VehicleHybrid(int maximumSpeed, string modelOfVehicle)
        {
            MaximumSpeed = maximumSpeed;
            VehicleModel = modelOfVehicle;
        }

        public void InfoDisplay()
        {
            Console.WriteLine($"Model     : {VehicleModel}");
            Console.WriteLine($"Max Speed : {MaximumSpeed} km/h");
        }
    }


    // Interface
    interface Refuelable
    {
        void RefuelTheVehicle();
    }


    // Subclass: ElectricVehicle
    class ElectricVehicleSubclass : Vehicle
    {
        public ElectricVehicleSubclass(int maximumSpeed, string modelOfVehicle)
            : base(maximumSpeed, modelOfVehicle)
        {
        }

        public void ChargeEv()
        {
            Console.WriteLine("Charging the electric vehicle");
        }
    }

    // Subclass: PetrolVehicle (Hybrid Inheritance)
    class PetrolVehicleSubclass : Vehicle, Refuelable
    {
        public PetrolVehicleSubclass(int maximumSpeed, string modelOfVehicle)
            : base(maximumSpeed, modelOfVehicle)
        {
        }

        public void RefuelTheVehicle()
        {
            Console.WriteLine("Refueling with petrol");
        }
    }

    class VehicleManagementClass
    {
        static void VehicleHybridManagement()
        {
            ElectricVehicleSubclass evVehicle = new ElectricVehicleSubclass(160, "Tesla Model 3");
            PetrolVehicleSubclass pvVehicle = new PetrolVehicleSubclass(180, "Honda City");

            evVehicle.InfoDisplay();
            evVehicle.ChargeEv();

            Console.WriteLine();

            pvVehicle.InfoDisplay();
            pvVehicle.RefuelTheVehicle();
        }
    }
}
