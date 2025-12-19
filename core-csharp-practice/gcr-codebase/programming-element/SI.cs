using System;

public class SimpleInterest {
    static void Main() {
        
        int principle = Convert.ToInt32(Console.ReadLine());
        int rate = Convert.ToInt32(Console.ReadLine());
        int time = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine((principle * rate * time)/100);
    }
}