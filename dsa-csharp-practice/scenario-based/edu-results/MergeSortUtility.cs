using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.DSA_FOLDER.scenariobased.EduResults_Rank_Sheet_Generator
{
    internal class MergeSortUtility : IMerge
    {
        public void MergeSort(Student[] arr)
        {
            if(arr.Length <= 1)
            {
                return;
            }

            int mid = arr.Length / 2;

            Student[] left = new Student[mid];
            Student[] right = new Student[arr.Length - mid];

            for(int i = 0; i < left.Length; i++)
            {
                left[i] = arr[i];
            }
            for(int i = mid; i < arr.Length; i++)
            {
                right[i - mid] = arr[i];
            }
            MergeSort(left);
            MergeSort(right);

            Merge(arr, left, right);
        }

        public void Merge(Student[] arr, Student[] left, Student[] right)
        {
            int i = 0, j = 0, k = 0;
            while(i < left.Length && j < right.Length)
            {
                if (left[i].StudentScore1 > right[j].StudentScore1)
                {
                    arr[k++] = left[i++];
                }
                else
                {
                    arr[k++] = right[j++];
                }
            }
            while(i < left.Length)
            {
                arr[k++] = left[i++];
            }
            while(j < right.Length)
            {
                arr[k++] = right[j++];
            }
        }
    }
}
