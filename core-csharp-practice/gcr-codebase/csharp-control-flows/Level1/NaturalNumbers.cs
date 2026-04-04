using System;

public class NaturalNumbers{
	static void Main(){
		Console.WriteLine("Enter the number:");
		int number = Convert.ToInt32(Console.ReadLine());
		
		if (number >= 0){
            int sum = number * (number + 1) / 2;
            Console.WriteLine($"The sum of {number} natural numbers is {sum}");
        }
        else
        {
            Console.WriteLine(number + " is not a natural number");
        }
		
	}
}