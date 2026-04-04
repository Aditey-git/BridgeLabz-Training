using System;

public class Multiplication{
    static void Main(){
        //Getting Input from user
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int[] arrResults = new int[10];
        for(int i = 0;i < 10;i++){
            arrResults[i] = num * (i+1);
        }

        // Display the resultant Multiplication table
        Console.WriteLine("\nMultiplication Table:");
        for(int i = 0;i < 10;i++){
            Console.WriteLine($"{num} * {i+1} = {arrResults[i]}");
        }
    }
}
