using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2_wzór_2017_2
{
    class Racehorse
    {
        public string HorseName { get; set; }
        public string Color { get; set; }
        public bool Corner { get; set; }
        public int Prize { get; set; }

        public Racehorse(string horseName, string color, bool corner, int prize)
        {
            HorseName = horseName;
            Color = color;
            Corner = corner;
            Prize = prize;
        }
    }
}
