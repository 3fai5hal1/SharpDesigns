using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritanceC
{
    internal class Parent
    {
        internal Parent() //: this("test")
        {
            Console.WriteLine("Parent D");
        }

        internal Parent(int u) : this()
        {
            Console.WriteLine("Parent NDC-I " + u);
        }

        internal Parent(string u)
        {
            Console.WriteLine("Parent NDC-S " + u);
        }

        internal void MethodA()
        {
            Console.WriteLine("Parent MethodA");
        }

        internal virtual void MethodB()
        {
            Console.WriteLine("Parent MethodB");
        }

        internal virtual void MethodC()
        {
            Console.WriteLine("Parent MethodC");
        }
    }
}
