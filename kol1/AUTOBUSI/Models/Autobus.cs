using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUTOBUSI.Models
{
    public class Autobus
    {
        public string Registration { get; set; }
        public string Name { get; set; }

        public bool isLocal { get; set; }

       public  List<Line> Lines { get; set; }


        public Autobus() { }

        public Autobus(string registration, string name, bool isLocal)
        {
            Registration = registration;
            Name = name;
            this.isLocal = isLocal;
            Lines = new List<Line>();
        }



        public void addLine(Line line)
        {
            this.Lines.Add(line);
        }

        public decimal getAvgPrice()
        {
            return Lines.Average(x => x.Price);
        }

        public Line mostExpensive()
        {
            Line max = Lines.ElementAt(0);
            foreach (var item in Lines.Skip(1))
            {
                if(item.Price > max.Price)
                {
                    max = item;
                }
            }
            return max;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            String print = isLocal ? "L" : "M";
            return $"{Name} - {Registration} - {print}";
        }
    }
}
