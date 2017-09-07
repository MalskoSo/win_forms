using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Animal
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Size { get; set; }
        public string Mass { get; set; }

        public Animal(string name, string breed, string size, string mass)
        {
            Name = name;
            Breed = breed;
            Size = size;
            Mass = mass;
        }
    }
}
