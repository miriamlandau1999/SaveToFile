using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_25
{
    class Program
    {
        static void Main(string[] args)
        {
           
            bool flag = true;
            ToyManager tm = new ToyManager(new FileToySaver(), "Toys.txt");  
            while(flag)
            {
                Console.Clear();
                Console.WriteLine("Menu\n1)Add toy\n2)GetAll\n3)exit");
                int entry = int.Parse(Console.ReadLine());
                Console.Clear();
                flag = tm.prompt(entry);
            }
        }
    }
}
