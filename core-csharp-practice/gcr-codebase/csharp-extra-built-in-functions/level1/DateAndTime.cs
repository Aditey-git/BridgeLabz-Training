using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.BuiltIn
{
    internal class DateAndTime
    {
        public static void DateAndTimeFn() {
            DateTimeOffset utcTimeNow = DateTimeOffset.UtcNow;
            //Get time zone information
            TimeZoneInfo gmtZoneTime = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            TimeZoneInfo istTimeZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            TimeZoneInfo pstTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

            // Convert UTC time to different time zones
            DateTimeOffset gmtT = TimeZoneInfo.ConvertTime(utcTimeNow, gmtZoneTime);
            DateTimeOffset istT = TimeZoneInfo.ConvertTime(utcTimeNow, istTimeZone);
            DateTimeOffset pstT = TimeZoneInfo.ConvertTime(utcTimeNow, pstTimeZone);

            // Display results
            Console.WriteLine("Current Time in Different Time Zones:");
            Console.WriteLine("GMT : " + gmtT);
            Console.WriteLine("IST : " + istTimeZone);
            Console.WriteLine("PST : " + pstTimeZone);
        }
    }
}
