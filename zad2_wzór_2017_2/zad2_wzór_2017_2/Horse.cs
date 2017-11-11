using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2_wzór_2017_2
{
    class Horse
    {
        public string HorseName { get; set; }
        public string Color { get; set; }
        public bool IsFlying { get; set; }

        public Horse(string horseName, string color, bool isFlying)
        {
            HorseName = horseName;
            Color = color;
            IsFlying = isFlying;
        }
    }
}
