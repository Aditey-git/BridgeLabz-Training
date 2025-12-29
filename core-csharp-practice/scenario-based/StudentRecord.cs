using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Scenario_Based
{
    internal class StudentRecord
    {
        //Method to call every other function
        public void StudentMarksRecord()
        {
            //Inatalize the Student array here
            Console.WriteLine("Number of Student in the Class ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());
            double[] studentArray = new double[numberOfStudents];

            Console.WriteLine("Marks Of Each Students");

            for (int i = 0; i < numberOfStudents; i++){
                studentArray[i] = Convert.ToDouble(Console.ReadLine());
            }

            double highMarks = HighestMarksFinder(studentArray);
            Console.WriteLine("Highest Marks is: " + highMarks);
            double lowestMarks = SmallestMarksFinder(studentArray);
            Console.WriteLine("Lowest  Marks is: " + lowestMarks);
            double average = Average(studentArray);
            Console.WriteLine("Average Marks is: " + average);
            Console.WriteLine("The Marks Above the Average Marks are");
            DisplayStudent(studentArray);
        }


        // Calculating highest marks of the class
        public double HighestMarksFinder(double[] studentArray)
        {
            double highestMarks = 0;
            for (int i = 0; i < studentArray.Length; i++){
                if (studentArray[i] > highestMarks){
                    highestMarks = studentArray[i];
                }
            }
            return highestMarks;
        }


        // Calculating Lowest Marks in The Class
        public double SmallestMarksFinder(double[] studentArray){
            double smallestMarks = studentArray[0];
            for (int i = 0; i < studentArray.Length; i++){
                if (studentArray[i] < smallestMarks){
                    smallestMarks = studentArray[i];
                }
            }
            return smallestMarks;
        }


        //Calculating the average Marks of the Student
        public double Average(double[] studentArray){
            double addition = 0;
            for (int i = 0; i < studentArray.Length; i++){
                addition += studentArray[i];
            }
            double avgMarks = addition / (studentArray.Length);
            return avgMarks;
        }



        //Method to display the Student above
        public void DisplayStudent(double[] studentArray)
        {
            double avg = Average(studentArray);
            for (int i = 0; i < studentArray.Length; i++){
                if (studentArray[i] > avg){
                    Console.WriteLine(studentArray[i]);
                }
            }
        }
    }
}
