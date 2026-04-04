using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.VehicleRentalSystem
{
    internal class VehicleMenu
    {
        private IInsurable insuranceUtility;

        public void Menu()
        {
            insuranceUtility = new UtilityInsurance();

            Vehicle vehicle = new Car("CAR101", 2000);

            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("Press 1 : Show rental cost");
                Console.WriteLine("Press 2 : Show insurance amount");
                Console.WriteLine("Press 3 : Show insurance details");
                Console.WriteLine("Press 4 : Show final amount");
                Console.WriteLine("Press 5 : Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(vehicle.RentalCostCalculate(3));
                        break;

                    case 2:
                        Console.WriteLine(insuranceUtility.CalculateInsurance(vehicle));
                        break;

                    case 3:
                        insuranceUtility.GetInsuranceDetails(vehicle);
                        break;

                    case 4:
                        double finalAmount = vehicle.RentalCostCalculate(3) + insuranceUtility.CalculateInsurance(vehicle);
                        Console.WriteLine(finalAmount);
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
