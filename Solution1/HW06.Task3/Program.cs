using System;

namespace HW06.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 10);
            }
            Console.WriteLine("Initial array:");
            foreach (var item in arr)
            {
                Console.Write($"{item}\t");
            }
            int k = 0;
            for (int i = 0; i < arr.Length/2; i++)
            {
                k = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = k;
            }
            Console.WriteLine("\nReversed array:");
            foreach (var item in arr)
            {
                Console.Write($"{item}\t");
            }
        }
    }
}
