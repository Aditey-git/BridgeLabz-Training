using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.Scenario_bases.CallLogManager
{
    internal class CallLogManager
    {
        private CallLog[] logsRecord;
        private int countLog;

        public CallLogManager(int sizeOfNum)
        {
            logsRecord = new CallLog[sizeOfNum];
            countLog = 0;
        }

        public void CallLogAdder()
        {
            if (countLog >= logsRecord.Length)
            {
                Console.WriteLine("CallLogs is full.");
                return;
            }
            Console.Write("Enter phone number --> ");
            string phoneNum = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(phoneNum) || phoneNum.Length != 10 || !long.TryParse(phoneNum, out _))
            {
                Console.WriteLine("Invalid phone number.");
                return;
            }

            Console.Write("Enter message --> ");
            string messageInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(messageInput))
            {
                Console.WriteLine("Invalid message.");
                return;
            }

            DateTime now = DateTime.Now;

            CallLog log = new CallLog(phoneNum, messageInput, now);

            logsRecord[countLog++] = log;
        }

        public void Search(string kWord)
        {
            if (string.IsNullOrWhiteSpace(kWord))
            {
                Console.WriteLine("Invalid keyword.");
                return;
            }
            for (int i = 0; i < countLog; i++)
            {
                if (logsRecord[i].MessageGetter().Contains(kWord, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Phone Number --> {logsRecord[i].PhoneNumberGetter()}");
                    Console.WriteLine($"Message --> {logsRecord[i].MessageGetter()}");
                    Console.WriteLine($"Timestamp --> {logsRecord[i].TimestampGetter()}");
                }
            }
        }

        public void FilterUsingTime(DateTime start, DateTime end)
        {
            for (int i = 0; i < countLog; i++)
            {
                if (start > end)
                {
                    Console.WriteLine("Invalid time range. Start time must be before end time.");
                    return;
                }

                if (logsRecord[i].TimestampGetter() >= start && logsRecord[i].TimestampGetter() <= end)
                {
                    Console.WriteLine($"Phone Number --> {logsRecord[i].PhoneNumberGetter()}");
                    Console.WriteLine($"Message --> {logsRecord[i].MessageGetter()}");
                    Console.WriteLine($"Timestamp --> {logsRecord[i].TimestampGetter()}");
                }
            }
        }

        public void LogsDisplay(CallLog log)
        {
            Console.WriteLine($"Phone Number --> {log.PhoneNumberGetter()}");
            Console.WriteLine($"Message --> {log.MessageGetter()}");
            Console.WriteLine($"Timestamp --> {log.TimestampGetter()}");
        }



    }
}
