using System;
using System.Collections.Generic;
using System.Text;

namespace Airport
{
    class Passenger
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Patronymic { get; private set; }

        public Passenger() { }
        public Passenger (string surname, string name, string patronymic="")
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
        }        
    }
}
