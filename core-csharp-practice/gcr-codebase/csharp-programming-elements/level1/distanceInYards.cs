using System;

class DistanceInYards{

    static void Main(string[] args) {
	
        double feets = Convert.ToDouble(Console.ReadLine()); //Enter Distance in feet
		
		double yards = feets / 3;
		double miles = yards / 1760;
		
        Console.WriteLine($"Your distance in miles is {miles} miles and yard is {yards} yards");
		
    }
}
