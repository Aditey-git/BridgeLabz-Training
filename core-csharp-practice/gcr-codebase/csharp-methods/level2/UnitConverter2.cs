using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.level2
{
    internal class UnitConverter2
    {
        // Yards to Feet Converting Method
        public static double ConvertYardsToFeet(double yard){
            double yardsTofeet = 3;
            return yard * yardsTofeet;
        }

        //Feet to Yards Converting Method
        public static double ConvertFeetToYards(double feets){
            double feetToyards = 0.333333;
            return feets * feetToyards;
        }

        //Meters to Inches Converting Method
        public static double ConvertMetersToInches(double ms){
            double metersToinches = 39.3701;
            return ms * metersToinches;
        }

        //Inches to Meters Converting Method
        public static double ConvertInchesToMeters(double inches){
            double inchesToMeters = 0.0254;
            return inches * inchesToMeters;
        }

        //Inches to Centimeters Converting Method
        public static double ConvertInchesToCentimeters(double inches){
            double inchesToCm = 2.54;
            return inches * inchesToCm;
        }
    }
}
