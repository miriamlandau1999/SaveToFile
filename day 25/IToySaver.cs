using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_25
{
    interface IToySaver
    {
        void Save(List<Toy> toys, string fileName);
        List<Toy> Retrieve(string fileName);
        
    }
}
