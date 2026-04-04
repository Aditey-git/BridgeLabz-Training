using System;

public class ArOfTriangle{

    static void Main(string[] args) {
	
        double breadth = Convert.ToDouble(Console.ReadLine());

        double height = Convert.ToDouble(Console.ReadLine());
		
		double area = 0.5 * breadth * height;
        Console.WriteLine($"The area of the triangle is {area}");
		
    }
}