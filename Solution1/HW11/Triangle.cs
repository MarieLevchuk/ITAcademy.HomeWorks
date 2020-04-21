using System;
using System.Collections.Generic;
using System.Text;

namespace HW11
{
    class Triangle : Shapes
    {
        public int Height { get; private set; }

        public Triangle()
        {
            Name = "Triangle";
            Height = rnd.Next(1, 10);

            Logger.Log.Info($"Create a {Name}");
        }

        public override void AreaCalculate()
        {
            Area = 0.5 * Side * Height;
        }
    }
}
