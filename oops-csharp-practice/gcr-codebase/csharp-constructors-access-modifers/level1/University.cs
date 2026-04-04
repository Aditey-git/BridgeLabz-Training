using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.Constructor_Instance.level1
{
    internal class University
    {
        public int rollNumber;

        protected string name;

        private double cgpa;

        // Constructor
        public University(int rollNumber, string name, double cgpa)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.cgpa = cgpa;
        }

        //Public method to access CGPA
        public double CGPA()
        {
            return cgpa;
        }

        // Public method to modify CGPA
        public void CGPASetter(double cgpaNew)
        {
            if (cgpaNew >= 0.0 && cgpaNew <= 10.0)
            {
                cgpa = cgpaNew;
            }
            else
            {
                Console.WriteLine("Invalid CGPA value.");
            }
        }
    }

        // Subclass to demonstrate protected member access
        internal class Postgraduates : University
        {
            public string specializationSubject;

            public Postgraduates(int rollNumber, string name, double cgpa, string specializationSubject)
                : base(rollNumber, name, cgpa)
            {
                this.specializationSubject = specializationSubject;
            }

            public void DisplayPostGraduateStudentDetails()
            {
                Console.WriteLine($"Roll Number: {rollNumber}");  // public
                Console.WriteLine($"Name: {name}");        // protected
                Console.WriteLine($"Specialization : {specializationSubject}");
                Console.WriteLine($"CGPA: {CGPA()}");   // private accessed via public method
            }
        }



    internal class ProgramClass
    {
        static void UniversitySystem(string[] args)
        {
            Postgraduates pgStudent = new Postgraduates(101, "Aditey Rai", 7.7, "Computer Science");

            pgStudent.DisplayPostGraduateStudentDetails();

       
            pgStudent.CGPASetter(9.1);
            Console.WriteLine("Updated CGPA: " + pgStudent.CGPA());
        }
    }
}
