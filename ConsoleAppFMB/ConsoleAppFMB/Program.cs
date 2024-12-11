using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFMB
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[5] { 5, 3, 7, 9, 1 };
            int[] a2 = new int[3] { 10, 20, 30 };

            //Calculator c = new Calculator();
            //c.Addition(23, 6);
            //c.Addition("hello", 8);
            //c.Addition("r", 7, "q");
            //c.Addition();
            //c.Addition(2, 5, 8);
            //c.Addition(a1);
            //c.Addition(a2);

            Sample s = new Sample();
            //s.Summation(5, 3, 7, 9, 2);
            //s.Summation(45, 7, 9, -10);
            //s.Summation(1, 3, 6, 9, 5, 2, 6, 8, 7);
            //s.Summation(4, 90, 1);
            //s.Summation();
            //s.Summation(a1);
            int p = 10, q = 20, r;
            s.Swap(ref p, ref q);
            Console.WriteLine("After: p{0},q{1}", p, q);
            s.M1(out r);
            s.M3(8);
            s.M4(r:3, p:4, q:5);

            Constant ct = new Constant();
            int u = Constant.b;
            u = ct.c;
            Console.WriteLine("{0}", Days.Monday);
            u = (int)Days.Monday;
            Console.WriteLine($"{u}");
        }
    }


}
