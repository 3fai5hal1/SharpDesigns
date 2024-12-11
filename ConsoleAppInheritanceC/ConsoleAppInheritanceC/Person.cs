using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritanceC
{
    internal struct AddressFormat
    {
        private byte houseNo;
        private byte roadNo;
        private ushort postalCode;
        private string district;

        internal AddressFormat(byte houseNo, byte roadNo, ushort postalCode, string district)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.postalCode = postalCode;
            this.district = district;
        }

        internal void PrintAddress()
        {
            Console.WriteLine("Address Information:");
            Console.WriteLine("House No: {0}", this.houseNo);
            Console.WriteLine("Road No: {0}", this.roadNo);
            Console.WriteLine("Postal Code: {0}", this.postalCode);
            Console.WriteLine("District: {0}\n", this.district);
        }
    }

    internal class Person
    {
        private int id;
        private string name;
        private string bloodGroup;
        private AddressFormat address;

        internal int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        internal string BloodGroup
        {
            get { return this.bloodGroup; }
            set { this.bloodGroup = value; }
        }

        internal AddressFormat Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        internal Person(int id, string name, string bloodGroup, AddressFormat address)
        {
            this.Id = id;
            this.Name = name;
            this.BloodGroup = bloodGroup;
            this.Address = address;
        }

        internal virtual void PrintInfo()
        {
            Console.WriteLine("Id: {0}", this.Id);
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Blood Group: {0}", this.BloodGroup);
            this.Address.PrintAddress();
        }
    }
}
