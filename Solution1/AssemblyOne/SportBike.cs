using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    sealed class SportBike: Motorcycle
    {
        public void GetNumber()
        {
            numberProtected = "0F9C5FBD-4A04-sportbike";
        }
    }

    //SportBike is sealed
    //class SportBike2: SportBike { }
}
