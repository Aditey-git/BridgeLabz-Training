using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.RideHailingSystem
{
    internal class RiderMenu
    {
        private IGPS gpsUtility;

        public void Menu()
        {
            gpsUtility = new GPSUtility();

            Vehicle vehicle =
                new Car("CAR101", "Amit");

            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("Press 1 : Show vehicle details");
                Console.WriteLine("Press 2 : Update location");
                Console.WriteLine("Press 3 : Get current location");
                Console.WriteLine("Press 4 : Calculate fare");
                Console.WriteLine("Press 5 : Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        vehicle.VehicleDetailsGetter();
                        break;

                    case 2:
                        gpsUtility.LocationUpdater();
                        break;

                    case 3:
                        Console.WriteLine(gpsUtility.CurrentLocationGetter());
                        break;

                    case 4:
                        Console.WriteLine(vehicle.FareCalculate(12));
                        break;

                    case 5:
                        isTrue = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}
