using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  Summary =>
 This program simulates a simple bus route distance tracking system using a menu-driven approach.
It repeatedly allows the user to add the distance to the next bus stop while the journey is ongoing.
The RouteTracker object is responsible for storing and calculating the total distance travelled.
A loop ensures the program runs continuously until the passenger chooses to get off the bus.
When exiting, the program displays the total distance travelled before terminating.
 */

namespace BridgeLabzTraining2.Oops.Scenario_bases.busRouteTracking
{
    internal class BusRouteManagement
    {

        // Entry point of the application
        public static void Main(string[] args)
        {
            RouteTracker track = new RouteTracker();
            bool isRunning = true;


            // Loop continues until the passenger exits the bus
            while (isRunning)
            {
                Console.WriteLine("===== Bus Route Distance Tracker =====");
                Console.WriteLine("1. Add distance for coming stop");
                Console.WriteLine("2. Get off the bus");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter distance to next stop (in km): ");
                        double dist = double.Parse(Console.ReadLine());
                        track.StopDistanceAdder(dist);
                        break;

                    case 2:
                        track.TotalDistanceDisplay();
                        Console.WriteLine("Passenger is exiting the bus....");
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }

    }
}
