using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritanceC
{
    internal class Child : Parent
    {
        internal Child() //: base(10)
        {
            Console.WriteLine("Child D");
        }

        internal Child(int w) : this("world")//base(w)
        {
            Console.WriteLine("Child NDC-I " + w);
        }

        internal Child(string w) : this()//base()//base(34)
        {
            Console.WriteLine("Child NDC-S " + w);
        }

        internal void MethodA()
        {
            Console.WriteLine("Child MethodA");
        }

        internal override void MethodB()
        {
            Console.WriteLine("Child MethodB");
        }

        internal new void MethodC()
        {
            Console.WriteLine("Child MethodC");
        }

        internal void MethodD()
        {
            Console.WriteLine("Child MethodD");
        }
    }
}
