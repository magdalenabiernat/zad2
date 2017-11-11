using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2_wzór_2017_2
{
    class SuperHorse : Horse
    {
        //corner
        public bool Corner { get; set; }
        public SuperHorse(string horseName, string color, bool isFlying,bool corner) : base(horseName,color,isFlying)
        {
            Corner = corner;
        }
    }
}
