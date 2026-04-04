using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.metal_factory_pipe_cutting
{
    class RodCuttingMain
    {
        public static void Main(String[] args)
        {
            RodCuttingMenu rodCut = new RodCuttingMenu();
            rodCut.ScenarioA();
            rodCut.ScenarioB();
            rodCut.ScenarioC();
            
        }
    }
}
