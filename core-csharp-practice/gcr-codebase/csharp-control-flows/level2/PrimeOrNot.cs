using System;

public class PrimeOrNot{
    static void Main(){
        Console.WriteLine("Enter the number:");
        int num = Convert.ToInt32(Console.ReadLine());

        bool isPrime = true;

        if (num <= 1) {
            isPrime = false;
        }
        else{
            for (int i = 2; i <= num/2; i++){
                if (num % i == 0) {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime){
            Console.WriteLine("Prime Number");
        }else{
            Console.WriteLine("Not a Prime Number");
        }
    }
}
