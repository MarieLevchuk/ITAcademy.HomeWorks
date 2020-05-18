using System;
using System.Collections.Generic;
using System.Text;

namespace Airport
{
    class BoardingCard: Ticket
    {
        public string Gate { get; private set; } 

        public BoardingCard()
        {
            DocumentType = "Boarding card";
            Gate = "B23";
        }
        public BoardingCard(string country, int seat)
        {
            DocumentType = "Boarding card";
            CountryOfConsignment = country;
            Seat = seat;
            Gate = "A23";     
        }
    }
}
