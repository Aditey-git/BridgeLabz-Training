using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.Inheritance
{
    internal class Device
    {
        public string Id;
        public string DeviceStatus;

        public Device(string Id, string DeviceStatus)
        {
            this.Id = Id;
            this.DeviceStatus = DeviceStatus;
        }

        // Virtual method
        public virtual void DisplayStatus(){
            Console.WriteLine("Device Status:");
            Console.WriteLine($"Device ID: {Id}");
            Console.WriteLine($"Status: {DeviceStatus}");
        }
    }

    // Subclass
    class ThermostatSubclass : Device
    {
        public int TempSetting;

        public ThermostatSubclass(string Id, string DeviceStatus, int tempSetting)
            : base(Id, DeviceStatus)
        {
            TempSetting = tempSetting;
        }

        // Overridden method
        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine($"Temperature Setting : {TempSetting}°C");
        }
    }

    //Class for object creation
    class DeviceClass
    {
        static void DeviceManagement()
        {
            Device device = new ThermostatSubclass("101", "ON", 24);

            device.DisplayStatus();
        }
    }
}
