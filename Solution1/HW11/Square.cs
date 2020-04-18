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
        }

        public override void AreaCalculate()
        {
            Area = Math.Pow(Side, 2);
        }
    }
}
