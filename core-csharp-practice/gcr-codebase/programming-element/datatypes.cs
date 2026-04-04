using System;

public class DataTypes{
	static void Main(){
		//Different types of Primitive Data Types
		int integer = 7; //32 bit 
		long longInteger = 7; //64 bit 
		char character = 'd';
		float deciamalVal = 7.7f; //32 bit
		double largerDecimalValue = 7.7; //64 bit
		bool boolean = true;
		
		Console.WriteLine("This is int dataType:" + integer);
		Console.WriteLine("This is long dataType:" + longInteger);
		Console.WriteLine("This is char dataType:" + character);
		Console.WriteLine("This is float dataType:" + deciamalVal);
		Console.WriteLine("This is double dataType:" + largerDecimalValue);
		Console.WriteLine("This is boolean dataType:" + boolean);
		
		objectDataExample obj = new objectDataExample();
		obj.Printing(); //This is an object dataType
		
		
		
			// implicit conversion
			char ch2 = 'A';
			int number1 = ch2;
			long number2 = number1;
			float number3 = number2;
			double number4 = number3;
			
			Console.WriteLine(ch2);
			Console.WriteLine(number1);
			Console.WriteLine(number2);
			Console.WriteLine(number3);
			Console.WriteLine(number4);
			
			
			// explicit conversion
			char char3 = Convert.ToChar(65);
			int number5 = Convert.ToInt32(222134532L);
			
			Console.WriteLine(char3);
			Console.WriteLine(number5);


	}
	
}

public class objectDataExample{
	public void Printing(){
		Console.WriteLine("This is an object dataType");
	}
} 