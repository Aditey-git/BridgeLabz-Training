using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.FitnessTracker
{
    //interface for the application
    internal interface ITrackable
    {
        public Workout CardioCreate();

        public Workout StrengthCreate();

        public Workout BalanceCreate();

        public void UserCaloriesUpdate(Workout workout, int index, UserProfile user);



        
    }
}
