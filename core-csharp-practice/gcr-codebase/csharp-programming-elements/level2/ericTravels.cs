using System;

class TravelComputation{
    public static void Main(string[] args){
		
		//Taking all the Inputs
		
        Console.Write("Enter traveler name: ");
        string name = Console.ReadLine();

        Console.Write("Enter starting city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter via city: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter destination city: ");
        string toCity = Console.ReadLine();

        Console.Write("Enter distance from start city to via city (in miles): ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter distance from via city to destination city (in miles): ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter total time taken for the journey (in minutes): ");
        int timeTaken = Convert.ToInt32(Console.ReadLine());

        // Calculation
        double totalDistance = fromToVia + viaToFinalCity;

        Console.WriteLine($"The results of the trip are: {totalDistance} miles, {timeTaken} minutes, " 
		+	$"traveling from {fromCity} to {toCity} via {viaCity}");
    }
}
