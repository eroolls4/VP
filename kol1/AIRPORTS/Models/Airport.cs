using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIRPORTS.Models
{
    public class Airport
    {
        public string Name { get; set; }
        public string Kratenka { get; set; }
        public string City { get; set; }

        public List<Destination> Destinations { get; set; }


        public Airport() { }


        public Airport(string name, string kratenka, string city)
        {
            Name = name;
            Kratenka = kratenka;
            City = city;
            Destinations = new List<Destination>();
        }

        public void addDestination(Destination destination)
        {
            this.Destinations.Add(destination);
        }



        public decimal getAverageLengthForDestinations()
        {
            return Destinations.Average(x => x.Length);
        }

        public Destination mostExpensive()
        {
            Destination max = Destinations[0];
            foreach (var item in Destinations)
            {
                if(item.Price > max.Price)
                {
                    max = item;
                }
            }
            return max;
        }


        public override string ToString()
        {
            return $"{Kratenka} - {Name} - {City}";
        }
    }
}
