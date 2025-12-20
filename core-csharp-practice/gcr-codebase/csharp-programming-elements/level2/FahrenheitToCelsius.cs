using System;

public class TemperatureConvert
{
    static void Main(string[] args)
    {
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheitTemperature = Convert.ToDouble(Console.ReadLine());

        double celsiusTemperature = (fahrenheitTemperature - 32) * 5 / 9;
		Console.WriteLine($"The {fahrenheitTemperature} Fahrenheit is {celsiusTemperature} Celsius");
    }
}
