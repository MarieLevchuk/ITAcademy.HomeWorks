using System;

namespace HW06.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            Random rnd = new Random();
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rnd.Next(-10, 10);                
            }
            int[] arr2 = new int[5];
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine($"Enter a value of the element {i}:");
                arr2[i] = int.Parse(Console.ReadLine());
            }
            int[] arr3 = new int[5];
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = arr1[i] + arr2[i];
            }
            Console.WriteLine("First array:");
            foreach (var item in arr1)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine("\nSecond array:");
            foreach (var item in arr2)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine("\nThird array:");
            foreach (var item in arr3)
            {
                Console.Write($"{item}\t");
            }
        }
    }
}
