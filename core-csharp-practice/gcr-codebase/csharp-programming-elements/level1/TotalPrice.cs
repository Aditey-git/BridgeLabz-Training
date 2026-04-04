using System;

public class TotalPrice{
	static void Main(String[] args){
		int unitPrice = Convert.ToInt32(Console.ReadLine());
		int quantity = Convert.ToInt32(Console.ReadLine());
		
		int totalPrice = unitPrice * quantity;
		
		Console.WriteLine($"The total purchase price is INR {totalPrice} if the quantity {quantity} and unit price is INR {unitPrice}");
	}
}