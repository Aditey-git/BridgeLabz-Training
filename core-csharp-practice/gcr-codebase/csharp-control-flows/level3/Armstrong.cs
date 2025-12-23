using System;

public class ArmstrongNumber{
    static void Main(){

        // Getting Input
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int original = num;

        //Calculation of the result
        int sum = 0;
        while(original != 0){
            int remainder = original % 10; //Finding out last digit
            sum = sum + (remainder * remainder * remainder);
            original = original / 10;//Removing the last digit
        }

        //Printing the result
        if(sum == num){
            Console.WriteLine($"{num} is an Armstrong Number");
        }
        else{
            Console.WriteLine($"{num} is not an Armstrong Number");
        }
    }
}
