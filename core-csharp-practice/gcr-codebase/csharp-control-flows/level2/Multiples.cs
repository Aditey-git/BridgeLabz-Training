using System;

public class Multiples{
    static void Main(){
		//Getting input
        Console.Write("Enter the number:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Printing the result
        Console.WriteLine("Multiples:");
        for (int i = 100; i >= 1; i--){
            if (i % number == 0) {
                Console.WriteLine(i);
            }
        }
    }
}
