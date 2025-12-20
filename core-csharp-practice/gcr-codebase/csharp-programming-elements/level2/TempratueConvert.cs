using System;

public class TemperatureConvert
{
    static void Main(String[] args)
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsiusTemprature = Convert.ToDouble(Console.ReadLine());

        double fahrenTemprature = (celsiusTemprature * 9 / 5) + 32;
		Console.WriteLine($"The {celsiusTemprature} Celsius is {fahrenTemprature} Fahrenheit");
    }
}