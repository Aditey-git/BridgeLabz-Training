using System;

public class LargestOfThree{
    static void Main(){
        Console.WriteLine("Enter number 1:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number 2:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number 3:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 >= num2 && num1 >= num3){
            Console.WriteLine($"Is the first number the largest? Yes
								Is the second number the largest? No
								Is the third number the largest? No");
        }else if (num2 >= num1 && num2 >= num3){
            Console.WriteLine($"Is the first number the largest? No
								Is the second number the largest? Yes
								Is the third number the largest? No");
        }else{
            Console.WriteLine($"Is the first number the largest? No
								Is the second number the largest? No
								Is the third number the largest? Yes");
        }
    }
}
