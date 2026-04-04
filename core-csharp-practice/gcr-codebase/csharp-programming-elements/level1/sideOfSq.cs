using System;

class SideOfSq{

    static void Main(string[] args) {
	
        double perimeter = Convert.ToDouble(Console.ReadLine());
		
		double sideLen = perimeter/4;
        Console.WriteLine($"The length of the side is {sideLen} whose perimeter is {perimeter}");
		
    }
}
