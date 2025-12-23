using System;

public class GreatestFactor {
    static void Main() {

        //Getting Input
        Console.WriteLine("Enter the number:");
        int number = Convert.ToInt32(Console.ReadLine());

        int Factor = 1;

        //Calculating the greatest Factor
        for (int i = number - 1; i >= 1; i--){
            if(number % i == 0){
                Factor = i;
                break;
            }
        }

        Console.WriteLine("The greatest factor behind itself: " + Factor);
    }
}
