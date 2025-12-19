using System;

public class profitAndLoss{
	static void Main(){
		int cp = 129;
		int sp = 191;
		
		int profit = sp - cp;
		double percentage = ((double)profit/cp) * 100;
		
		Console.WriteLine("The Cost Price is INR " + cp + " and Selling Price is INR " 
		+ sp + " The Profit is INR " + profit + " and the profit percentage is " + percentage);
		
	}
}