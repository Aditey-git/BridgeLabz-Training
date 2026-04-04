using System;

public class AbundantNumber{
    static void Main(){
		// Getting input
        Console.Write("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for(int i = 1;i < num;i++){
            if(num % i == 0){
                sum = sum + i;
            }
        }

        // Printing Result
        if(sum > num){
            Console.WriteLine("Abundant Number");
        } else{
            Console.WriteLine("Not an Abundant Number");
        }
    }
}
