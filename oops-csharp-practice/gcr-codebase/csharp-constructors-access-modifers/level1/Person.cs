using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace BridgeLabzTraining.Oops.Constructor_Instance.level1
{
    internal class Person
    {

        //Attributes
        public string Name;
        public int Age;
        public string City;


        //Constructor
        public Person(string name, int age, string city)
        {
            Name = name;
            Age = age;
            City = city;
        }



        // Copy constructor
        public Person(Person person2nd)
        {

            Name = person2nd.Name;
            Age = person2nd.Age;
            City = person2nd.City;

        }


        // method to test
        public static void PersonFuntion()
        {
            Person person1 = new Person("Aditey", 20, "Jaunpur");
            Person person2 = new Person(person1);

            Console.WriteLine("Original:");
            person1.DisplayDetails();

            Console.WriteLine("Cloned:");
            person2.DisplayDetails();

        }



        //Method to display details
        public void DisplayDetails()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("City: " + City);
        }
    }
}
