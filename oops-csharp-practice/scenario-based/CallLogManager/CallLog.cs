using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.Scenario_bases.CallLogManager
{
    internal class CallLog
    {
        private string phoneNumber;
        private string msg;
        private DateTime timestamp;

        public CallLog(string phoneNumber, string message, DateTime timestamp)
        {
            this.phoneNumber = phoneNumber;
            this.msg = message;
            this.timestamp = timestamp;
        }
        public string PhoneNumberGetter()
        {
            return phoneNumber;
        }
        public string MessageGetter()
        {
            return msg;
        }
        public DateTime TimestampGetter()
        {
            return timestamp;
        }

    }
}
