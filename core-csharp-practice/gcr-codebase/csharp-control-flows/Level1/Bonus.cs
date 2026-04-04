using System;

public class Bonus {
    static void Main() {
        Console.WriteLine("Enter the salary:");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter years of service:");
        int ServiceYears = Convert.ToInt32(Console.ReadLine());

        if (yearsOfService > 5) {
            double bonus = salary * 0.05;   // 5% = 5/100
            Console.WriteLine($"Your bonus amount is {bonus}");
        }
        else {
            Console.WriteLine("You will not get a bonus");
        }
    }
}
