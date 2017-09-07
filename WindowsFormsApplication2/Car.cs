using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Car
    {
        public string Brand { get; set; }
        public string Size { get; set; }

        public Car(string brand, string size)
        {
            Brand = brand;
            Size = size;
        }
    }
}
