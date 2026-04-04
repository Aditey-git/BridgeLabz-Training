using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction
{
    internal class PatientIn :  PatientClass

    {
        private string roomNumber;
        private DoctorClass doctorAssigned;
        private double roomChargePerDay;

        public double RoomChargePerDay
        {
            get { return roomChargePerDay; }
        }

        public PatientIn(
            string patientId,
            string patientName,
            string roomNumber,
            DoctorClass doctorAssigned,
            double roomChargePerDay
        ) : base(patientId, patientName)
        {
            this.roomNumber = roomNumber;
            this.doctorAssigned = doctorAssigned;
            this.roomChargePerDay = roomChargePerDay;
        }

        public override void InfoDisplay()
        {
            Console.WriteLine("====== InPatient Info ======");
            base.InfoDisplay();
            Console.WriteLine($"Room Number --> {roomNumber}");
            Console.WriteLine($"Room Charge Per Day --> {roomChargePerDay}");
            Console.WriteLine("============================");
            Console.WriteLine();

            doctorAssigned.InfoDisplay();
        }

    }
}
