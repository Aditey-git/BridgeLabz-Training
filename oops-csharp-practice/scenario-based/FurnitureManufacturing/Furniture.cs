using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.CustomFurnitureMnufacturing
{
    internal class Furniture
    {
        public int[] ArrLength { get; private set; }
        public int[] ArrPrice { get; private set; }

        public Furniture()
        {
            this.ArrLength = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            this.ArrPrice = new int[] { 2, 5, 7, 8, 10, 13, 17, 18, 20, 22, 24, 25 };
        }

        public int[] getLength()
        {
            return this.ArrLength; 
        }

        public int[] getPrice()
        {
            return this.ArrPrice;
        }
        
    }
}
