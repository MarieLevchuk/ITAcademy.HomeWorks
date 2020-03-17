using System;

namespace HW03.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a1= -10;
            SByte a2 = -11;
            Console.WriteLine(a1.GetType());
            Console.WriteLine(a2.GetType());

            short b1 = -500;
            Int16 b2 = -400;
            Console.WriteLine(b1.GetType());
            Console.WriteLine(b2.GetType());

            int c1 = 123;
            Int32 c2 = -123;
            Console.WriteLine(c1.GetType());
            Console.WriteLine(c2.GetType());

            long d1 = -100000;
            Int64 d2 = 110000;
            Console.WriteLine(d1.GetType());
            Console.WriteLine(d2.GetType());

            byte e1 = 99;
            Byte e2 = 98;
            Console.WriteLine(e1.GetType());
            Console.WriteLine(e2.GetType());

            ushort f1 = 655;
            UInt16 f2 = 666;
            Console.WriteLine(f1.GetType());
            Console.WriteLine(f2.GetType());

            char g1 = 'c';
            Char g2 = '!';
            Console.WriteLine(g1.GetType());
            Console.WriteLine(g2.GetType());

            uint h1 = 333;
            UInt32 h2 = 334;
            Console.WriteLine(h1.GetType());
            Console.WriteLine(h2.GetType());

            ulong i1 = 12321;
            UInt64 i2 = 123321;
            Console.WriteLine(i1.GetType());
            Console.WriteLine(i2.GetType());

            float k1 = 2.2f;
            Single k2 = 45.05f;
            Console.WriteLine(k1.GetType());
            Console.WriteLine(k2.GetType());

            double l1 = 8.098;
            Double l2 = 8.98;
            Console.WriteLine(l1.GetType());
            Console.WriteLine(l2.GetType());

            decimal m1 = 1.2E3m;
            Decimal m2 = 1.3E2m;
            Console.WriteLine(m1.GetType());
            Console.WriteLine(m2.GetType());

            object obj1 = 9;
            Object obj2 = true;
            Console.WriteLine(obj1.GetType());
            Console.WriteLine(obj2.GetType());

            string str1 = "valar morghulis";
            String str2 = "valar dohaeris";
            Console.WriteLine(str1.GetType());
            Console.WriteLine(str2.GetType());
        }
    }
}
