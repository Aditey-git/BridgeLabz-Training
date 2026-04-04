using System;

public class SumOfAllNumbers{
    static void Main(){
        double[] nums = new double[10];
        double sum = 0.0;
        int i = 0;

        //Getting Input while loop
        while(true){
            Console.Write("Enter a number:");
            double input = Convert.ToDouble(Console.ReadLine());
            if(input <= 0){
                break;
            }
            if(i == 10){
                break;
            }

            nums[i] = input;
            i++;
        }

        //Calculating the sum 
        for(int j = 0;j < i;j++){
            Console.WriteLine(nums[j]);
            sum += nums[j];
        }

        //Displaying the resultant Sum
        Console.WriteLine($"The sum of numbers is {sum}");
    }
}
