using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.level2
{
    internal class UnitConverter
    {
        //Kilometers to Miles Converting method
        public static double ConvertKmToMiles(double kilometer){
            double kilometerTomiles = 0.621371;
            return kilometer * kilometerTomiles;
        }

        //Miles to Kilometers Converting method
        public static double ConvertMilesToKm(double miles){
            double milesTokm = 1.60934;
            return miles * milesTokm;
        }

        //Meters to Feet Converting method
        public static double ConvertMetersToFeet(double ms){
            double metersTofeet = 3.28084;
            return ms * metersTofeet;
        }

        //Feet to Meters Converting method
        public static double ConvertFeetToMeters(double feets){
            double feetTometers = 0.3048;
            return feets * feetTometers;
        }
    }
}
