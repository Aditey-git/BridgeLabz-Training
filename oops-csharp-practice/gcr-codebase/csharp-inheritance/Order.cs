using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.Inheritance
{
    
        // Base class
        internal class Order
        {
            public int Id;
            public DateTime DateOfOrder;

            public Order(int Id, DateTime Date)
            {
                this.Id = Id;
                DateOfOrder = Date;
            }

            // Virtual method
            public virtual string OrderStatusGetter()
            {
                return "Placed Order";
            }
        }

        // Subclass: ShippedOrder
        class ShippedOrderSubclass : Order
        {
            public string NumberToTracking;

            public ShippedOrderSubclass(int Id, DateTime DateOfOrder, string NumberForTracking)
                : base(Id, DateOfOrder)
            {
                NumberToTracking = NumberForTracking;
            }

            public override string OrderStatusGetter()
            {
                return "Order Shipped";
            }
        }

        // Subclass: DeliveredOrder (Multilevel)
        class DeliveredOrderSubclass : ShippedOrderSubclass
        {
            public DateTime DateOfDelivery;

            public DeliveredOrderSubclass(int Id, DateTime dateOfOrder, string NumberForTracking, DateTime DateOfDelivery)
                : base(Id, dateOfOrder, NumberForTracking)
            {
                this.DateOfDelivery = DateOfDelivery;
            }

            public override string OrderStatusGetter()
            {
                return "Order Delivered";
            }
        }
 


    class OrderManagementClass
    {
        static void OrderManagement()
        {
            Order ord1 = new Order(1001, DateTime.Today);
            Order ord2 = new ShippedOrderSubclass(1002, DateTime.Today.AddDays(-2), "TRK12345");
            Order ord3 = new DeliveredOrderSubclass(1003, DateTime.Today.AddDays(-5), "TRK67890", DateTime.Today);

            Console.WriteLine(ord1.OrderStatusGetter());
            Console.WriteLine(ord2.OrderStatusGetter());
            Console.WriteLine(ord3.OrderStatusGetter());
        }
    }
}
