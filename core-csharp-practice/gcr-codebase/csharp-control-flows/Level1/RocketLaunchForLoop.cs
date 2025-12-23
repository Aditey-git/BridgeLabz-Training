using System;

public class RocketLaunchForLoop{
    static void Main(){
        Console.Write("Enter number:");
        int count = Convert.ToInt32(Console.ReadLine());

        for (int i = count; i >= 1;i--){
            Console.WriteLine(i);
        }
    }
}
