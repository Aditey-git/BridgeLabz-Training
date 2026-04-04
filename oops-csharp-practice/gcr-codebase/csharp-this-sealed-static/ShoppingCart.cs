using BridgeLabzTraining.Oops.Constructor_Instance.level1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.ThisSealedStatic
{
    internal class ShoppingCart
    {
        // static variable shared by all products
        public static double DiscountPercent = 10.0; // percentage

        // static method to update discount
        public static void UpdateDiscount(double newDiscountPercent)
        {
            DiscountPercent = newDiscountPercent;
        }

        // readonly variable for unique ID
        public readonly string ProductID;

        // instance variables
        public string NameOfProduct;
        public double PriceOfProduct;
        public int QuantityOfProduct;

        // constructor using 'this' to resolve ambiguity
        public ShoppingCart(string ProductID, string NameOfProduct, double PriceOfProduct, int QuantityOfProduct)
        {
            this.ProductID = ProductID;
            this.NameOfProduct = NameOfProduct;
            this.PriceOfProduct = PriceOfProduct;
            this.QuantityOfProduct = QuantityOfProduct;
        }

        // method to calculate total price after discount
        public double TotalPriceGetter()
        {
            double totalPrice = PriceOfProduct * QuantityOfProduct;
            double discountedPrice = totalPrice * (1 - DiscountPercent / 100.0);
            return discountedPrice;
        }

        // method that uses 'is' to validate object type before printing
        public void ProductDetailsDisplay(object obj)
        {
            if (obj is Product)
            {
                Console.WriteLine("Product ID: " + ProductID);
                Console.WriteLine("Name      : " + NameOfProduct);
                Console.WriteLine("Price     : " + PriceOfProduct);
                Console.WriteLine("Quantity  : " + QuantityOfProduct);
                Console.WriteLine("Discount  : " + DiscountPercent + "%");
                Console.WriteLine("Total     : " + TotalPriceGetter());
            }
            else
            {
                Console.WriteLine("Object is not a Product instance.");
            }
        }
    }



    internal class ProductManagement
    {
        static void ProductManage()
        {
            // create a few products
            ShoppingCart product1 = new ShoppingCart("P001", "Wireless Mouse", 599.0, 2);
            ShoppingCart product2 = new ShoppingCart("P002", "USB-C Cable", 299.0, 3);

            Console.WriteLine("Initial discount: " + ShoppingCart.DiscountPercent + "%\n");

            // display details
            product1.ProductDetailsDisplay(product1);
            Console.WriteLine();
            product2.ProductDetailsDisplay(product2);
            Console.WriteLine();

            // update discount for all products
            ShoppingCart.UpdateDiscount(15.0);
            Console.WriteLine("Updated discount: " + ShoppingCart.DiscountPercent + "%\n");

            // display again to see new totals
            product1.ProductDetailsDisplay(product1);
            Console.WriteLine();
            product2.ProductDetailsDisplay(product2);

            // example of type-check failure
            Console.WriteLine();
            object notProduct = new object();
            product1.ProductDetailsDisplay(notProduct);
        }
    }
}
