using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Smartphone : Phone
    {

        public Smartphone()
        { 
            Wifi = true;
        }

        public bool Wifi { get; set; }
        public double Megapixel { get; set; }
    }
}
