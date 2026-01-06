using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.Scenario_bases.FestivalLuckyDraw
{
    internal class LuckyDraw
    {
        // Method to check if a draw was successfull or not
        public int Draw(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("Zero is an invalid number for this game");
                return 0;
            }
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Hurray! You have won a gift!");
                return 1;
            }
            Console.WriteLine("Try Again!");
            return 0;
        }

    }
}
