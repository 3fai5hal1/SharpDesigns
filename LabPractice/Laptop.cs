using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPractice
{
    internal class Laptop : Computer
    {
        private int batteryCapacity;
        private string chargerPinType;
        private string usbType;

        internal int BatteryCapacity
        {
            get { return this.batteryCapacity; }
            set { this.batteryCapacity = value; }
        }

        internal string ChargerPinType
        {
            get { return this.chargerPinType; }
            set { this.chargerPinType = value; }
        }

        internal string USBType
        {
            get { return this.usbType; }
            set { this.usbType = value; }
        }

        internal Laptop(double cpuClockSpeed, byte ramSize, bool doesHaveSSD, string displayType, byte gpuCapacity, int powerSupplyCapacity, int batteryCapacity, string chargePinType, string usbType) : base(cpuClockSpeed, ramSize, doesHaveSSD, displayType, gpuCapacity, powerSupplyCapacity)
        {
            this.BatteryCapacity = batteryCapacity;
            this.ChargerPinType = chargePinType;
            this.USBType = usbType;
        }

        internal override void PrintInfo()
        {
            Console.WriteLine("Laptop Information-");
            base.PrintInfo();
            Console.WriteLine("Battery Capacity: {0} mAh", this.BatteryCapacity);
            Console.WriteLine("Charger pin type: {0}", this.ChargerPinType);
            Console.WriteLine("USB Type: {0}\n", this.USBType);

        }
    }
}

