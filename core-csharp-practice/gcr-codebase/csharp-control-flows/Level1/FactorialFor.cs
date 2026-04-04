using System;

public class FactorialFor {
    static void Main() {
        Console.WriteLine("Enter an integer:");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0) {
            int factorial = 1;

            for (int i = 1; i <= num; i++) {
                factorial *= i;
            }

            Console.WriteLine($"The factorial of {num} is {factorial}");
        }
        else {
            Console.WriteLine("Enter a positive integer");
        }
    }
}
