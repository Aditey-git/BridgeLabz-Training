using System;

public class SumUntilZero{
	static void Main(){
		double total = 0.0;
		
		double number = Convert.ToDouble(Console.ReadLine());
		
		while (true){
			total += number;
			
			number = Convert.ToDouble(Console.ReadLine());
			
			if(number <= 0){
				break;
			}
		}			
		
		Console.WriteLine(total);
	}
}