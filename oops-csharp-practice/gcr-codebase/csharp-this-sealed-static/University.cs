using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.ThisSealedStatic
{
    internal class UniversityStudent
    {
        // static variable shared across all students
        public static string NameOfUniversity = "Delhi Technological University";
        private static int TotalNumberOfStudents = 0;

        // readonly variable (cannot be changed after assignment)
        public readonly int RollNum;

        // instance variables
        public string NameOfStudent;
        public char GradeOfStudents;

        // constructor using 'this' keyword
        public UniversityStudent(string NameOfStudent, int RollNum, char GradeOfStudents)
        {
            this.NameOfStudent = NameOfStudent;
            this.RollNum = RollNum;
            this.GradeOfStudents = GradeOfStudents;
            TotalNumberOfStudents++;
        }

        // static method to display total students
        public static void TotalStudentsDisplay()
        {
            Console.WriteLine("Total Students: " + TotalNumberOfStudents);
        }

        // method to update grade (with type check)
        public void GradeUpdater(object obj, char Grade)
        {
            if (obj is UniversityStudent)
            {
                GradeOfStudents = Grade;
            }
            else
            {
                Console.WriteLine("Invalid object. Cannot update grade.");
            }
        }

        //method to display student details (with type check)
        public void StudentDetailsDisplay(object obj)
        {
            if (obj is UniversityStudent)
            {
                Console.WriteLine("University : " + NameOfUniversity);
                Console.WriteLine("Name       : " + NameOfStudent);
                Console.WriteLine("Roll No    : " + RollNum);
                Console.WriteLine("Grade      : " + GradeOfStudents);
            }
            else
            {
                Console.WriteLine("Object is not a Student instance.");
            }
        }
    }


    internal class UniversityStudentManager
    {
        static void Student()
        {
            UniversityStudent student1 = new UniversityStudent("Aditey Rai", 101, 'A');
            UniversityStudent student2 = new UniversityStudent("Nirma Kapoor", 102, 'B');

            student1.StudentDetailsDisplay(student1);
            Console.WriteLine();

            student2.StudentDetailsDisplay(student2);
            Console.WriteLine();

            // Update grade using 'is' operator validation
            student2.GradeUpdater(student2, 'A');
            student2.StudentDetailsDisplay(student2);

            Console.WriteLine();
            UniversityStudent.TotalStudentsDisplay();
        }
    }
}
