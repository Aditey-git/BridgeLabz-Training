using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.BuiltIn.level2
{
    internal class GuessTheNumber
    {
        public static void NumberGuess() {
            Console.WriteLine("Choose number between 1 and 100.");
            Console.WriteLine("Respond with:");
            Console.WriteLine("'high' for too high");
            Console.WriteLine("'low' for too low");
            Console.WriteLine("'correct' for right guess");

            int lower = 1;
            int higher = 100;
            bool guessedAnswer = false;

            while(!guessedAnswer){

                int guessN = GuessGenerate(lower, higher);
                Console.WriteLine($"Computer guesses: {guessN}");

                String feedbackString = FeedbackFromUser();

                guessedAnswer = ProcessFeedback(feedbackString, guessN, ref lower, ref higher);

            }

            Console.WriteLine("Computer guessed your number");

        }


        //Method for generating computer's guess
        static int GuessGenerate(int lower, int higher){
            return (lower + higher)/2;
        }



        //Method to get feedback from the user
        static String FeedbackFromUser(){
            Console.Write("Is the guess high , low , or correct");
            return Console.ReadLine().ToLower();
        }



        //Processes feedback and updates range
        static bool ProcessFeedback(string feedbackChar, int guessInt, ref int lower, ref int higher){
            if(feedbackChar == "high"){
                higher = guessInt - 1;
            }
            else if(feedbackChar == "low"){
                lower = guessInt + 1;
            }
            else if(feedbackChar == "correct"){
                return true;
            }
            else{
                Console.WriteLine("Invalid input. Please enter high, low, or correct.");
            }

            return false;
        }
    }
}
