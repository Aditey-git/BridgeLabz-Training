using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.DSA_FOLDER.scenariobased.EduResults_Rank_Sheet_Generator
{
    internal class RankSheet
    {
        private DistrictResult[] DistrictResults;

        public RankSheet(DistrictResult[] districtResults)
        {
            DistrictResults = districtResults;
        }
        public Student[] GenerateRankSheet()
        {
            int totalStudents = 0;
            for(int i = 0; i < DistrictResults.Length; i++)
            {
                totalStudents += DistrictResults[i].Size();
            }
            Student[] allStudents = new Student[totalStudents];

            int index = 0;
            for(int i = 0; i <  DistrictResults.Length; i++)
            {
                Student[] temp = DistrictResults[i].Students1;
                for(int j = 0; j < DistrictResults.Length; j++)
                {
                    allStudents[index++] = temp[j];
                }
            }
            IMerge merge = new MergeSortUtility();
            merge.MergeSort(allStudents);
            return allStudents;
        }
    }
}
