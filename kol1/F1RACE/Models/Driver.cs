using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1RACE.Models
{
    public class Driver
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool isFirst { get; set; }

        public List<Lap> Laps { get; set; } = new List<Lap>();


        public Driver() { } 

        public Driver(string name, int age, bool isFirst)
        {
            Name = name;
            Age = age;
            this.isFirst = isFirst;
        }


        public void addLap(Lap lap)
        {
            Laps.Add(lap);
        }


        public Lap findFastestLap()
        {
            Lap res = Laps.ElementAt(0);
            foreach (var item in Laps.Skip(1))
            {
                if(item.getTime() < res.getTime())
                {
                    res = item;
                }
            };
            return res;
        }

        public override string ToString()
        {
            string x = isFirst ? "F" : "S";
            return $"{Name} ({Age}) - {x}";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
