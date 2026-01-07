using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.OnlineFoodDeliverySystem
{
    internal class VegItem : FoodItem
    {
        public VegItem(string nameOfVegItem, double price, int qty)
            : base(nameOfVegItem, price, qty)
        {
        }

        public override double TotalPriceCalculate()
        {
            return PriceOfFood * FoodQuantity;
        }
    }
}
