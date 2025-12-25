using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.level3
{
    internal class Bonus
    {
        public static void BonusFind() {
            int employees = 10;

            //Method calling
            double[,] employeeDataArr = EmployeeDataGenerate(employees);
            double[,] newSalaryDataArr = BonusCalculate(employeeDataArr);
            summaryDisplay(employeeDataArr, newSalaryDataArr);
        }



        //Method to generate salary and years of service
        public static double[,] EmployeeDataGenerate(int employee){
            double[,] dataArr = new double[employee, 2];
            Random random = new Random();

            for(int i = 0; i < employee; i++){
                dataArr[i, 0] = random.Next(10000, 100000);
                dataArr[i, 1] = random.Next(1, 11);
            }

            return dataArr;
        }

        //Method to calculate new salary and bonus
        public static double[,] BonusCalculate(double[,] employeeDataArr){
            int employees = employeeDataArr.GetLength(0);
            double[,] dataNew = new double[employees, 2];

            for (int i = 0; i < employees; i++){
                double salaryOfEmployee = employeeDataArr[i, 0];
                double yearsOfService = employeeDataArr[i, 1];
                double bonusAmount;

                if (yearsOfService > 5) bonusAmount = salaryOfEmployee * 0.05; // 5% bonus
                else bonusAmount = salaryOfEmployee * 0.02; // 2% bonus

                dataNew[i, 0] = salaryOfEmployee + bonusAmount; // new salary
                dataNew[i, 1] = bonusAmount;          // bonus
            }

            return dataNew;
        }

        //Method to calculate totals and display tabular output
        public static void summaryDisplay(double[,] oldData, double[,] newData){
            double oldSalaryTotal = 0;
            double newSalaryTotal = 0;
            double bonusTotal = 0;


            for (int i = 0; i < oldData.GetLength(0); i++){
                double SalaryOld = oldData[i, 0];
                double yearsOfService = oldData[i, 1];
                double bonusAmount = newData[i, 1];
                double salaryNew = newData[i, 0];

                oldSalaryTotal += SalaryOld;
                newSalaryTotal += salaryNew;
                bonusTotal += bonusAmount;

                Console.WriteLine($"{i + 1}\t\t{SalaryOld}\t\t{yearsOfService}\t{bonusAmount}\t\t{salaryNew}");
            }

            Console.WriteLine($"Total Old Salary  : {oldSalaryTotal}");
            Console.WriteLine($"Total Bonus Paid : {bonusTotal}");
            Console.WriteLine($"Total New Salary  : {newSalaryTotal}");
        }

    }
}
