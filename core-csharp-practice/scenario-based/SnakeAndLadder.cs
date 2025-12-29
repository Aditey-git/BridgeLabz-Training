using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  Summary:-
  This program implements a console-based Snake 
  and Ladder game using core C# concepts without using 
  OOP or collection frameworks. It supports multiple players (2–4) who 
  take turns rolling a dice and moving on a 100-cell board. 
  The game applies snake and ladder rules and continues until a 
  player reaches exactly position 100, 
  at which point the winner is declared.
  */


namespace BridgeLabzTraining.Scenario_Based
{
    internal class SnakeAndLadder
    {

        //Method to start the Snake and Ladder game
        public static void SnakeAndLadderImplementation()
        {
            //Getting number of players input from the user
            Console.WriteLine("Enter the number of players between 2 and 4:");
            int numberOfPlayers = Convert.ToInt32(Console.ReadLine());

            if (numberOfPlayers > 4 && numberOfPlayers < 2)
            {
                Console.WriteLine("Number of players is Invalid!");
            }

            int[] playerArray = new int[numberOfPlayers];

            bool didWin = false;

            //Game loop continues until a player wins
            while (!didWin)
            {
                // Loop for each player's turn
                for (int i = 0; i < playerArray.Length; i++)
                {
                    int diceNumber = RollDice();
                    Console.WriteLine($"Dice throw: {diceNumber}");


                    int oldPosition = playerArray[i];
                    int newPosition = MovePlayer(playerArray[i], diceNumber);

                    if(oldPosition == newPosition)
                    {
                        Console.WriteLine("Cannot move! Next Position exceeds 100");
                        continue;
                    }


                    int resultingPosition = ApplySnakeAndLadder(newPosition);
                    Console.WriteLine($"Moving player from {oldPosition} to {resultingPosition}");
                    playerArray[i] = resultingPosition;
                    bool winCheck = CanWin(playerArray[i]);
                    if (winCheck)
                    {
                        Console.WriteLine($"Player {i+1} WINS!");
                        didWin = true;
                        break;
                    }
                }
            }


        }


        //Method to roll the dice and get a number
        public static int RollDice() {
            Random rand = new Random();
            return rand.Next(1, 7);
        }


        //Method to move the player from one position to another
        public static int MovePlayer(int oldPosition,int diceValue) {
            if ((diceValue + oldPosition) > 100) return oldPosition;
            return diceValue + oldPosition;
        }


        //Method to check if the position has a snake or ladder
        public static int ApplySnakeAndLadder(int newPosition)
        {
            int[] snakes = {99, 89, 63, 24};
            int[] snakesDown = {5, 43, 27, 9};

            int[] ladders = { 7, 22, 48, 73 };
            int[] laddersUp = {38, 52, 78, 94 };
            
            for(int i = 0;i < snakes.Length;i++)
            {
                if(newPosition == snakes[i])
                {
                    Console.WriteLine($"Haww! You were cut by a Snake and you will move to {snakesDown[i]}");
                    return snakesDown[i];
                }
            }


            for (int i = 0; i < ladders.Length; i++)
            {
                if(newPosition == ladders[i])
                {
                    Console.WriteLine($"Hurray! You climbed a ladder to {laddersUp[i]}");
                    return laddersUp[i];
                }
            }


            return newPosition;
        }


        //Method to see if any player wins after a dice roll or not
        public static bool CanWin(int position)
        {
            return position == 100;
        }
    }
}
