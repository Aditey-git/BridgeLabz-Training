using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.BankingSystem
{
    internal class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accNo, string name, double balance)
            : base(accNo, name, balance)
        {
        }

        public override double InterestCalculate()
        {
            return AccountBalance * 0.04;
        }
    }
}
