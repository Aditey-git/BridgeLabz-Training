using System;

public class Operators{
	
	class Parent{
		
	}

	
	static void Main(){
		//Arithmetic Operators 
		Console.WriteLine(" '+' This is addition operator = " + (3+4));
		Console.WriteLine(" '-' This is Subtraction operator = " + (5-4));
		Console.WriteLine(" '*' This is Multiplication operator = " + (3*4));
		Console.WriteLine(" '/' This is Division operator = " + (8/4));
		Console.WriteLine(" '%' This is Modulus operator = " + (7%4));
		
		
		//Realtional Operators
		int x = 12;
		int y = 10;
		Console.WriteLine(x == y); 
		Console.WriteLine(x != y);
		Console.WriteLine(x > y);
		Console.WriteLine(x < y); 
		Console.WriteLine(x >= y); 
		Console.WriteLine(x <= y);
		
		//Logical Operators
		Console.WriteLine(x<y && y>x);
		Console.WriteLine(x<y || y>x);
		Console.WriteLine(!(x == y));
		
		
		// 4 Assignment Operators
		
		int a = 4;
		x += 4;
		y -= 3;
		x *= 2;
		y /= 10;
		x %= 2;

		// 5 Unary Operators
		
		int z = +x;
		int f = -x;
		a++;
		a--;
		Console.WriteLine(!true);
		
		//Ternary operator
		int maximum = (x > y) ? x : y;
		Console.WriteLine(maximum);

		//'is' operator
		Parent obj = new Parent();
		Console.WriteLine(obj is Parent);

	}
}