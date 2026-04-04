using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Arrays.level2
{
    internal class YoungestFriend
    {
        public static void Youngest()
        {
            string[] names = { "Amar", "Akbar", "Anthony" };

            int[] age = new int[3];
            double[] height = new double[3];

            // Getting input from user
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter age:");
                age[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Enter height:");
                height[i] = Convert.ToDouble(Console.ReadLine());
            }

            int youngest = 0;
            int tallest = 0;

            // Loop to find youngest and tallest
            for (int i = 1; i < 3; i++)
            {
                if (age[i] < age[youngest])
                {
                    youngest = i;
                }

                if (height[i] > height[tallest])
                {
                    tallest = i;
                }
            }

            // Displaying the results
            Console.WriteLine($"Youngest friend is {names[youngest]}");
            Console.WriteLine($"Tallest friend is {names[tallest]}");
        }
    }
}
