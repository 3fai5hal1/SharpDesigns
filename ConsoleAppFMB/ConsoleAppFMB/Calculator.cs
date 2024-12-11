using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFMB
{
    class Calculator
    {
        public void Addition(int x, int y)
        {
            Console.WriteLine("{0}", x + y);
        }

        public void Addition(int x, int y, int z)
        {
            Console.WriteLine("{0}", x + y + z);
        }

        public void Addition(int p, int y, int z, int w)
        {
            Console.WriteLine("{0}", p + y + z);
        }

        public void Addition(string x, int y)
        {
            Console.WriteLine("{0}", x + y);
        }

        public void Addition(int x, string y)
        {
            Console.WriteLine("{0}", x + y);
        }

        public void Addition(int x, string y, int z)
        {
            Console.WriteLine("{0}", x + y + z);
        }

        public void Addition(string x, int y, string z)
        {
            Console.WriteLine("{0}", x + y + z);
        }

        public void Addition(int x, int y, string z)
        {
            Console.WriteLine("{0}", x + y + z);
        }

        public int Addition()
        {
            Console.WriteLine("Null");
            return 20;
        }

        public void Addition(int[] info)
        {
            int sum = 0;
            int count = 0;
            while(count < info.Length)
            {
                sum += info[count];
                count++;
            }
            Console.WriteLine("{0}", sum);
        }
    }
}
