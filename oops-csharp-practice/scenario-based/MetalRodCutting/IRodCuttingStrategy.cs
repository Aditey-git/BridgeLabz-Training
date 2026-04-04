namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.metal_factory_pipe_cutting
{
    interface IRodCuttingStrategy
    {
        int MaxProfit(int[] pricesArr, int lengthOfRod);
        int Profit(int[] pricesArr, int lengthOfRod);
    }
}
