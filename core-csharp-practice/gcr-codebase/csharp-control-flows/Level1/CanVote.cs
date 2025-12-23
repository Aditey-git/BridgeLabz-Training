using System;

public class CanVote{
	static void Main(){
		Console.WriteLine("Enter the age:");
		int age = Convert.ToInt32(Console.ReadLine());
		
		if(age >= 18){
			Console.WriteLine("The person can vote");
		}
		else{
			Console.WriteLine("The person cannot vote");
		}
	}
}