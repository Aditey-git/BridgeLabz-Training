using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.Inheritance
{
    internal class Person
    {
        public string NameOfPerson;
        public int AgeOfPerson;

        public Person(string NameOfPerson, int ageOfPerson)
        {
            this.NameOfPerson = NameOfPerson;
            AgeOfPerson = ageOfPerson;
        }
    }


    // Subclass: Teacher
    class TeacherSubclass : Person
    {
        public string SubjectTaught;

        public TeacherSubclass(string nameOfTeacher, int ageOfTeacher, string subjectTeaches)
            : base(nameOfTeacher, ageOfTeacher)
        {
            SubjectTaught = subjectTeaches;
        }

        public void RoleDisplay()
        {
            Console.WriteLine($"Teacher: {NameOfPerson}, Age: {AgeOfPerson}, Subject: {SubjectTaught}");
        }
    }

    // Subclass: Student
    class StudentSubclass : Person
    {
        public string GradeOfStudent;

        public StudentSubclass(string nameOfStudent, int ageOfStudent, string gradeOfStudent)
            : base(nameOfStudent, ageOfStudent)
        {
            GradeOfStudent = gradeOfStudent;
        }

        public void RoleDisplay()
        {
            Console.WriteLine($"Student: {NameOfPerson}, Age: {AgeOfPerson}, Grade: {GradeOfStudent}");
        }
    }

    // Subclass: Staff
    class StaffSubclass : Person
    {
        public string StaffDepartment;

        public StaffSubclass(string nameOfMember, int staffAge, string staffDepartment)
            : base(nameOfMember, staffAge)
        {
            StaffDepartment = staffDepartment;
        }

        public void RoleDisplay()
        {
            Console.WriteLine($"Staff: {NameOfPerson}, Age: {AgeOfPerson}, Department: {StaffDepartment}");
        }
    }

    class School
    {
        static void SchoolManagement(string[] args)
        {
            TeacherSubclass teacher = new TeacherSubclass("Vijay", 40, "Chemistry");
            StudentSubclass student = new StudentSubclass("Aditey", 16, "11th Grade");
            StaffSubclass staff = new StaffSubclass("Rakesh", 35, "Administration");

            teacher.RoleDisplay();
            student.RoleDisplay();
            staff.RoleDisplay();
        }
    }
}
