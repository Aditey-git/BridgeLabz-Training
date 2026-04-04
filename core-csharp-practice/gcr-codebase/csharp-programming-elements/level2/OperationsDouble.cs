using System;

public class OperationsDouble
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter b:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter c:");
        double c = Convert.ToDouble(Console.ReadLine());

        double op1 = a + b * c;
        double op2 = a * b + c;
        double op3 = c + a / b;

        Console.WriteLine($"The results of the Double Operations are {op1}, {op2}, and {op3}");
    }
}
