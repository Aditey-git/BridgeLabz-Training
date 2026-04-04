using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction
{
    internal class DoctorClass
    {
        private string doctorId;
        private string doctorName;
        private string doctorSpecialization;
        private string department;

        public DoctorClass(
            string doctorId,
            string doctorName,
            string doctorSpecialization,
            string department
        )
        {
            this.doctorId = doctorId;
            this.doctorName = doctorName;
            this.doctorSpecialization = doctorSpecialization;
            this.department = department;
        }

        public void InfoDisplay()
        {
            Console.WriteLine("====== Doctor Info ======");
            Console.WriteLine($"Doctor ID --> {doctorId}");
            Console.WriteLine($"Doctor Name --> {doctorName}");
            Console.WriteLine($"Doctor Specialization --> {doctorSpecialization}");
            Console.WriteLine($"Department --> {department}");
            Console.WriteLine();
        }

    }
}
