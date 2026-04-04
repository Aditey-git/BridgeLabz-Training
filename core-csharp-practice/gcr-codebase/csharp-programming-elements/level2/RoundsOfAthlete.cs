using System;

public class AthleteRounds{
    static void Main(){
        Console.Write("Enter side 1:");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 2:");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 3:");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Perimeter of the triangle
        double perimeter = side1 + side2 + side3;

        // Distance to be covered 
        double distance = 5000;

        // Number of rounds
        double rounds = distance / perimeter;
        Console.WriteLine($"The total number of rounds the athlete will run is {rounds} to complete 5 km");
    }
}
