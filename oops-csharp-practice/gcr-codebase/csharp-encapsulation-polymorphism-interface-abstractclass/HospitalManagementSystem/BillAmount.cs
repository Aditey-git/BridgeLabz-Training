using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.encapsulation_polymorphism_abstraction
{
    internal class BillAmount : PayableAmount
    {
        public void CalculateBill(PatientClass patient)
        {
            if (patient is PatientIn inPatient)
            {
                Console.Write("Enter number of days admitted: ");
                int days = int.Parse(Console.ReadLine());
                Console.WriteLine();

                double total = inPatient.RoomChargePerDay * days;
                Console.WriteLine($"Total In-Patient Bill --> {total}");
            }
            else if (patient is PatientOut outPatient)
            {
                double total = outPatient.ConsultationFee;
                Console.WriteLine($"Total Out-Patient Bill --> {total}");
            }
            else
            {
                Console.WriteLine("Invalid patient type.");
            }
        }

    }
}
