using System;

public class Chocolates{
    static void Main(){
        Console.WriteLine("Number of chocolates:");
        int chocolatesNum = Convert.ToInt32(Console.ReadLine());

        Console.Write("number of children: ");
        int children = Convert.ToInt32(Console.ReadLine());

        int chocolatesPerChild = chocolatesNum / children;
        int remainingChoco = chocolatesNum % children;

        Console.WriteLine($"The number of chocolates each child gets is {chocolatesPerChild} " 
		+ $"and the number of remaining chocolates is {remainingChoco}");
    }
}
