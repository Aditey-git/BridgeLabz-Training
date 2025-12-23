using System;

public class FriendsComparison{
    static void Main(){
        // Taking age input
        Console.Write("Enter Amar's age:");
        int amar = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Akbar's age:");
        int akbar = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Anthony's age:");
        int anthony = Convert.ToInt32(Console.ReadLine());

        int youngest = amar;

        if (akbar < youngest)
            youngest = akbar;

        if (anthony < youngest)
            youngest = anthony;

        if (youngest == amar){
			Console.WriteLine("Amar is the youngest.");
		}
        else if (youngest == akbar){
			Console.WriteLine("Akbar is the youngest.");
		}
        else{
			Console.WriteLine("Anthony is the youngest.");
		}
		
		//Taking height Input

        Console.WriteLine("Enter Amar's height:");
        double h1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Akbar's height:");
        double h2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Anthony's height:");
        double h3 = Convert.ToDouble(Console.ReadLine());

        // Finding tallest friend
        double tallest = h1;

        if (h2 > tallest)
            tallest = h2;

        if (h3 > tallest)
            tallest = h3;

        if (tallest == h1){
			Console.WriteLine("Amar is the tallest.");
		}
        else if (tallest == h2){
			Console.WriteLine("Akbar is the tallest.");
		}
        else{
			Console.WriteLine("Anthony is the tallest.");
		}
    }
}
