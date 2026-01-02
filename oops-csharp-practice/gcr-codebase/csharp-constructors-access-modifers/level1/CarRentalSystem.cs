using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.Constructor_Instance.level1
{
    internal class CarRentalSystem
    {
        public string customerName;
        public string carModel;
        public int rentalDays;
        public double total;

        public CarRentalSystem(){
            customerName = "Customer";
            carModel = "Hatchback";
            rentalDays = 1;
            TotalCostCalculate();
        }


        // Parameterized constructor
        public CarRentalSystem(string customerName, string carModel, int rentalDays){
            this.customerName = customerName;
            this.carModel = carModel;
            this.rentalDays = rentalDays;
            TotalCostCalculate();
        }

        //Method to calculate total cost
        private void TotalCostCalculate(){
            double perDayCost;

            if (carModel == "Hatchback") perDayCost = 1500;
            else if (carModel == "Sedan") perDayCost = 2500;
            else if (carModel == "SUV") perDayCost = 3500;
            else perDayCost = 2000; 

            total = perDayCost * rentalDays;
        }


        // Method to display rental details
        public void RentalDetailsDisplay(){
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Car Model: {carModel}");
            Console.WriteLine($"Rental Days: {rentalDays}");
            Console.WriteLine($"Total Cost: ₹{total}");
        
        }

        public static void CarRent()
        {
            // Default rental
            CarRentalSystem rental1 = new CarRentalSystem();

            // Parameterized rental
            CarRentalSystem rental2 = new CarRentalSystem("Aditey Rai", "SUV", 4);

            rental1.RentalDetailsDisplay();
            rental2.RentalDetailsDisplay();
        }
    }
}
