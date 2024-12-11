using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPractice
{
    internal class Desktop : Computer
    {
        private bool isUSBavailable;
        private bool isWLanavailabe;

        internal bool IsUSBavailable
        {
            get { return this.isUSBavailable; }
            set { this.isUSBavailable = value; }
        }
        internal bool IsWLANavailable
        {
            get { return this.isUSBavailable; }
            set { this.isUSBavailable = value; }
        }

        internal Desktop(double cpuClockSpeed, byte ramSize, bool doesHaveSSD, string displayType, byte gpuCapacity, int powerSupplyCapacity, bool isUSBavailable, bool isWLANavailable) : base( cpuClockSpeed, ramSize, doesHaveSSD, displayType, gpuCapacity, powerSupplyCapacity)
        {
            this.IsUSBavailable = isUSBavailable;
            this.IsWLANavailable = isWLANavailable;
        }
        internal override void PrintInfo()
        {
            Console.WriteLine("\nDekstop Information-");
            base.PrintInfo();
            Console.WriteLine("USB: {0}", this.IsUSBavailable);
            Console.WriteLine("WAL: {0}\n", this.IsWLANavailable);

        }
    }
}
