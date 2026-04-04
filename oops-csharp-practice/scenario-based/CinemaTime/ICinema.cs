using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.CinemaTime
{
    internal interface ICinema
    {
        void AddAMovie(ref string[] titles, ref string[] times, string title, string time);
        void SearchAMovie(string[] titles, string[] times, string keyword);
        void MoviesDisplay(string[] titles, string[] times);
        string[] TitlesFetch();
        string[] FetchShowTimings();
        void ReportGenerate(string[] titlesArr, string[] timings);
    }
}
