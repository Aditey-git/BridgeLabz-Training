using System;

public class Division{
	static void Main(){
		Console.WriteLine("Enter number 1:");
		int num1 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter number 2:");
		int num2 = Convert.ToInt32(Console.ReadLine());
		
		int quotient = num1 / num2;
		
        int remainder = num1 % num2;
		
		
		Console.WriteLine($"The Quotient is {quotient} and Remainder is {remainder} of two numbers {num1} and {num2}");
		
	}
}