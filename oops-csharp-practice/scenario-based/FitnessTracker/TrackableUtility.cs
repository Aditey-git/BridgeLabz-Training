using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.FitnessTracker
{
    //utility class to implement methods accros application
    internal class TrackableUtility : ITrackable
    {
        //method to create cardio
        public Workout CardioCreate()
        {
            string[] exercisesArr = { "Running", "Skipping", "Cycling", "Junping Jacks", "Stair Climbing" };
            int[] workoutCaloriesArr = { 300, 350, 250, 200, 300 };
            Workout workout = new Workout("Cardiovascular", exercisesArr, workoutCaloriesArr);
            return workout;
        }

        // methos to create strength
        public Workout StrengthCreate()
        {
            string[] exercisesArr = { "Push-ups", "Squats", "Deadlifts", "Plank", "Lunges" };
            int[] workoutCaloriesArr = { 200, 250, 300, 180, 220 };
            Workout workout = new Workout("Strength Training", exercisesArr, workoutCaloriesArr);
            return workout;

        }

        //method to create balance
        public Workout BalanceCreate()
        {
            string[] exercisesArr = { "Single-leg stand", "Tree Pose", "Heel-to-toe walk", "Bosu Ball Squats", "Side Leg Raises" };
            int[] workoutCaloriesArr = { 100, 120, 90, 150, 110 };
            Workout workout = new Workout("Balance Training",exercisesArr, workoutCaloriesArr);
            return workout;

        }

        public void UserCaloriesUpdate(Workout workout, int index, UserProfile user)
        {


            Console.WriteLine($"Completed exercise {workout.ExercisesOfWorkout[index]}");
            user.CaloriesChanger(workout.CaloriesOfWorkout[index]);

            
        }
    }
}
