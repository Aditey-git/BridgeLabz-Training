using System;

public class CanVote{
	static void Main(){
		int[] arr = new int[10];
		
		//Taking Input of age from the user
		
		Console.WriteLine("Enter the age of 10 students:");
		for(int i = 0;i < arr.Length;i++){
			arr[i] = Convert.ToInt32(Console.ReadLine());
		}
		
		 //Printing the result of ages
		for(int i = 0;i < arr.Length;i++){
            if(arr[i] < 0){
                Console.WriteLine("Invalid age");
            }
            else if(arr[i] >= 18){
                Console.WriteLine($"The student with the age {arr[i]} can vote.");
            }
            else{
                Console.WriteLine($"The student with the age {arr[i]} cannot vote.");
            }
        }
	}
}