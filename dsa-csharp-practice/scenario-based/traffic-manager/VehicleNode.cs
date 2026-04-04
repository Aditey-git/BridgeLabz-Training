using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.VehicleManager
{
    internal class VehicleNode
    {
        public string VehicleNumber;
        public VehicleNode next;

        public VehicleNode(string number)
        {
            VehicleNumber = number;
            next = null;
        }
    }
}
