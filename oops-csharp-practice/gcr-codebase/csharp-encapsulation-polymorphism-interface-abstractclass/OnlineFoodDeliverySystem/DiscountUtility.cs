using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.OnlineFoodDeliverySystem
{
    internal class DiscountUtility : IDiscountable
    {
        private double DiscountRate = 0.10;

        public double ApplyDiscount(FoodItem item)
        {
            return item.TotalPriceCalculate() * DiscountRate;
        }

        public void GetDiscountDetails(FoodItem item)
        {
            Console.WriteLine($"Discount Rate : 10%");
            Console.WriteLine($"Discount Amount : {ApplyDiscount(item)}");
        }
    }
}
