using System;

public class Factorial {
    static void Main() {
        Console.WriteLine("Enter an integer:");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0) {
            int factorial = 1;
            int i = 1;

            while (i <= num) {
                factorial *= i;
                i++;
            }

            Console.WriteLine($"The factorial of {num} is {factorial}");
        }
        else {
            Console.WriteLine("Enter a positive integer");
        }
    }
}
