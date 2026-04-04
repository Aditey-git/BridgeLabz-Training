using System;

public class PoundToWeight{
	static void Main(String[] args){
		Console.WriteLine("Enter your weight in pounds:");
		double weight = Convert.ToDouble(Console.ReadLine());
		
		double weightInKg = weight * 2.2;
		
		Console.WriteLine($"The weight of the person in pounds is {weight} and in kg is {weightInKg}");
	}
}