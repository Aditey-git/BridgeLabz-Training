
using System;

public class KilometerToMiles {
    static void Main() {
        
        double kilometers = Convert.ToDouble(Console.ReadLine());
		 double miles = kilometers * 0.621371;
        
        Console.WriteLine(miles);
    }
}