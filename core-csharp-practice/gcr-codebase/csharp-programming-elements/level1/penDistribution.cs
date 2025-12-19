using System;

public class penDistribution{
	static void Main (){
		int pens = 14;
		int students = 3;
		int penPerStudent = pens/students;
		int remaining = pens%students;
		Console.WriteLine("The pen per student is " + penPerStudent + "and the remaining pen not distributed is " + remaining);
	}
}