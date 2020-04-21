using System;
using System.Collections.Generic;
using System.Text;

namespace HW11
{
    class Square : Shapes
    {
        public Square()
        {
            Name = "Square";

            Logger.Log.Info($"Create a {Name}");
        }

        public override void AreaCalculate()
        {
            Area = Math.Pow(Side, 2);
        }
    }
}
