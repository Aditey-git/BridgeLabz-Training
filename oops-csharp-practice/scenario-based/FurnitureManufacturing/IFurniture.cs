using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.CustomFurnitureMnufacturing
{
    internal interface IFurniture
    {
        public int Profit(int n);
        public int ProfitWithWaste(int n, int wasteAllowed);
    }
}
