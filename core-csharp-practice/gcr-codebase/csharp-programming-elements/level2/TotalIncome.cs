using System;

public class TotalIncome{
    static void Main(String[] args){
        Console.WriteLine("Enter the salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the bonus: ");
        double bonus = Convert.ToDouble(Console.ReadLine());

        double totalIncome = salary + bonus;
        Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {totalIncome}");
    }
}
