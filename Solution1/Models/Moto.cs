using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Moto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public uint Year { get; set; }
        public uint Odometer { get; set; }
        public uint Price { get; set; }
    }
}
