using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Storage
    {
        public static List<Client> Clients = new List<Client>
        {
            new Client ("Satan", "Moriarthy", "iamsatan", "666", "IT", 2069696969, 9999999, null, null)
        };
        public static List<Hotel> Hotels = new List<Hotel>
        {
            new Hotel("Konoha", "Naruto", 500, 7000, 9990000),
            new Hotel("Magnolia", "Fairy Tail", 450, 9000, 1000000),
            new Hotel("Ainkrad", "SAO", 550, 15000, 2000000),
            new Hotel("school", "Ecchi", 700, 1000, 50000),
            new Hotel("http:\\pornhub.com", "porno", 1100, 50000, 2100250000),
            new Hotel
            {
                Address = "Hell",
                Name = "Teemo",
                Price = 1,
                Free = 2000000000,
                TotalPrice = 0,
                Owner = new Client ("Satan", "Moriarthy", "iamsatan", "666", "IT", 2069696969, 9999999, null, null)
            }

        };
    }
}
