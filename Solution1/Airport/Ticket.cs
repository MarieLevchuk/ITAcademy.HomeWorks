using System;
using System.Collections.Generic;
using System.Text;

namespace Airport
{
    class Ticket : Documents
    {
        public int Seat { get; protected set; } = 13;
        public int FlightNuber { get; protected set; } = 12345;
        public string CountryOfConsignment { get; protected set; } = "USA";

        public Ticket()
        {
            DocumentType = "Ticket";
        }        
    }
}
