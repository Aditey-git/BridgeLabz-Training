using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.VehicleManager
{
    internal class Program
    {
        static void Main()
        {
            TrafficUtility utility = new TrafficUtility();

            while (true)
            {
                utility.ShowMenu();
                int choice = Convert.ToInt32(Console.ReadLine());
                utility.HandleChoice(choice);
            }
        }
    }
}