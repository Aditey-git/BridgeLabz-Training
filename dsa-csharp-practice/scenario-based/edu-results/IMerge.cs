using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.DSA_FOLDER.scenariobased.EduResults_Rank_Sheet_Generator
{
    internal interface IMerge
    {
        void MergeSort(Student[] arr);
        void Merge(Student[] arr, Student[] left, Student[] right);
    }
}
