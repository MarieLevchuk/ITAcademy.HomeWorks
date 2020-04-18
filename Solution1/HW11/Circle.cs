using System;
using System.Collections.Generic;
using System.Text;

namespace HW11
{
    class Circle : Shapes
    {
        public Circle()
        {
            Name = "Circle";
        }

        public override void AreaCalculate()
        {
            Area = Math.PI * Side * Side/4;
        }
    }
}
