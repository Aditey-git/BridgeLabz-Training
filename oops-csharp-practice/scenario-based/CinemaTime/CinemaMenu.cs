using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.CinemaTime
{
    internal class CinemaMenu
    {
        private ICinema cinema;

        public void Menu()
        {
            cinema = new CinemaUtility();

            bool trueOrNot = true;

            string[] titlesArr = cinema.TitlesFetch();
            string[] timesArr = cinema.FetchShowTimings();

            while (trueOrNot)
            {
                Console.WriteLine("Choose one Option =>");
                Console.WriteLine("Press 1 : Add A Movie");
                Console.WriteLine("Press 2 : Search A Movie");
                Console.WriteLine("Press 3 : Display All Movies");
                Console.WriteLine("Press 4 : Generate A Report");
                Console.WriteLine("Press 5 : Exit");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter Movie Title:");
                        string movieTitle = Console.ReadLine();

                        Console.WriteLine("Enter Time (HH:MM):");
                        string duration = Console.ReadLine();

                        cinema.AddAMovie(ref titlesArr, ref timesArr, movieTitle, duration);
                        break;

                    case 2:
                        Console.WriteLine("Enter keyword:");
                        string keyword = Console.ReadLine();
                        cinema.SearchAMovie(titlesArr, timesArr, keyword);
                        break;

                    case 3:
                        cinema.MoviesDisplay(titlesArr, timesArr);
                        break;

                    case 4:
                        cinema.ReportGenerate(titlesArr, timesArr);
                        break;

                    case 5:
                        trueOrNot = false;
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}
