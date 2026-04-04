using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 Summary:-
 This program analyzes temperature data stored in a 2D array representing hourly temperatures for multiple days.
It includes methods to find the hottest day (maximum temperature) and the coldest day (minimum temperature).
Another method calculates the average temperature for each day by summing hourly values.
The AnalyseTemprature method initializes sample temperature data and calls these methods.
Finally, it displays the hottest day, coldest day, and daily average temperatures to the console.
 */

namespace BridgeLabzTraining.Scenario_Based
{
    internal class TempratureAnalyser
    {
        //Method to find the hottest day
        public static int FindHottestDay(float[,] tempArray){
            int hottest = 0;
            float maximumTemp = tempArray[0, 0];

            for (int d = 0; d < tempArray.GetLength(0); d++){
                for(int hr = 0; hr < tempArray.GetLength(1); hr++){
                    if(tempArray[d, hr] > maximumTemp){
                        maximumTemp = tempArray[d, hr];
                        hottest = d;
                    }
                }
            }
            return hottest;
        }

        //Method to find the coldest day
        public static int FindColdestDay(float[,] tempArray){
            int coldest = 0;
            float minimumTemp = tempArray[0, 0];

            for (int d = 0; d < tempArray.GetLength(0); d++){
                for (int hr = 0; hr < tempArray.GetLength(1); hr++){
                    if (tempArray[d, hr] < minimumTemp){
                        minimumTemp = tempArray[d, hr];
                        coldest = d;
                    }
                }
            }
            return coldest;
        }

        // Method to calculate average temperature per day
        public static float[] AverageTemperaturePerDay(float[,] tempArray){
            int ds = tempArray.GetLength(0); // used to get length of rows/days (dimension-1)
            int hrs = tempArray.GetLength(1); // used to get length of columns/hours (dimension-2)

            float[] avgsArray = new float[ds];

            for (int d = 0; d < ds; d++){
                float addition = 0;

                for(int hr = 0; hr < hrs; hr++){
                    addition += tempArray[d, hr];
                }

                avgsArray[d] = addition / hrs;
            }
            return avgsArray;
        }

        //Method to call the above methods
        public static void AnalyseTemprature()
        {
            float[,] temperaturesArray =
            {
                { 30,31,29,28,27,26,25,24,26,28,30,32,33,34,35,36,35,34,33,32,31,30,29,28 },
                { 25,26,24,23,22,21,20,21,23,25,27,28,29,30,31,32,31,30,29,28,27,26,25,24 },
                { 28,29,27,26,25,24,23,24,26,28,30,31,32,33,34,35,34,33,32,31,30,29,28,27 },
                { 26,27,25,24,23,22,21,22,24,26,28,29,30,31,32,33,32,31,30,29,28,27,26,25 },
                { 29,30,28,27,26,25,24,25,27,29,31,32,33,34,35,36,37,36,35,34,33,32,31,30 },
                { 24,25,23,22,21,20,19,20,22,24,26,27,28,29,30,31,30,29,28,27,26,25,24,23 },
                { 27,28,26,25,24,23,22,23,25,27,29,30,31,32,33,34,33,32,31,30,29,28,27,26 }
            };

            int dayHottest = FindHottestDay(temperaturesArray);
            int dayColdest = FindColdestDay(temperaturesArray);
            float[] avgsArray = AverageTemperaturePerDay(temperaturesArray);

            Console.WriteLine("Hottest Day: Day " + (dayHottest + 1));
            Console.WriteLine("Coldest Day: Day " + (dayColdest + 1));

            for(int i = 0; i < avgsArray.Length; i++){
                Console.WriteLine($"Average temperature of Day {i + 1}: {avgsArray[i]}");
            }
        }
    }
}
