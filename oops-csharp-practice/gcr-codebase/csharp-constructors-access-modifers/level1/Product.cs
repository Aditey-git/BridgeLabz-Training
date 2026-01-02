using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.Constructor_Instance.level1
{
    internal class Product
    {
        //Attributes
        public int idOfProduct;
        public string nameOfProduct;
        public double priceOfProduct;

        // Static variable to count total products
        private static int totalProductsCount = 0;

        // Constructor
        public Product(int idOfProduct, string nameOfProduct, double priceOfProduct)
        {
            this.idOfProduct = idOfProduct;
            this.nameOfProduct = nameOfProduct;
            this.priceOfProduct = priceOfProduct;
            totalProductsCount++;
        }

        // Instance method
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product ID: {idOfProduct}");
            Console.WriteLine($"Product Name: {nameOfProduct}");
            Console.WriteLine($"Price: ₹{priceOfProduct}");
        }

        // Class (static) method
        public static void DisplayTotalProducts()
        {
            Console.WriteLine($"Total Products Created: {totalProductsCount}");
        }


        public static void ProductDetails()
        {
            Product product1 = new Product(101, "Chair", 55000);
            Product product2 = new Product(102, "Table", 799);
            Product product3 = new Product(103, "Board", 1499);

            product1.DisplayProductDetails();
            product2.DisplayProductDetails();
            product3.DisplayProductDetails();

            Product.DisplayTotalProducts();
        }
    }
}
