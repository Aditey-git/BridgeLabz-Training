using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.OnlineFoodDeliverySystem
{
    internal class FoodMenu
    {
        private IDiscountable discountUtility;

        public void Menu()
        {
            discountUtility = new DiscountUtility();

            FoodItem item =
                new VegItem("Paneer Butter Masala", 250, 2);

            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("Press 1 : Show item details");
                Console.WriteLine("Press 2 : Calculate total price");
                Console.WriteLine("Press 3 : Apply discount");
                Console.WriteLine("Press 4 : Show final amount");
                Console.WriteLine("Press 5 : Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        item.ItemDetailsGetter();
                        break;

                    case 2:
                        Console.WriteLine(item.TotalPriceCalculate());
                        break;

                    case 3:
                        Console.WriteLine(discountUtility.ApplyDiscount(item));
                        break;

                    case 4:
                        double finalAmount =
                            item.TotalPriceCalculate() -
                            discountUtility.ApplyDiscount(item);
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
