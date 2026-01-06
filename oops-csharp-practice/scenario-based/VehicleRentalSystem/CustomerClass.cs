using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.Scenario_bases.VehicleRentalSystem
{
    internal class CustomerClass
    {
        private int idOfCustomer;
        private string nameOfCustomer;
        public CustomerClass(int idOfCustomer, string nameOfCustomer)
        {
            this.idOfCustomer = idOfCustomer;
            this.nameOfCustomer = nameOfCustomer;
        }
        public void RentVehicle(Vehicle vehicle, int numOfDays)
        {
            Console.WriteLine("Customer Name : " + nameOfCustomer);
            vehicle.DetailsDisplay();
            Console.WriteLine("Total Rent    : " + vehicle.RentCalculate(numOfDays));
            Console.WriteLine("--------------------------------");
        }

    }
}
