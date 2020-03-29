using System;

namespace HW._08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стихотворение в одну строку, разделяя строки точкой с запятой:");
            string line = Console.ReadLine();
            string[] arr = line.Split(';');
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]=arr[i].Replace('О', 'А');                
                arr[i]=arr[i].Replace('O', 'A');
                Console.WriteLine(arr[i]);
            }
        }
    }
}
