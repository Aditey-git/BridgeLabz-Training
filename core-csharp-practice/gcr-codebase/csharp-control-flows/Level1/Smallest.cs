using System;

public class Smallest{
	static void Main(){
		Console.Write("Enter number 1:");
		int num1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter number 2:");
		int num2 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter number 3:");
		int num3 = Convert.ToInt32(Console.ReadLine());
		
		if(num2 > num1 && num3 > num1){
			Console.WriteLine("Is the first number the smallest? Yes");
		} else {
			Console.WriteLine("Is the first number the smallest? No");
		}
	}
}