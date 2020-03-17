using System;

namespace HW03.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double aDouble = 3.123;
            long aLong = (long)aDouble;

            long bLong = 99999999;
            int bInt = (int)bLong;

            double cDouble = 4.02;
            short cShort = (short)cDouble;


            int dInt = 123;
            double dDouble = dInt;

            byte fByte = 5;
            long fLong = fByte;

            long gChar = 899999999;
            decimal gSDecimal = gChar;


            int aBox = 50000;
            object obj1 = aBox;

            string bBox = "cat";
            object obj2 = bBox;

            bool cBox = false;
            object obj3 = cBox;


            int aUnbox = (int)obj1;
            string bUnbox = (string)obj2;
            bool cUnbox = (bool)obj3;

            ushort a = (ushort)(int)obj1;
            byte b = Convert.ToByte((bool)obj3);
            char c = 'z';
            object obj4 = c;
            int cObj4 = (int)(char)obj4;
        }
    }
}
