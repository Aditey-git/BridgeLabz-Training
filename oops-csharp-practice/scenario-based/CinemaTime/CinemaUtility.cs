using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.CinemaTime
{
    internal class CinemaUtility : ICinema
    {
        public string[] TitlesFetch()
        {
            return new string[] { "Bahubali", "3 Idiots", "Dangal", "Jawan", "Pathan" };
        }

        public string[] FetchShowTimings()
        {
            return new string[] { "18:30", "21:00", "15:45", "20:15", "17:00" };
        }

        public void AddAMovie(ref string[] titlesArr, ref string[] timingArr, string movieTitle, string timing)
        {
            if (!TimeValidate(timing))
            {
                Console.WriteLine("Invalid time format. Use HH:MM (Example: 18:30)");
                return;
            }

            int newSize = titlesArr.Length + 1;

            string[] newTitles = new string[newSize];
            string[] newTimes = new string[newSize];

            for (int i = 0; i < titlesArr.Length; i++)
            {
                newTitles[i] = titlesArr[i];
                newTimes[i] = timingArr[i];
            }

            newTitles[newSize - 1] = movieTitle;
            newTimes[newSize - 1] = timing;

            titlesArr = newTitles;
            timingArr = newTimes;

            Console.WriteLine("Movie added successfully!");
        }

        private bool TimeValidate(string timing)
        {
            string[] partsArr = timing.Split(':');

            if (partsArr.Length != 2)
                return false;

            if (!int.TryParse(partsArr[0], out int hour))
                return false;

            if (!int.TryParse(partsArr[1], out int minute))
                return false;

            if (hour < 0 || hour > 23 || minute < 0 || minute > 59)
                return false;

            return true;
        }

        public void SearchAMovie(string[] titlesArr, string[] timesArr, string keyword)
        {
            bool found = false;

            for (int i = 0; i < titlesArr.Length; i++)
            {
                if (titlesArr[i].ToLower().Contains(keyword.ToLower()))
                {
                    Console.WriteLine(titlesArr[i] + " at " + timesArr[i]);
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("No movie found!");
        }

        public void MoviesDisplay(string[] titlesArr, string[] timesArr)
        {
            for (int i = 0; i < titlesArr.Length; i++)
            {
                Console.WriteLine(titlesArr[i] + " - " + timesArr[i]);
            }
        }

        public void ReportGenerate(string[] titlesArr, string[] timesArr)
        {
            Console.WriteLine("=== Printable Report ===");

            for (int i = 0; i < titlesArr.Length; i++)
            {
                Console.WriteLine(titlesArr[i] + " at " + timesArr[i]);
            }
        }
    }
}