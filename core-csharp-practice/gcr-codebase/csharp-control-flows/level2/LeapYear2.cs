using System;

public class LeapYearWithLogical{
    static void Main(){
        Console.WriteLine("Enter the year:");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year >= 1582 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))) {
            Console.WriteLine("Leap Year");
        }
        else if (year >= 1582) {
            Console.WriteLine("Not a Leap Year");
        }
        else{
            Console.WriteLine("Year must be after 1581");
        }
    }
}
