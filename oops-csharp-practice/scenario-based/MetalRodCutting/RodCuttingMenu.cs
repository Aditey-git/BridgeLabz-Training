using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.metal_factory_pipe_cutting
{
    class RodCuttingMenu
    {
        private IRodCuttingStrategy strategy;
        private int lengthOfRod = 8;
        private int[] pricesArr = { 1, 5, 8, 9, 10, 17, 17, 20 };
        public void ScenarioA()
        {
            strategy = new RodCuttingUtility();
            
            Console.WriteLine("===== Optimized Strategy =====");
            Console.WriteLine("Max profit --> " + strategy.MaxProfit(pricesArr, lengthOfRod));
        }
        public void ScenarioB()
        {
            Console.Write("Enter the number of pieces --> ");
            int pieces = int.Parse(Console.ReadLine());
            if(lengthOfRod % pieces == 0)
            {
                Console.WriteLine("Profit --> " + pricesArr[((lengthOfRod-1)/pieces)] * pieces);
            }
        }
        public void ScenarioC()
        {
            Console.Write("Enter the number of pieces --> ");
            int piecesInput = int.Parse(Console.ReadLine());
            if(piecesInput > lengthOfRod || lengthOfRod % piecesInput != 0)
            {
                Console.WriteLine("Invalid Input");
                return;
            }
            else
            {
                Console.WriteLine("Profit --> " + pricesArr[lengthOfRod-1/piecesInput] * piecesInput);
            }
        }
    }
}
