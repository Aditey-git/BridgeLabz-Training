using System;

public class LeapYear{
    static void Main(){
        Console.WriteLine("Enter the year:");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year >= 1582){
            if (year % 400 == 0){
                Console.WriteLine("Leap Year");
            }
            else if (year % 100 == 0) {
                Console.WriteLine("Not a Leap Year");
            }
            else if (year % 4 == 0) {
                Console.WriteLine("Leap Year");
            }
            else{
                Console.WriteLine("Not a Leap Year");
            }
        }
        else{
            Console.WriteLine("Year must be after 1581");
        }
    }
}
