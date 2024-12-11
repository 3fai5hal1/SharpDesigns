using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPractice
{
    internal class Computer
    {
        private double cpuClockSpeed;
        private byte ramSize;
        private bool doesHaveSSD;
        private string displayType;
        private byte gpuCapacity;
        private int powerSupplyCapacity;

        internal double CpuClockSpeed
        {
            get { return this.cpuClockSpeed; }
            set { this.cpuClockSpeed = value; }
        }
        internal byte RamSize
        {
            get { return this.ramSize; }
            set { this.ramSize = value; }
        }
        
        internal bool DoesHaveSSD
        {
            get { return this.doesHaveSSD; }
            set { this.doesHaveSSD = value; }
        }
        internal string DisplayType
        {
            get { return this.displayType; }
            set { this.displayType = value; }
        }
        
        internal byte GpuCapacity
        {
            get { return this.gpuCapacity; }
            set { this.gpuCapacity = value; }
        }
        
        internal int PowerSupplyCapacity
        {
            get { return this.powerSupplyCapacity; }
            set { this.powerSupplyCapacity = value; }
        }

        internal Computer(double cpuClockSpeed, byte ramSize, bool doesHaveSSD, string displayType, byte gpuCapacity, int powerSupplyCapacity)
        {
            this.CpuClockSpeed = cpuClockSpeed;
            this.RamSize = ramSize;
            this.DoesHaveSSD = doesHaveSSD;
            this.DisplayType = displayType;
            this.GpuCapacity = gpuCapacity;
            this.PowerSupplyCapacity = powerSupplyCapacity;
        }

        internal string Category()
        {
            if (this.RamSize > 16 && this.CpuClockSpeed > 3 && this.DoesHaveSSD == true)
                return "Good Category";
            else if (this.RamSize > 4 && this.RamSize <16 && this.CpuClockSpeed > 2 && this.CpuClockSpeed < 3 && this.DoesHaveSSD == true)
                return "Average Category";
            else if (this.RamSize < 4 && this.CpuClockSpeed < 1 && this.DoesHaveSSD == false)
                return "Lower Category";
            else
                return "Invalid Category";    
            
        }

        internal virtual void PrintInfo()
        {
            Console.WriteLine("{0}", this.Category());
            Console.WriteLine("Cpu Clock Spped: {0}GHz", this.CpuClockSpeed);
            Console.WriteLine("Ram Size: {0}GB", this.RamSize);
            Console.WriteLine("SSD : {0}", this.DoesHaveSSD);
            Console.WriteLine("Display Type: {0}", this.DisplayType);
            Console.WriteLine("Gpu Capacity: {0}GB", this.GpuCapacity);
            Console.WriteLine("Power Supply Capacity: {0}watts", this.PowerSupplyCapacity);
        }
    }
}
