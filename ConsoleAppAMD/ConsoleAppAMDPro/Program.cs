using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppAMDPro.Sub;

namespace ConsoleAppAMDPro
{
    class Program
    {
        int a;
        static int b;

        static void Main(string[] args)
        {
            //Student s = new Student();
            School ss = new School();
            ConsoleAppAMDPro.Sub.College cs = new Sub.College();
            College c1 = new College();
            //System.Console.WriteLine();
            //System.Console.WriteLine();
            Program.M1();
            M1();
            Program p = new Program();
            p.M2();
        }

        internal static void M1()
        {
            //a = 9;
            b = 8;
        }

        internal void M2()
        {
            this.a = 9;
            b = 89;
        }
    }
}
