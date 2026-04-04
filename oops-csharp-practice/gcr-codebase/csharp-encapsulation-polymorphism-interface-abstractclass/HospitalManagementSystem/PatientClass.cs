using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction
{
    internal class PatientClass
    {
        private readonly string idOfPatient;
        private string nameOfPatient;

        public PatientClass(string idOfPatient, string nameOfPatient)
        {
            this.idOfPatient = idOfPatient;
            this.nameOfPatient = nameOfPatient;
        }

        public virtual void InfoDisplay()
        {
            Console.WriteLine($"Patient name --> {nameOfPatient}");
            Console.WriteLine($"Patient id --> {idOfPatient}");
        }

    }
}
