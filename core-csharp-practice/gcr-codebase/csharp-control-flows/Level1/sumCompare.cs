using System;

public class sumCompare{
    static void Main(){
        Console.WriteLine("Enter the number:");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num >= 0){
            int Sum = 0;
            int i = 1;

            while (i <= num){
                Sum += i;
                i++;
            }

            int Sum2 = num * (num + 1) / 2;

            if (Sum == Sum2) {
                Console.WriteLine("Both sum are equal that is" + Sum);
            }
            else{
                Console.WriteLine($"The sum are not equal, sum with loop is {Sum1} and sum with formula is {Sum2}");
            }
        }
        else{
            Console.WriteLine("The number is not a natural number");
        }
    }
}
