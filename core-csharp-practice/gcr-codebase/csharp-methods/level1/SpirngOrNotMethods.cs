using System;

public class SpringOrNotMethods
{
    static void Main(string[] args){
        //getting input from Command Line
        int month = Convert.ToInt32(args[0]);
        int day = Convert.ToInt32(args[1]);

        bool answer = SpringCheck(month, day);//Calling the method

        if(answer){
            Console.WriteLine("Spring Season");
        }
        else{
            Console.WriteLine("Not Spring Season");
        }
    }
	
	//Method to check spring season
	 public static bool SpringCheck(int month, int day){
        if((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20)){
            return true;
        }
        return false;
    }
}
