using System;

public class SwapNumbers{
    static void Main(string[] args){
        Console.Write("Enter num1:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter num2:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Swap using temporary variable
        double temporary = num1;
        num1 = num2;
        num2 = temporary;
		Console.WriteLine($"The swapped numbers are {num1} and {num2}");
    }
}
