using System;

public class RocketLaunch{
    static void Main(){
        Console.Write("Enter number:");
        int count = Convert.ToInt32(Console.ReadLine());

        while (count >= 1){
            Console.WriteLine(count);
            count--;
        }
    }
}
