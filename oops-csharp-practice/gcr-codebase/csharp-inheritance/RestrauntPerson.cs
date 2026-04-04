using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BridgeLabzTraining.Oops.Inheritance
{
    internal class RestaurantPerson
    {
        public string NameOfPerson;
        public int PersonId;

        public RestaurantPerson(string nameOfPerson, int personID)
        {
            NameOfPerson = nameOfPerson;
            PersonId = personID;
        }
    }

    interface Workers
    {
        void DutyToPerform();
    }


    // Subclass: Chef
    class ChefSubclass : Person, Workers
    {
        public string SpecialDish;

        public ChefSubclass(string nameOfChef, int chefId, string specialDish)
            : base(nameOfChef, chefId)
        {
            SpecialDish = specialDish;
        }

        public void DutyToPerform()
        {
            Console.WriteLine($"Chef {NameOfPerson} is preparing {SpecialDish} dishes.");
        }
    }

    // Subclass: Waiter
    class WaiterSubclass : Person, Workers
    {
        public int NumOfTablesAssigned;

        public WaiterSubclass(string nameOfWaiter, int waiterId, int NumOfTablesAssigned)
            : base(nameOfWaiter, waiterId)
        {
            this.NumOfTablesAssigned = NumOfTablesAssigned;
        }

        public void DutyToPerform()
        {
            Console.WriteLine($"Waiter {NameOfPerson} is serving {NumOfTablesAssigned} tables.");
        }
    }

    class Restaurant
    {
        static void RestaurantManagement()
        {
            // Worker interface references
            Workers wor1 = new ChefSubclass("Aditey", 101, "Indian");
            Workers wor2 = new WaiterSubclass("Sambhav", 102, 6);

            wor1.DutyToPerform();
            wor2.DutyToPerform();
        }
    }
}
