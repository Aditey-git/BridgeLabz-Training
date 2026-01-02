using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.Constructor_Instance.level1
{
    internal class Circle
    {
        public double radius;

        // Default constructor
        public Circle() : this(1.0)   // calls parameterized constructor
        {
        }


        // Parameterized constructor
        public Circle(double r)
        {
            radius = r; 
        }   

        public static void CircleRadius()
        {

            Circle c1 = new Circle();     //default radius
            Circle c2 = new Circle(4.2);  //user-prvided radius
        }


    }
}

