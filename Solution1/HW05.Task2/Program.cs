using System;

namespace HW05.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter symbol:");
            char symbol = char.Parse(Console.ReadLine());
            switch (symbol)
            {
                case 'w':
                case 'W':
                    Console.WriteLine("up");
                    break;
                case 'd':
                case 'D':
                    Console.WriteLine("right");
                    break;
                case 's':
                case 'S':
                    Console.WriteLine("down");
                    break;
                case 'a':
                case 'A':
                    Console.WriteLine("left");
                    break;
                default:
                    Console.WriteLine("don't move");
                    break;
            }
        }
    }
}
