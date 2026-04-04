using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.DSA_FOLDER.scenariobased.EduResults_Rank_Sheet_Generator
{
    internal class DistrictResult
    {
        private string DistrictName;
        private Student[] Students;


        public DistrictResult(string districtName, Student[] students)
        {
            DistrictName = districtName;
            Students = students;
        }

        internal Student[] Students1 { get => Students; }

        public int Size()
        {
            return Students.Length;
        }   
    }
}
