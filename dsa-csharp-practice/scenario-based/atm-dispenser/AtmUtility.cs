using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.Scenario_based.atm_dispenser
{
    internal class AtmUtility
    {
        public void ScenarioA()
        {
            int[] notesArr = { 1, 2, 5, 10, 20, 50, 100, 200, 500 };
            int[] notesCount = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Console.Write("Enter the amount to debit from your account --> ");
            int debitAmount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int index = notesArr.Length - 1;
            while (debitAmount > 0)
            {
                if (debitAmount >= notesArr[index])
                {
                    debitAmount -= notesArr[index];
                    notesCount[index]++;
                }
                else
                {
                    index--;
                }
            }
            for (int i = 0; i < notesArr.Length; i++)
            {
                if (notesCount[i] > 0)
                {
                    Console.WriteLine($"{notesArr[i]} --> {notesCount[i]}");
                }
            }
        }

        public void ScenarioB()
        {
            
            int[] notesArr = { 1, 2, 5, 10, 20, 50, 100, 200 };
            int[] notesCountArr = { 0, 0, 0, 0, 0, 0, 0, 0 };
            Console.Write("Enter the amount to debit from your account --> ");
            int debitAmount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int index = notesArr.Length - 1;
            while (debitAmount > 0)
            {
                if (debitAmount >= notesArr[index])
                {
                    debitAmount -= notesArr[index];
                    notesCountArr[index]++;
                }
                else
                {
                    index--;
                }
            }
            for (int i = 0; i < notesArr.Length; i++)
            {
                if (notesCountArr[i] > 0)
                {
                    Console.WriteLine($"{notesArr[i]} --> {notesCountArr[i]}");
                }
            }
        }

        public void ScenarioC()
        {
            int[] notesArr = { 1, 2, 5, 10, 20, 50, 100, 200, 500 };
            int[] notesCountArr = { 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int[] notesDispensedArr = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Console.Write("Enter the amount to debit from your account --> ");
            int debitAmount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int index = notesArr.Length - 1;
            while (debitAmount > 0 && index >= 0)
            {
                if (debitAmount >= notesArr[index])
                {
                    if (notesCountArr[index] > 0)
                    {
                        debitAmount -= notesArr[index];
                        notesCountArr[index]--;
                        notesDispensedArr[index]++;
                    }
                    if (notesCountArr[index] == 0)
                    {
                        index--;
                    }
                }
                else
                {
                    index--;
                }
            }
            if (debitAmount > 0)
            {
                Console.WriteLine("Failed to give the desired amount due to shortage of notes.");
            }
            else
            {
                for (int i = 0; i < notesArr.Length; i++)
                {
                    if (notesCountArr[i] == 0)
                    {
                        Console.WriteLine($"{notesArr[i]} --> {notesDispensedArr[i]}");
                    }
                }
            }
        }
    }
}

