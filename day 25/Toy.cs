using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_25
{
    class Toy
    {
        public int MinimumAge { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return $"{MinimumAge},{Brand},{Price}";
        }
        
    }
}
