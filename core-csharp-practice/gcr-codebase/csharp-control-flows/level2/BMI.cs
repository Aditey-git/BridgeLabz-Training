using System;

public class BMI{
    static void Main(string[] args){
		//Taking Inputs from User
        Console.Write("Enter weight:");
        double weightOfPerson = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height:");
        double heightOfPerson = Convert.ToDouble(Console.ReadLine());

        double heightInMeter = heightOfPerson / 100;  //Conversion from centimeter to meter
        double BMI = weightOfPerson / (heightInMeter * heightInMeter);
		
		//Conditional Statements

        if (BMI <= 18.5){
            Console.WriteLine("Underweight");
        }
        else if (BMI <= 24.9){
            Console.WriteLine("Normal");
        }
        else if (BMI <= 39.9){
            Console.WriteLine("Overweight");
        }
        else{
            Console.WriteLine("Obese");
        }
    }
}
