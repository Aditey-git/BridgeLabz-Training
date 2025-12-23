using System;

public class MarksAndGrades{
	static void Main(){
		Console.Write("Enter Physics marks:");
		int physics = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter Chemistry marks:");
		int chemistry = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter Maths marks:");
		int maths = Convert.ToInt32(Console.ReadLine());
		
		double average = (double) (maths + physics + chemistry) / 3; 
		
		if(average >= 80){
			Console.WriteLine($"Average Marks : {average:F2}, Grade : A, Level 4, above agency-normalized standards.");
		}
		else if(average >= 70 && average < 80){
			Console.WriteLine($"Average Marks : {average:F2}, Grade : B, Level 3, at agency-normalized standards.");
		}
		else if(average >= 60 && average < 70){
			Console.WriteLine($"Average Marks : {average:F2}, Grade : C, Level 2, below, but approaching at agency-normalized standards.");
		}
		else if(average >= 50 && average < 60){
			Console.WriteLine($"Average Marks : {average:F2}, Grade : D, Level 1, well below agency-normalized standards.");
		}
		else if(average >= 40 && average < 50){
			Console.WriteLine($"Average Marks : {average:F2}, Grade : E, Level 1-, too below agency-normalized standards.");
		}
		else{
			Console.WriteLine($"Average Marks : {average:F2}, Grade : F, Remedial Standards");
		}		
	}
}