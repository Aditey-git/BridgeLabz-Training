using System;

public class RectPerimeter {
    static void Main() {
        
        int length = Convert.ToInt32(Console.ReadLine());
		int breadth = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(2*(length + breadth));
    }
}