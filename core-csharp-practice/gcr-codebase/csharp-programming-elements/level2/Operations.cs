using System;

public class Operations {
	static void Main(string[] args){
		Console.WriteLine("Enter a:");
		int a = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter b:");
		int b = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter c:");
		int c = Convert.ToInt32(Console.ReadLine());
		
		int op1 = a+b*c;
		int op2 = a*b+c;
		int op3 = c+a/b;
		
		Console.WriteLine($"The results of the Int Operations are {op1}, {op2}, and {op3}");
		
	}
}