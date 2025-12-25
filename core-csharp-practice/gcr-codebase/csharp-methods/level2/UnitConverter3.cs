using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.level2
{
    internal class UnitConverter3
    {
        //Fahrenheit to Celsius Converting Method
        public static double ConvertFarhenheitToCelsius(double fh){
            double fhToCelsius = (fh - 32) * 5 / 9;
            return fhToCelsius;
        }

        //Celsius to Fahrenheit Converting Method
        public static double ConvertCelsiusToFarhenheit(double degreeCelsius){
            double celsiusToFarhenheit = (degreeCelsius * 9 / 5) + 32;
            return celsiusToFarhenheit;
        }

        //Pounds to Kilograms Converting Method
        public static double ConvertPoundsToKilograms(double pounds){
            double poundsToKilograms = 0.453592;
            return pounds * poundsToKilograms;
        }

        //Kilograms to Pounds Converting Method
        public static double ConvertKilogramsToPounds(double kgs){
            double kgToPounds = 2.20462;
            return kgs * kgToPounds;
        }

        //Gallons to Liters Converting Method
        public static double ConvertGallonsToLiters(double gallon){
            double gallonToLiters = 3.78541;
            return gallon * gallonToLiters;
        }

        //Liters to Gallons Converting Method
        public static double ConvertLitersToGallons(double lts){
            double ltsToGallons = 0.264172;
            return lts * ltsToGallons;
        }
    }
}
