using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.Scenario_based.atm_dispenser
{
    internal class AtmMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Atm");
            AtmUtility atm = new AtmUtility();
            Console.WriteLine("Scenario A -> Given ₹1, ₹2, ₹5, ₹10, ₹20, ₹50, ₹100, ₹200, ₹500 notes, find optimal.");
            atm.ScenarioA();
            Console.WriteLine("Scenario B -> Remove ₹500 temporarily and update strategy.");
            atm.ScenarioB();
            Console.WriteLine("Scenario C -> Display fallback combo if exact change isn’t possible.");
            atm.ScenarioC();
        }
    }
}
