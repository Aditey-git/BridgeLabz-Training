using System;

public class Calculator{
    static void Main(){
        // Get input values
        Console.Write("Enter first number: ");
        double firstNum = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double secondNum = Convert.ToDouble(Console.ReadLine());

        Console.Write("Choose operator (+, -, *, /): ");
        string op = Console.ReadLine();

        // Performing calculation using switch-case
        switch (op){
            case "+":
                Console.WriteLine(firstNum + secondNum);
                break;

            case "-":
                Console.WriteLine(firstNum - secondNum);
                break;

            case "*":
                Console.WriteLine(firstNum * secondNum);
                break;

            case "/": 
                Console.WriteLine(firstNum / secondNum);
                break;

            default:
                Console.WriteLine("Operator Invalid");
                break;
        }
    }
}

