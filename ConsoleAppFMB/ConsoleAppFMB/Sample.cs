using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFMB
{
    class Sample
    {
        public void Summation(params int[] info)
        {
            int sum = 0;
            int count = 0;
            while (count < info.Length)
            {
                sum += info[count];
                count++;
            }
            Console.WriteLine("{0}", sum);
        }

        public void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        public void M1(out int k)
        {
            k = 6;
        }

        public void M2(int a, string b, Calculator c, double[] e, ref sbyte t, out bool k, params long[] g)
        {
            k = false;
        }

        public void M3(int a, int b = 2, int c = 3)
        {

        }

        public void M4(int p , int q, int r)
        {

        }
    }
}
