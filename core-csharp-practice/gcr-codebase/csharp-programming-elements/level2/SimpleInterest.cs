using System;

public class SimpleInterest{
	static void Main(string[] args){
		Console.WriteLine("Enter principal:");
		int principal = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter rate:");
		int rate = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter time:");
		int time = Convert.ToInt32(Console.ReadLine());
		
		double SI = (double) (principal * rate * time)/100.0;
		Console.WriteLine($"The Simple Interest is {SI} for Principal {principal}, Rate of Interest {rate} and {time}");
	}
}