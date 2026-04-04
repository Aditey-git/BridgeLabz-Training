using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.BankingSystem
{
    internal class CurrentAccount : BankAccount
    {
        public CurrentAccount(string accNo, string nameOfHolder, double accBalance)
           : base(accNo, nameOfHolder, accBalance)
        {
        }

        public override double InterestCalculate()
        {
            return AccountBalance * 0.02;
        }
    }
}
