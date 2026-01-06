using BridgeLabzTraining.Oops.Constructor_Instance.level1;
using BridgeLabzTraining.Oops.Encapsulation_polymorphism_interface_abstractclass;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BridgeLabzTraining.Oops.Encapsulation_polymorphism_interface_abstractclass
{
    abstract class ProductClass
    {
        //Encapsulated fields
        private int IdOfProduct;
        private string nameOfProduct;
        private double productPrice;

        // Constructor
        protected ProductClass(int IdOfProduct, string nameOfProduct, double productPrice)
        {
            this.IdOfProduct = IdOfProduct;
            this.nameOfProduct = nameOfProduct;
            this.productPrice = productPrice;
        }

        // Encapsulation via properties (setters allowed)
        public int ProductGetId
        {
            get { return IdOfProduct; }
        }

        public string NameGet
        {
            get { return nameOfProduct; }
            set { nameOfProduct = value; }
        }

        public double PriceGet
        {
            get { return productPrice; }
            set
            {
                if (value > 0)
                    productPrice = value;
            }
        }

        // Abstract method
        public abstract double DiscountCalculate();

        // Polymorphic final price calculation
        public double FinalPriceGetter()
        {
            double taxAmount = 0;

            if (this is ITaxable taxableProduct)
            {
                taxAmount = taxableProduct.TaxCalculate();
            }

            return PriceGet + taxAmount - DiscountCalculate();
        }

        // Display method
        public virtual void DetailsDisplay()
        {
            Console.WriteLine($"Product ID: {ProductGetId}");
            Console.WriteLine($"Name: {NameGet}");
            Console.WriteLine($"Base Price: {PriceGet}");
        }
    }


    // Interface
    interface ITaxable
    {
        double TaxCalculate();
        string TaxDetailsGetter();
    }


 

        

    // Electronics (Taxable)
    class ElectronicsClass : ProductClass, ITaxable
    {
        public ElectronicsClass(int productId, string productName, double productPrice)
            : base(productId, productName, productPrice) { }

        public override double DiscountCalculate()
        {
            return PriceGet * 0.10; // 10% discount
        }

        public double TaxCalculate()
        {
            return PriceGet * 0.18; // 18% GST
        }

        public string TaxDetailsGetter()
        {
            return "18% GST on Electronics";
        }
    }

    // Clothing (Taxable)
    class ClothingClass : ProductClass, ITaxable
    {
        public ClothingClass(int id, string name, double price)
            : base(id, name, price) { }

        public override double DiscountCalculate()
        {
            return PriceGet * 0.20; // 20% discount
        }

        public double TaxCalculate()
        {
            return PriceGet * 0.12; // 12% GST
        }

        public string TaxDetailsGetter()
        {
            return "12% GST on Clothing";
        }
    }

    // Groceries (Non-Taxable)
    class GroceriesClass : ProductClass
    {
        public GroceriesClass(int productId, string productName, double productPrice)
            : base(productId, productName, productPrice) { }

        public override double DiscountCalculate()
        {
            return PriceGet * 0.05;
        }
    }

    class ProductManagementClass
    {
        static void ProductManage()
        {
            List<ProductClass> productsArr = new List<ProductClass>
                {
                    new ElectronicsClass(1, "Charger", 6000),
                    new ClothingClass(2, "Shirt", 3000),
                    new GroceriesClass(3, "Tomato", 1200)
                };

            // Polymorphism in action
            foreach (ProductClass product in productsArr)
            {
                product.DetailsDisplay();

                if (product is ITaxable taxable)
                {
                    Console.WriteLine(taxable.TaxDetailsGetter());
                }

                Console.WriteLine($"Final Price: {product.FinalPriceGetter()}");
            }
        }
    }
}
