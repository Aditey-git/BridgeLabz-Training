using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.metal_factory_pipe_cutting
{
    class RodCuttingUtility : IRodCuttingStrategy
    {
        public int MaxProfit(int[] prices, int rodLength)
        {
            if (rodLength == 0)
            {
                return 0;
            }
            int max = int.MinValue;
            for(int i=1; i<=rodLength; i++)
            {
                max = Math.Max(max, prices[i-1] + MaxProfit(prices, rodLength - i));
            }
            return max;
        }

        public int Profit(int[] prices, int rodLength)
        {
            int idx = rodLength / 2 - 1;
            return prices[idx] * 2;
        }
    }
}
