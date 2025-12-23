using System;

public class HarshadNumber{
    static void Main(){

        //Getting input
        Console.Write("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int original = num; 
        int sum = 0;              
		
        while(num != 0){
            int digit = num % 10; // retrieve last digit
            sum += digit;         
            num = num / 10;    // remove last digit
        }

        // Printing the result 
        if(original % sum == 0){
            Console.WriteLine("Harshad Number");
        }else {
            Console.WriteLine("Not a Harshad Number");
        }
    }
}
