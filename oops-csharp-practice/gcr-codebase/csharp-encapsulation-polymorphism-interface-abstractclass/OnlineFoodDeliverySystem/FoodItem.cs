using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.OnlineFoodDeliverySystem
{
    internal abstract class FoodItem
    {
        public string ItemName { get; private set; }
        public double PriceOfFood { get; private set; }
        public int FoodQuantity { get; private set; }

        protected FoodItem(string itemName, double priceOfFood, int quantityFood)
        {
            this.ItemName = itemName;
            this.PriceOfFood = priceOfFood;
            this.FoodQuantity = quantityFood;
        }

        public void ItemDetailsGetter()
        {
            Console.WriteLine($"Item : {ItemName}");
            Console.WriteLine($"Price : {PriceOfFood}");
            Console.WriteLine($"Quantity : {FoodQuantity}");
        }

        public abstract double TotalPriceCalculate();
    }
}
