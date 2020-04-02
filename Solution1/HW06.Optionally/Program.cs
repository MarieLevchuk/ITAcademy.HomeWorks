using System;
using System.Diagnostics;

namespace HW06.Optionally
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = new long[100000000];
            Random rnd = new Random();
            for (long i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 10);
            }            
            Stopwatch sw = new Stopwatch();
            sw.Start();
            long k = 0;
            for (long i = 0; i < arr.Length / 2; i++)
            {
                k = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = k;
            }
            sw.Stop();
            
            Console.WriteLine($"\nResult: {sw.ElapsedMilliseconds}");
        }
    }
}
