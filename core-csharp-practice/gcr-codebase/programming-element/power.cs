using System;
public class Power {
    static void Main() {
        
        int number = Convert.ToInt32(Console.ReadLine());
        int power = Convert.ToInt32(Console.ReadLine());

        double answer = Math.Pow(number, power);
        Console.WriteLine(answer);
    }
}