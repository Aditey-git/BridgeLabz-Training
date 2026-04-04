using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.level2
{
    internal class CanVote
    {
        public static void CanVoteOrNot() {
            int[] agesArr = new int[10];

            //Getting input from the user
            Console.WriteLine("Enter age of 10 students:");
            for (int i = 0; i < 10; i++){
                agesArr[i] = Convert.ToInt32(Console.ReadLine());
                bool Vote = CanStudentVote(agesArr[i]);
                if(Vote){
                    Console.WriteLine("Can vote");
                }
                else{
                    Console.WriteLine("Cannot vote");
                }
            }
        }



        //Method for checking can vote or not
        public static bool CanStudentVote(int ageToCheck)
        {
            if (ageToCheck < 0){
                return false;
            }          
            if (ageToCheck >= 18){
                return true;
            }
            return false;
        }
    }
}
