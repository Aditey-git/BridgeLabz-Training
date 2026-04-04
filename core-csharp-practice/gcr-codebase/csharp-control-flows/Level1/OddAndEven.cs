using System;

public class OddAndEven {
    static void Main() {
        Console.WriteLine("Enter the number:");
        int num = Convert.ToInt32(Console.ReadLine());

		for (int i = 1; i <= number; i++) {
            if (i % 2 == 0) {
                Console.WriteLine($"{i} is Even");
            }
            else {
                Console.WriteLine($"{i} is Odd");
            }
        }
    }
}
