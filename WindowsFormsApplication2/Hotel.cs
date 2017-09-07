using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Hotel
    {
        public string Address { get; set; }
        public string Name { get; set; } 
        public int Price { get; set; }
        public int Free { get; set; }
        public Client Owner { get; set; }
        public int TotalPrice { get; set; }

        public Hotel(string address, string name, int price, int free, int totalprice)
        {
            Address = address;
            Name = name;
            Price = price;
            Free = free;
            Owner = null;
            TotalPrice = totalprice;
        }

        public Hotel () { }

        public static bool AddHotel(string address, string name, int price, int free, int totalPrice)
        {
            if (isUnique(address))
            {
                Hotel pikachu = new Hotel(address, name, price, free, totalPrice);
                Storage.Hotels.Add(pikachu);
                return true;
            }
            return false;
        }

        public static bool isUnique(string address)
        {
            foreach (var hotel in Storage.Hotels)
            {
                if (hotel.Address == address)
                    return false;
            }
            return true;
        }

        public static List<Hotel> SearchByName(string name)
        {
            List<Hotel> result = new List<Hotel>();
            foreach (Hotel hotel in Storage.Hotels)
            {
                if(hotel.Name == name)
                {
                    result.Add(hotel);
                }
            }
            return result;
        }
        public static List<Hotel> SearchByPrice(int price)
        {
            List<Hotel> result = new List<Hotel>();
            foreach (Hotel hotel in Storage.Hotels)
            {
                if (hotel.Price <= price)
                {
                    result.Add(hotel);
                }
            }
            return result;
        }
        public static List<Hotel> SearchByAddress(string address)
        {
            List<Hotel> result = new List<Hotel>();
            foreach (Hotel hotel in Storage.Hotels)
            {
                if (hotel.Address == address)
                {
                    result.Add(hotel);
                }
            }
            return result;
        }

        public static bool reserve (Hotel pomidorka)
        {
            Client pikachu = CurrentUser.getInstance().currentClient;
            if(pikachu.Money <= pomidorka.Price || pomidorka.Free == 0)
            {
                return false;
            }
            pikachu.Money -= pomidorka.Price;
            pomidorka.Free--;
            pikachu.BookedHotels.Add(pomidorka);
                return true;
        }
        
    }
}
