using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFMB
{
    enum Days : int//byte
    {
        Saturday,
        Sunday = 90,
        Monday = -7,
        Tuesday = 300
    }

    class Constant
    {
        public int a = 8;
        public const int b = 4;
        public readonly int c = 4;

        public Constant()
        {
            c = 90;
            c = 7;
        }

        public Constant(int y)
        {
            c = y;
            c++;
        }

        public void M1()
        {
            //b = 9;
            //c = 90;
        }
    }
}
