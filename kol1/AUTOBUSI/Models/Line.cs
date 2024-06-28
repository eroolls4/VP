using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUTOBUSI.Models
{
    public class Line
    {
        public string Destination { get; set; }
        public int Hour { get; set; }
        public int Minutes { get; set; }
        public decimal Price { get; set; }

        public Line() { }


        public Line(string destination, int hour, int minutes, decimal price)
        {
            Destination = destination;
            Hour = hour;
            Minutes = minutes;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Hour}:{Minutes} - {Destination} - {Price} DEN.";
        }
    }
}
