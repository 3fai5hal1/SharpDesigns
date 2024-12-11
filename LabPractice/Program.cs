using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer[] c1 = new Computer[5];
            c1[0] = new Computer(2, 4, true, "LED", 2, 500);
            c1[1] = new Desktop(0.5, 2, false, "LED", 0, 250, true, true);
            c1[2] = new Desktop(4.0, 32, true, "OLED", 16, 1800, true, true);
            c1[3] = new Laptop(2.50, 8, true, "LED", 6, 1000, 3500, "With Pin", "USB_B");
            c1[4] = new Laptop(3.50, 32, true, "LCD", 16, 1800, 4500, "Type-C", "USB_C");

            Console.WriteLine("Computer Information-");
            foreach (Computer c in c1)
            {
                c.PrintInfo();
            }
        }
    }
}
