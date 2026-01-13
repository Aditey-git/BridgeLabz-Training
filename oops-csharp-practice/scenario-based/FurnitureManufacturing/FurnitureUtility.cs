using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.CustomFurnitureMnufacturing
{
    internal class FurnitureUtility : IFurniture
    {
        private Furniture furniture = new Furniture();
        

        public int Profit(int n)
        {
            int[] furnitureLength = furniture.getLength();
            int[] furniturePriceArr = furniture.getPrice();

            int[] dpArray = new int[n + 1];


            dpArray[0] = 0;

            for (int i = 1; i <= n; i++)
            {
                int maximum = int.MinValue;

                for (int j = 0; j < furnitureLength.Length; j++)
                {
                    if (furnitureLength[j] <= i)
                    {
                        maximum = Math.Max(maximum, furniturePriceArr[j] + dpArray[i - furnitureLength[j]]);
                    }
                }

                dpArray[i] = maximum;
            }

            return dpArray[n];
        }


       
        public  int ProfitWithWaste(int n, int allowedWaste)
        {

           
            int[] furnitureLength = furniture.getLength();
            int[] furniturePrice = furniture.getPrice();
            int[] dpArray = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                int maximum = 0;

                for (int j = 0; j < furnitureLength.Length; j++)
                {
                    if (furnitureLength[j] <= i)
                    {
                        maximum = Math.Max(maximum, furniturePrice[j] + dpArray[i - furnitureLength[j]]);
                    }
                }

                dpArray[i] = maximum;
            }

            int bestProfit = 0;

            for (int used = n - allowedWaste; used <= n; used++)
            {
                bestProfit = Math.Max(bestProfit, dpArray[used]);
            }

            return bestProfit;
        }
    }
}
