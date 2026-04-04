using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Arrays.level2
{
    internal class BonusOfEmployees
    {
        public static void Bonus() {
            Console.WriteLine();

            double[] salaryArr = new double[10];
            double[] serviceYearsArr = new double[10];
            double bonusTotal = 0.0;
            double salaryTotal = 0.0;
            double salaryTotalNew = 0.0;

            //Getting Input from the user
            for(int i = 0;i < 10;i++){
                Console.WriteLine($"Enter details for this Employee:");

                Console.Write("Enter salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter years of service: ");
                double year = Convert.ToDouble(Console.ReadLine());

                if(salary <= 0 || year < 0){
                    Console.WriteLine("Input Invalid");
                    i--;
                    continue;
                }

                salaryArr[i] = salary;
                serviceYearsArr[i] = year;
            }

            // Calculate bonus and new salary
            double[] bonusArr = new double[10];
            double[] newSalaryArr = new double[10];
            for(int i = 0; i < 10; i++){
                if(serviceYearsArr[i] > 5){
                    bonusArr[i] = salaryArr[i] * 0.05;
                }
                else{
                    bonusArr[i] = salaryArr[i] * 0.02;
                }

                newSalaryArr[i] = salaryArr[i] + bonusArr[i];

                bonusTotal += bonusArr[i];
                salaryTotal += salaryArr[i];
                salaryTotalNew += newSalaryArr[i];
            }


            // Displaying results
            Console.WriteLine("Total Old Salary: " + salaryTotal);
            Console.WriteLine("Total Bonus Amount: " + bonusTotal);
            Console.WriteLine("Total New Salary: " + salaryTotalNew);
        }
    }
}
