using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods
{
    internal class WindSpeed
    {
        public static void WindChill() {
            //getting input from the user
            Console.Write("Enter the temperature: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter wind speed: ");
            double Speed = Convert.ToDouble(Console.ReadLine());
           
            double answer = FindWindChill(temp, Speed);//Calling the method

            Console.WriteLine("Wind chill:" + answer);
        }



        public static double FindWindChill(double temp, double speed){
            double windChill = 35.74 + (0.6215 * temp) + (0.4275 * temp - 35.75) * Math.Pow(speed, 0.16);

            return windChill;
        }
    }
}
