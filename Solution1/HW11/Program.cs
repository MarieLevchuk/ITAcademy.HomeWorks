﻿using System;

namespace HW11
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes[] shapes =
            {
                new Circle(),
                new Square(),
                new Triangle()
            };
            foreach (var item in shapes)
            {
                item.AreaCalculate();
                Console.WriteLine($"This is {item.Name}\nCLR Type is {item.GetType()}\nSquare is {item.Area}");
            }
        }
    }
}
