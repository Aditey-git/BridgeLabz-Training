using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.OnlineFoodDeliverySystem
{
    internal interface IDiscountable
    {
        double ApplyDiscount(FoodItem item);
        void GetDiscountDetails(FoodItem item);
    }
}
