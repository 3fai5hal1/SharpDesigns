using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritanceC
{
    internal class Student : Person
    {
        private double cgpa;

        internal double Cgpa
        {
            get { return this.cgpa; }
            set 
            {
                if (value >= 0.0 && value <= 4.0)
                    this.cgpa = value;
                else
                    this.cgpa = -1;
            }
        }

        internal Student(int id, string name, string bloodGroup, AddressFormat address, double cgpa) : base(id, name, bloodGroup, address)
        {
            this.Cgpa = cgpa;
        }

        internal override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"CGPA: {this.Cgpa}");
        }
    }
}
