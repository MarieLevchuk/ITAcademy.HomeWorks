using System;
using System.Collections.Generic;
using System.Text;

namespace HW11
{
    class Shapes
    {
        protected Random rnd = new Random();

        public int Side { get; private set; }
        public double Area { get; protected set; }
        public string Name { get; protected set; }
        
        public Shapes()
        {            
            Side = rnd.Next(1, 10);
        }

        public virtual void AreaCalculate() { }
    }
}
