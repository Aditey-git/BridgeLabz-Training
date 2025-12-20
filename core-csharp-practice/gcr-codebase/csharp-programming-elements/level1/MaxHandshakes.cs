using System;

class MaxHandshakes{

    static void Main(string[] args) {
	
        //Number of students
        int students  = Convert.ToInt32(Console.ReadLine());
		
		int maxHandshakes = (students * (students - 1)) / 2;		
		
        Console.WriteLine($"The maximum number of possible handshakes is {maxHandshakes}");
		
    }
}
