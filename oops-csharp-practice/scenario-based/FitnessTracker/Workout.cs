using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.FitnessTracker
{
    //class for workout
    internal class Workout
    {
        //fields for workout
        public string NameOfWorkout { get; private set; }

        public string[] ExercisesOfWorkout { get; private set; }

        public int[] CaloriesOfWorkout { get; private set; }
        

        //contructor for workout
        public Workout(string workoutName, string[] workoutExercises, int[] workoutCalories) 
        {
            this.NameOfWorkout = workoutName;
            this.ExercisesOfWorkout = workoutExercises;
            this.CaloriesOfWorkout= workoutCalories;
        }

        
    }
}
