using System;

public class MultiplicationTable{
    static void Main(){
        int num;
        int[] result = new int[4];

        //Getting user input
        Console.Write("Enter the number: ");
        num = Convert.ToInt32(Console.ReadLine());

        // Calculating multiplication table
        int ind = 0;
        for(int i = 6;i <= 9;i++){
            result[ind] = num * i;
            ind++;
        }

        // Displaying the result
        ind = 0;
        for(int i = 6;i <= 9;i++){
            Console.WriteLine($"{num} * {i} = {result[ind]}");
            ind++;
        }
    }
}
