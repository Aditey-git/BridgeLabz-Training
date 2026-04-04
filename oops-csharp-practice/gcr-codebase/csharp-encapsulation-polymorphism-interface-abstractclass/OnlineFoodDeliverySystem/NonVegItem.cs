using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.OnlineFoodDeliverySystem
{
    internal class NonVegItem : FoodItem
    {
        public NonVegItem(string name, double price, int qty)
            : base(name, price, qty)
        {
        }

        public override double TotalPriceCalculate()
        {
            double extraCharge = 50;
            return (PriceOfFood * FoodQuantity) + extraCharge;
        }
    }
}
