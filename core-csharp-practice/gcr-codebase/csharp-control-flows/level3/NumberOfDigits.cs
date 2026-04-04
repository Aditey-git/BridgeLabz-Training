using System;

public class NumberOfDigits{
    static void Main(){
		// Getting Input from user
        Console.Write("Enter the Number: ");
        int num = Convert.ToInt32(Console.ReadLine());
		
        int counter = 0;
        if (num == 0) {
            counter = 1;
        }
        else {
            while (num != 0) {
                num = num / 10; // Remove the last digit
                counter++;
            }
        }

        // Displaying the result
        Console.WriteLine("Number of digits = " + counter);
    }
}
