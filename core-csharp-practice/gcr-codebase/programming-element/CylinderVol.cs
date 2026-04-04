using System;

public class CylinderVolume {
    static void Main() {
        
        double radius = Convert.ToDouble(Console.ReadLine());
		
        double height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(3.14*radius*radius*height);
    }
}