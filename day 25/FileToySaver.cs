using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_25
{
    class FileToySaver : IToySaver
    {
        public List<Toy> Retrieve(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return new List<Toy>();
            }
            else
            {
                string[] toyStrings = File.ReadAllLines(fileName);
                List<Toy> toys = new List<Toy>();
               
                    for (int i = 0; i < toyStrings.Length; i++)
                    {
                        string[] toyParts = toyStrings[i].Split(',');
                        Toy toy = new Toy
                        {
                            MinimumAge = int.Parse(toyParts[0]),
                            Brand = toyParts[1],
                            Price = int.Parse(toyParts[2])
                        };
                        toys.Add(toy);
                    }
                return toys;
            }
        }

        public void Save(List<Toy> toys, string fileName)
        {
            List<string> toysString = new List<string>();
            foreach(Toy toy in toys)
            {
                toysString.Add($"{toy.MinimumAge}, {toy.Brand}, {toy.Price}");
            }
            File.WriteAllLines(fileName, toysString.ToArray());
        }
    }
}
