using System;

public class discountUserInput{
	static void Main(){
		int fee = Convert.ToInt32(Console.ReadLine());
		double discountPercent = Convert.ToDouble(Console.ReadLine());
		double discount = (fee * discountPercent) / 100.0;
		double finalFee = fee - discount;
		Console.WriteLine("The discount amount is INR " + discount + " and final discounted fee is INR " + finalFee);
	}
}