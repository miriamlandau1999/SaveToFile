using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_25
{
    class ToyManager
    {
        
        private string _fileName;
        private List<Toy> _toys;
        private IToySaver _IToySaver;
        public ToyManager(IToySaver toySaver, string fileName)
        {
            _fileName = fileName;
            _IToySaver = toySaver;
            _toys = toySaver.Retrieve(fileName);
        }
        private void Add(Toy toy)
        {
            _toys.Add(toy);
        }
        public List<Toy> GetAll()
        {
            return _toys;
        }
        private void Save()
        {
            _IToySaver.Save(_toys, _fileName);
        }
        public bool prompt(int entry)
        {
            if(entry == 1)
            {
                Toy toy = new Toy();
                Console.WriteLine("Minimum Age?");
                toy.MinimumAge = int.Parse(Console.ReadLine());
                Console.WriteLine("Brand");
                toy.Brand = (Console.ReadLine());
                Console.WriteLine("Price?");
                toy.Price = int.Parse(Console.ReadLine());
                Add(toy);
            }
            else if(entry == 2)
            {
                foreach(Toy toy in _toys)
                {
                    Console.WriteLine(toy);
                }
                Console.ReadKey(true);
            }
            else if(entry == 3)
            {
                Save();
                return false;
            }
            return true;
        }

        

    }
}
