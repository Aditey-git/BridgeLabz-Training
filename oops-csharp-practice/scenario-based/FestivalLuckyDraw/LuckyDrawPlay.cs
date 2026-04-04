using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Summary =>
 This program serves as the entry point for a Festival Lucky Draw game.
It presents a simple menu allowing the user to either start the game or exit.
The LuckyDraw class handles the core game logic through its Draw() method.
Users repeatedly enter numbers to try their luck until a winning or exit condition is met.
The program uses nested loops to control game flow and termination.
Execution ends once the user wins the draw or chooses to exit.
 */
namespace BridgeLabzTraining2.Oops.Scenario_bases.FestivalLuckyDraw
{
    //Main class to play lucky draw 
    internal class LuckyDrawPlay
    {
        public static void Main(string[] args)
        {
            LuckyDraw obj = new LuckyDraw();
            bool exit = false;
            Console.WriteLine("Welcome to lucky draw, try your luck and win something exciting");

            Console.WriteLine("To exit the draw press 0 ");
            Console.WriteLine("To start the game press 1 ");
            Console.Write("Enter your choice --> ");

            //Loop until the program is running
            while (!exit)
            {
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        Console.WriteLine("Exiting the code...");
                        exit = true;
                        break;

                    case 1:
                        while (true)
                        {
                            Console.Write("Enter a number --> ");
                            int res = obj.Draw(int.Parse(Console.ReadLine()));

                            if (res == 1)
                            {
                                exit = true;
                                break;
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Enter a valid option (0 or 1)");
                        continue;
                }
            }
        }

    }
}
