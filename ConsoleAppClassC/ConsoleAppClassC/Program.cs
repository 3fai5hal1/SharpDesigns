using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClassC
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddressFormat a1 = new AddressFormat(23, 45, 7788, "Khulna");

            Student s1 = new Student();
            s1.Id = 100; //s1.SetId(100); //s1.id = 100;
            s1.Name = "Bruce"; //s1.SetName("Bruce"); //s1.name = "Bruce";
            s1.Cgpa = 3.28; //s1.SetCgpa(3.28); //s1.cgpa = 3.28;
            s1.BloodGroup = "AB+"; //s1.SetBloodGroup("AB+"); //s1.bloodGroup = "AB+";
            s1.Address = new AddressFormat(23, 45, 7788, "Khulna"); //s1.SetAddress(new AddressFormat(23, 45, 7788, "Khulna"));
            //s1.PrintStudentInfo();

            Student s2 = new Student(200, "Clerk", -3.22, "O+", new AddressFormat(23, 45, 7788, "Khulna"));
            //s2.PrintStudentInfo();

            Student[] std = new Student[3];
            std[0] = new Student();
            std[1] = new Student(200, "Clerk", -3.22, "O+", new AddressFormat(23, 45, 7788, "Khulna"));
            std[2] = new Student(200, "Clerk", -3.22, "O+", new AddressFormat(23, 45, 7788, "Khulna"));

            foreach (Student s in std)
                s.PrintStudentInfo();

            int[] ax = new int[5] { 54, 89, 66, -90, 390 };
            /*
            for(byte q = 0; q < ax.Length; q++)
            {
                Console.Write("{0} ", ax[q]);
            }
            Console.WriteLine();

            byte t = 0;
            while (t < ax.Length)
            {
                Console.Write("{0} ", ax[t]);
                t++;
            }
            Console.WriteLine();

            t = 5;
            do
            {
                Console.Write("{0} ", ax[3]);
                t++;
            }
            while (t < ax.Length);
            Console.WriteLine();

            foreach (int h in ax)
            {
                Console.Write("{0} ", h);
            }
            Console.WriteLine();

            int[,] bx = new int[4, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            byte r = 0, c;
            while(r < 4)
            {
                c = 0;
                while(c < 3)
                {
                    Console.Write("{0} ", bx[r, c]);
                    c++;
                }
                r++;
                Console.WriteLine();
            }

            foreach (int j in bx)
                Console.Write($"{j} ");
            Console.WriteLine();
            Console.WriteLine();
            int[,,,] k = new int[5, 2, 3, 7];

            int[][] jx = new int[4][];
            jx[0] = new int[3] { 1, 2, 3 };
            jx[1] = new int[2] { 4, 5 };
            jx[2] = new int[5] { 6, 7, 8, 9, 10 };
            jx[3] = new int[1] { 11 };

            r = 0;
            while (r < jx.Length)
            {
                c = 0;
                while (c < jx[r].Length)
                {
                    Console.Write("{0} ", jx[r][c]);
                    c++;
                }
                r++;
                Console.WriteLine();*/
        }

        }
    }
}
