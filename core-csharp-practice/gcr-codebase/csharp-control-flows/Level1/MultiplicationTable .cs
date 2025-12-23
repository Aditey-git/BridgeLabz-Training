using System;

public class MultiplicationTable {
    static void Main() {
        Console.WriteLine("Enter the number:");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 6; i <= 9; i++) {
            Console.WriteLine($"{num} * {i} = {num * i}"); //Printing the table line by line
        }
    }
}
