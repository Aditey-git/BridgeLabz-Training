using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction
{
    internal class PatientOut : PatientClass
    {
        private DateTime arrivalDay;
        private string appointmentNumber;
        private double consultationFee;

        public double ConsultationFee
        {
            get { return consultationFee; }
        }

        public PatientOut(
            string patientId,
            string patientName,
            string appointmentNumber,
            double consultationFee
        ) : base(patientId, patientName)
        {
            arrivalDay = DateTime.Now;
            this.appointmentNumber = appointmentNumber;
            this.consultationFee = consultationFee;
        }

        public override void InfoDisplay()
        {
            Console.WriteLine("====== OutPatient Info ======");
            base.InfoDisplay();
            Console.WriteLine($"Arrival Date --> {arrivalDay}");
            Console.WriteLine($"Appointment Number --> {appointmentNumber}");
            Console.WriteLine($"Consultation Fees --> {consultationFee}");
            Console.WriteLine("============================");
            Console.WriteLine();
        }

    }
}
