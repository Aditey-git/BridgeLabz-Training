using System;

public class PowerOfNumber{
    static void Main(){

        // Getting inputs for number and power
        Console.WriteLine("Enter the number:");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the power:");
        int power = Convert.ToInt32(Console.ReadLine());

        //Calculating the result
        int result = 1;
        for (int i = 1; i <= power; i++){
            result *= number;
        }

        Console.WriteLine($"{number} to the power {power} is {result}"); //Printing the result
    }
}
