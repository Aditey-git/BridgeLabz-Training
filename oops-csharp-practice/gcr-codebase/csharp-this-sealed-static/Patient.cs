using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.ThisSealedStatic
{
    internal class Patient
    {
        // static variable shared among all patients
        public static string NameOfHospital = "KD Mathura";
        private static int TotalNumberOfPatients = 0;

        // readonly variable for unique patient identification
        public readonly int PatientID;

        // instance variables
        public string NameOfPatient;
        public int AgeOfPatient;
        public string AilmentOfPatient;

        // constructor using 'this' keyword
        public Patient(string NameOfPatient, int AgeOfPatient, string AilmentOfPatient, int PatientID)
        {
            this.NameOfPatient = NameOfPatient;
            this.AgeOfPatient = AgeOfPatient;
            this.AilmentOfPatient = AilmentOfPatient;
            this.PatientID = PatientID;
            TotalNumberOfPatients++;
        }

        // static method to get total patients
        public static void TotalPatientsGetter()
        {
            Console.WriteLine("Total Patients Admitted: " + TotalNumberOfPatients);
        }

        // instance method using 'is' operator
        public void PatientDetailsDisplay(object obj)
        {
            if (obj is Patient)
            {
                Console.WriteLine("Hospital Name: " + NameOfHospital);
                Console.WriteLine("Patient Name: " + NameOfPatient);
                Console.WriteLine("Patient ID: " + PatientID);
                Console.WriteLine("Age: " + AgeOfPatient);
                Console.WriteLine("Ailment: " + AilmentOfPatient);
            }
            else
            {
                Console.WriteLine("Object is not a Patient instance.");
            }
        }
    }


    internal class HospitalManagement
    {
        static void PatientManage(string[] args)
        {
            Patient patient1 = new Patient("Aditey Rai", 35, "Fever", 1001);
            Patient patient2 = new Patient("Sambhav Tiwari", 28, "Headache", 1002);

            patient1.PatientDetailsDisplay(patient1);
            Console.WriteLine();

            patient2.PatientDetailsDisplay(patient2);
            Console.WriteLine();

            Patient.TotalPatientsGetter();
        }
    }
}
