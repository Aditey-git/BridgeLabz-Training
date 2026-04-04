using System;

public class volOfEarth{
	static void Main(){
		double EarthRadius = 6378;
		
		double volumeInKm = (4.0 / 3.0) * Math.PI * Math.Pow(EarthRadius, 3);
		
		double volumeInMiles = (4.0 / 3.0) * Math.PI * Math.Pow(EarthRadius * 0.621371, 3);
		
		Console.WriteLine("The volume of earth in cubic kilometers is " + volumeInKm + " and cubic miles is " + volumeInMiles);
	}
}