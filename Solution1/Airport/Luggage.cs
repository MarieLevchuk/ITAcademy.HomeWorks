using System;
using System.Collections.Generic;
using System.Text;

namespace Airport
{
    class Luggage: Passenger
    {
        public int Amount { get; protected set; }   
        
        public Luggage() { }
        public Luggage (int amount)
        {
            Amount = amount;            
        }
    }
}
