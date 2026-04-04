using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction.BankingSystem
{
    internal class BankMain
    {
        public static void main(string[] args)
        {
            BankingMenu menu = new BankingMenu();
            menu.BankMenu();
        }
    }
}
