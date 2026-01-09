using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.LinkedList.Movie_management_system
{
    internal class DoublyListMain
    {
        public static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList();

            //Adding at the start
            list.AddAtStart("Inception", "Christopher Nolan", 2010, 5);
            list.AddAtStart("Interstellar", "Christopher Nolan", 2014, 5);

            Console.WriteLine("Movies Added at start");
            list.ForwardDisplay();
            Console.WriteLine("=======================================================");

            //Adding at the End
            list.AddAtEnd("Avengers", "Joss Whedon", 2012, 4);
            list.AddAtEnd("Titanic", "James Cameron", 1997, 5);

            Console.WriteLine("Movies Added at End");
            list.ForwardDisplay();
            Console.WriteLine("=======================================================");

            //Adding movie at the 3rd position
            list.AddAtPosition("The Dark Knight", "Christopher Nolan", 2008, 5, 3);


            Console.WriteLine("\n=== DISPLAY FORWARD ===");
            list.ForwardDisplay();
            Console.WriteLine("========================================================");

            Console.WriteLine("\n=== DISPLAY REVERSE ===");
            list.ReverseDisplay();
            Console.WriteLine("========================================================");

            Console.WriteLine("\nSEARCH BY DIRECTOR (Christopher Nolan):");
            list.SearchByDirector("Christopher Nolan");

            Console.WriteLine("\nSEARCH BY RATING (5):");
            list.SearchByRating(5);

            Console.WriteLine("\nUPDATE RATING (Titanic → 4):");
            list.UpdateRating("Titanic", 4);

            Console.WriteLine("\nDISPLAY AFTER UPDATE:");
            list.ForwardDisplay();

            //Removing movie by title
            list.RemoveByTitle("Avengers");



            Console.WriteLine("\AFTER REMOVING MOVIE(FORWARD):");
            list.ForwardDisplay();

            Console.WriteLine("\nFINAL MOVIE LIST (REVERSE)");
            list.ReverseDisplay();

        }
    }
}
