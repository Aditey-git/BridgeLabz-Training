using System;

public class PositiveOrNegative{
    static void Main(){
        int[] nums = new int[5];

        //Getting User Input
        Console.WriteLine("Enter the 5 numbers:");
        for(int i = 0;i < nums.Length;i++){
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }

        //Printing the positive or negative 
        for(int i = 0;i < nums.Length;i++){
            if(nums[i] > 0){
                if(nums[i] % 2 == 0){
                    Console.WriteLine($"{nums[i]} is even");
                }
                else{
                    Console.WriteLine($"{nums[i]} is odd");
                }
            }
            else if(nums[i] < 0){
                Console.WriteLine($"{nums[i]} is negative");
            }
            else{
                Console.WriteLine($"{nums[i]} is zero");
            }
        }

        // Comparing the first and last element of the array
        if(nums[0] == nums[nums.Length - 1]){
            Console.WriteLine("First and last elements are equal");
        }
        else if(nums[0] > nums[nums.Length - 1]){
            Console.WriteLine("First element is greater");
        }
        else{
            Console.WriteLine("First element is less");
        }
    }
}
