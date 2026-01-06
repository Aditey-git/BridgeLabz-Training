using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.Scenario_bases.VehicleRentalSystem
{
    internal class TruckVehicle : Vehicle
    {
        public TruckVehicle(int id, string brand, string model, double rentPerDay)
            : base(id, brand, model, rentPerDay)
        {
        }

        public override double RentCalculate(int numOfDays)
        {
            return (numOfDays * perDayRent) + 2000; // Heavy vehicle charge
        }

    }
}
