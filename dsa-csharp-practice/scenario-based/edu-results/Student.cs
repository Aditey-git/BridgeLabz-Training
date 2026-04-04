using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.DSA_FOLDER.scenariobased.EduResults_Rank_Sheet_Generator
{
    internal class Student
    {
        private string StudentId;
        private string StudentName;
        private string StudentDistrict;
        private int StudentScore;

        public Student(string studentId, string studentName, string studentDistrict, int studentScore)
        {
            StudentId = studentId;
            StudentName = studentName;
            StudentDistrict = studentDistrict;
            StudentScore = studentScore;
        }

        public string StudentDistrict1 { get => StudentDistrict; }
        public int StudentScore1 { get => StudentScore; }

        public override string? ToString()
        {
            return $"Name: {StudentName}\nStudent Id: {StudentId}\nDistrict: {StudentDistrict}\nScore: {StudentScore}";
        }
    }
}
