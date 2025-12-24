using System;

public class HeightOfPlayers{
    static void Main(){
        double[] arr = new double[11];
        double sum = 0.0;
        double mean;

        // Getting user input
        Console.WriteLine("Enter the height of 11 football players:");
        for(int i = 0;i < arr.Length;i++){
            arr[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Calculations
        for(int i = 0;i < arr.Length;i++){
            sum += arr[i];
        }

        mean = sum / arr.Length;

        // Displaying the results
        Console.WriteLine($"The mean height is {mean}");
    }
}
