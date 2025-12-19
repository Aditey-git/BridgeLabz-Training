
using System;

public class ThreeNumbersAvg {
    static void Main(String[] args) {
		
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        int number3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine((number1 + number2 + number3)/3);
    }
}