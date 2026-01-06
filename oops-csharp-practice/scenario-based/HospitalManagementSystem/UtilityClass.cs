using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.Scenario_bases
{
    internal class UtilityClass
    {
        private DoctorClass[] doctorsArr = new DoctorClass[15];
        private PatientClass[] patientsArr = new PatientClass[15];

        private int numOfDoctor = 0;
        private int numOfPatient = 0;

        public void AddADoctor()
        {
            if (numOfDoctor >= doctorsArr.Length)
            {
                Console.WriteLine("Doctor limit reached.");
                return;
            }

            Console.Write("Enter Doctor ID: ");
            string id = Console.ReadLine();

            Console.Write("Enter Doctor Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Specialization: ");
            string specialization = Console.ReadLine();

            Console.Write("Enter Department: ");
            string department = Console.ReadLine();

            doctorsArr[numOfDoctor++] = new DoctorClass(id, name, specialization, department);

            Console.WriteLine("Doctor added successfully.");
            Console.WriteLine();
        }

        public void AddAPatient()
        {
            if (numOfPatient >= patientsArr.Length)
            {
                Console.WriteLine("Patient limit reached.");
                return;
            }

            Console.WriteLine("1. In-Patient");
            Console.WriteLine("2. Out-Patient");
            Console.Write("Choose patient type: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter Patient ID: ");
            string pid = Console.ReadLine();

            Console.Write("Enter Patient Name: ");
            string pname = Console.ReadLine();

            if (choice == 1)
            {
                if (numOfDoctor == 0)
                {
                    Console.WriteLine("No doctors available.");
                    Console.WriteLine();
                    return;
                }

                Console.Write("Enter Room Number: ");
                string room = Console.ReadLine();

                Console.Write("Enter Room Charge Per Day: ");
                double charge = double.Parse(Console.ReadLine());

                patientsArr[numOfPatient++] =
                    new PatientIn(pid, pname, room, doctorsArr[0], charge);

                Console.WriteLine("In-Patient added successfully.");
                Console.WriteLine();
            }
            else if (choice == 2)
            {
                Console.Write("Enter Appointment Number: ");
                string app = Console.ReadLine();

                Console.Write("Enter Consultation Fee: ");
                double fee = double.Parse(Console.ReadLine());

                patientsArr[numOfPatient++] =
                    new PatientOut(pid, pname, app, fee);

                Console.WriteLine("Out-Patient added successfully.");
                Console.WriteLine();
            }
        }

        public void DisplayPatients()
        {
            if (numOfPatient == 0)
            {
                Console.WriteLine("No patients found.");
                Console.WriteLine();
                return;
            }

            for (int i = 0; i < numOfPatient; i++)
            {
                patientsArr[i].InfoDisplay();
            }
        }

        public void GenerateBill()
        {
            if (numOfPatient == 0)
            {
                Console.WriteLine("No patients available.");
                Console.WriteLine();
                return;
            }

            Console.WriteLine("Select Patient:");
            for (int i = 0; i < numOfPatient; i++)
            {
                Console.WriteLine($"{i + 1}. Patient");
            }

            int index = int.Parse(Console.ReadLine()) - 1;
            BillAmount bill = new BillAmount();
            bill.CalculateBill(patientsArr[index]);
        }



    }
}
