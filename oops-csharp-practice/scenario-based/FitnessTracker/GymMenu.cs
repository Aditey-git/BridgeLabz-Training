using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.FitnessTracker
{
    
    //menu for the application
    internal class GymMenu
    {
        private ITrackable trackable;

        public void GymFitnessMenu()
        {
            trackable = new TrackableUtility();
            Workout Cardio = trackable.CardioCreate();
            Workout Strength = trackable.CardioCreate();
            Workout Balance = trackable.BalanceCreate();

            UserProfile user = TakeUserInput();

            bool True = true;

            while (True)
            {
                Console.WriteLine("Press 1 : To do cardio");
                Console.WriteLine("Press 2 : To do strenght training");
                Console.WriteLine("Press 3 : To do balance training");
                Console.WriteLine("Press 4 : To view remaining calories");
                Console.WriteLine("Press 5 : Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) 
                {
                    case 1:
                        Console.WriteLine("Press 1 : Running");
                        Console.WriteLine("Press 2 : Skipping");
                        Console.WriteLine("Press 3 : Cycling");
                        Console.WriteLine("Press 4 : Jumping Jacks");
                        Console.WriteLine("Press 5 : StairClimbing");
                        int option = Convert.ToInt32(Console.ReadLine());
                        if (option > 6)
                        {
                            Console.WriteLine("Entered wrong choice");
                            continue;
                        }
                        trackable.UserCaloriesUpdate(Cardio,option - 1,user);
                        break;

                    case 2:
                        Console.WriteLine("Press 1 : Push-ups");
                        Console.WriteLine("Press 2 : Squats");
                        Console.WriteLine("Press 3 : DeadLifts");
                        Console.WriteLine("Press 4 : Plank");
                        Console.WriteLine("Press 5 : Lunges");
                        int option2 = Convert.ToInt32(Console.ReadLine());
                        if (option2 > 6)
                        {
                            Console.WriteLine("Entered wrong choice");
                            continue;
                        }
                        trackable.UserCaloriesUpdate(Strength, option2 - 1, user);
                        break;

                    case 3:
                        Console.WriteLine("Press 1 : Single leg stand");
                        Console.WriteLine("Press 2 : Tree pose");
                        Console.WriteLine("Press 3 : Heel to toe walk");
                        Console.WriteLine("Press 4 : Bosu Ball Squats");
                        Console.WriteLine("Press 5 : SideLegRaises");
                        int option3 = Convert.ToInt32(Console.ReadLine());
                        if (option3 > 6)
                        {
                            Console.WriteLine("Entered wrong choice");
                            continue;
                        }
                        trackable.UserCaloriesUpdate(Cardio, option3 - 1, user);
                        break;

                    case 4:
                        if(user.CaloriesGoal < 0)
                        {
                            Console.WriteLine("You have completed your goal you can exit ");
                            break;
                        }
                        Console.WriteLine($"Your remaning calories are {user.CaloriesGoal}");
                        break;

                    case 5:
                        True = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }
            }

            

        }

        public UserProfile TakeUserInput()
        {
            Console.WriteLine("Enter your user id");
            string idOfUser = Console.ReadLine();
            Console.WriteLine("Enter your name");
            string nameOfUser = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int ageOfAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your gender");
            string genderOfUser = Console.ReadLine();
            Console.WriteLine("Enter your calories goal :");
            int calorieGoal = Convert.ToInt32(Console.ReadLine());

            UserProfile user = new UserProfile(idOfUser, nameOfUser, ageOfAge, genderOfUser, calorieGoal);
            return user;
        }
        


    }
}
