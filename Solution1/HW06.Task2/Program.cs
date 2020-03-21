using System;

namespace HW06.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7];
            for (int i = 0; i < arr.Length-1; i++)
            {
                Console.WriteLine($"Enter a value of the {i} element: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array: ");
            foreach (var item in arr)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine("\nEnter a number: ");
            int newItem = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter position of new number (from 0 to {arr.Length-1}): ");
            int newPosition = int.Parse(Console.ReadLine());
            for (int i = arr.Length-1; i > newPosition; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[newPosition] = newItem;
            foreach (var item in arr)
            {
                Console.Write($"{item}\t");
            }
        }
    }
}
