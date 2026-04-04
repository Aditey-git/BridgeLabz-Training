using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.RideHailingSystem
{
    internal class GPSUtility : IGPS
    {
        private object location;

        public object CurrentLocationGetter()
        {
            return location;
        }

        public object LocationUpdater()
        {
            Console.WriteLine("Enter current latitude:");
            string lati = Console.ReadLine();

            Console.WriteLine("Enter current longitude:");
            string lngi = Console.ReadLine();

            location = new
            {
                Latitude = lati,
                Longitude = lngi
            };

            Console.WriteLine("Location updated");
            return location;
        }
    }
}
