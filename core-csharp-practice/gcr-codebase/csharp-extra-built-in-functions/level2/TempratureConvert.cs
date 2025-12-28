using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.BuiltIn.level2
{
    internal class TempratureConvert
    {
        public static void ConvertTemprature() {
            Console.WriteLine("Temperature Converter");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");
            Console.Write("Choose an option (1 or 2): ");

            int option = Convert.ToInt32(Console.ReadLine());

            if(option == 1){
                Console.Write("Enter temperature in Fahrenheit: ");
                double fht = Convert.ToDouble(Console.ReadLine());

                double cls = FahrenheitToCelsius(fht);
                Console.WriteLine($"{fht}°F = {cls:F2}°C");
            }
            else if(option == 2){
                Console.Write("Enter temperature in Celsius: ");
                double cls = Convert.ToDouble(Console.ReadLine());

                double fht = CelsiusToFahrenheit(cls);
                Console.WriteLine($"{cls}°C = {fht:F2}°F");
            }
            else{
                Console.WriteLine("Invalid choice.");
            }
        }



        //Method that Converts Fahrenheit to Celsius
        public static double FahrenheitToCelsius(double fht){
            return (fht - 32) * 5 / 9;
        }

        //Method that Converts Celsius to Fahrenheit
        public static double CelsiusToFahrenheit(double cls){
            return (cls * 9 / 5) + 32;
        }
    }
}
