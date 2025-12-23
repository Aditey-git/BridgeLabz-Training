using System;

public class FactorsOfNumber{
    static void Main(){

        //Get the input number from the user
        Console.Write("Enter the number:");
        int number = Convert.ToInt32(Console.ReadLine());

        //Calculating and Printing the factors of the number
        for(int i = 1; i < number; i++){
            if(number % i == 0){
                Console.WriteLine(i);
            }
        }
    }
}
