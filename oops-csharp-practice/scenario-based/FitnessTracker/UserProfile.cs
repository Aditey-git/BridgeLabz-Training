using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.FitnessTracker
{
    //user profile
    internal  class UserProfile
    {
        //field for user and some fileds are encapsulate
        public string IdOfUser {  get; private set; }
        public string NameOfUser { get; private set; }

        public int AgeOfUser { get; private set; }

        public int CountOfUser { get; private set; }

        public string GenderOfUser { get; private set; }

        public int CaloriesGoal { get; private set; }

        //constructor for user
        public UserProfile(string id,string name,int age,string gender,int caloriesGoal) 
        {
            this.IdOfUser = id;
            this.NameOfUser = name;
            this.GenderOfUser = gender;
            this.CaloriesGoal = caloriesGoal;
            this.CountOfUser++;
        }

        //overriding the tostring method
        public override string ToString()
        {
            return $"ID : {IdOfUser}, Name : {NameOfUser}, Age : {AgeOfUser}, Gender : {GenderOfUser}";
        }


        //method to change the calories of a user
        public void CaloriesChanger(int count) 
        { 
            this.CaloriesGoal -= count;
            Console.WriteLine($"Remaining calories to burn {CaloriesGoal}");
        }
    }
}
