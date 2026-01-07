using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.VehicleRentalSystem
{
    internal interface IInsurable
    {
        double CalculateInsurance(Vehicle vehicle);
        void GetInsuranceDetails(Vehicle vehicle);
    }
}
