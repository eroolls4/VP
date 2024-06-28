using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIRPORTS.Models
{
    public class Destination
    {
        public string Name { get; set; }
        public decimal Length { get; set; }
        public decimal Price { get; set; }

        public Destination() { }

        public Destination(string name, decimal length, decimal price)
        {
            Name = name;
            Length = length;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}  {Length} km - {Price} EUR";
        }
    }
}
