using System;
using System.Collections.Generic;
using System.Text;

namespace Airport
{
    class Documents : Passenger
    {
        public string FullName { get; private set; }
        public string DocumentNumber { get; set; }
        public string DocumentType {get; protected set;}
        public Documents()
        {
            FullName = $"{Surname} {Name} {Patronymic}";            
        }
    }
}
