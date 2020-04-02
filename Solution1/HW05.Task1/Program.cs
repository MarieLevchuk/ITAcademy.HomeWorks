using System;

namespace HW05.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("English alphabet:");
            for (int i = 122; i >= 97; i--)
            {
                Console.Write((char)i);
            }
        }
    }
}
