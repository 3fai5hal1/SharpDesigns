using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritanceC
{
    class Program
    {
        int m;
        static int n;

        static void Main(string[] args)
        {
            //Parent p1 = new Parent();
            //Parent p2 = new Parent(45);
            //Child c1 = new Child();
            //Child c2 = new Child(65);
            //Child c3 = new Child("hello");
            Parent pp = new Child();
            //Console.WriteLine();

            //p1.MethodA();
            //c1.MethodA();
            //p1.MethodB();
            //c1.MethodB();
            //pp.MethodA();
            //pp.MethodB();
            //pp.MethodC();

            //Person[] pList = new Person[3];
            //pList[0] = new Person(100, "Bruce", "AB+", new AddressFormat(23, 83, 1199, "Sylhet"));
            //pList[1] = new Student(200, "Clerk", "B+", new AddressFormat(123, 54, 9384, "Khulna"), 3.21);
            //pList[2] = new Employee(300, "Diana", "O+", new AddressFormat(178, 94, 5678, "Bogura"), 14500);

            //foreach (Person p in pList)
            //    p.PrintInfo();

            //Person p1 = new Person(100, "Bruce", "AB+", new AddressFormat(23, 83, 1199, "Sylhet"));
            //p1.PrintInfo();
            //Person s1 = new Student(200, "Clerk", "B+", new AddressFormat(123, 54, 9384, "Khulna"), 3.21);
            //s1.PrintInfo();
            //Person e1 = new Employee(300, "Diana", "O+", new AddressFormat(178, 94, 5678, "Bogura"), 14500);
            //e1.PrintInfo();

            Object o1 = 23;
            Object o2 = 34.67;
            Object o3 = "Hello";
            Object o4 = new Parent();

            Console.WriteLine(o1.GetType());
            Console.WriteLine(o2.GetType());
            Console.WriteLine(o3.GetType());
            Console.WriteLine(o4.GetType());

            var a = 12;
            var b = 7.898;
            var c = "Test";
            var d = new Child();
            Console.WriteLine(o1.GetType());
            Console.WriteLine(o2.GetType());
            Console.WriteLine(o3.GetType());
            Console.WriteLine(o4.GetType());

            dynamic p = 90;
            dynamic q = new Parent();
            //q.NoMethod();

            Nullable<int> k = null;
            int? w = 8;//null;

            int h = w ?? 40;///k.HasValue

            n = 23;
            M2();
            Program.M2();
            Program ppp = new Program();
            ppp.M3();
        }

        static void M2()
        {
            //m = 9;
            n = 8;
            int k = 90;
        }

        void M3() { }
    }
}
