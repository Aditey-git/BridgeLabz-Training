using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.Scenario_bases.busRouteTracking
{
    internal class RouteTracker
    {
        private double totalDis = 0;

        // Method to add distance for a stop
        public void StopDistanceAdder(double dist)
        {
            totalDis += dist;
            Console.WriteLine($"Distance added: {dist} km");
            Console.WriteLine($"Total distance so far: {totalDis} km");
            Console.WriteLine("===========================================");
        }

        // Method to display total distance
        public void TotalDistanceDisplay()
        {
            Console.WriteLine($"Total distance travelled: {totalDis} km");
            Console.WriteLine("=============================================");
        }

    }
}
