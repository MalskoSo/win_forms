using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Client
    {
        public string       Name         { get; set; }
        public string       Surname      { get; set; }
        public string       Login        { get; set; }
        public string       Password     { get; set; }
        public string       Sex          { get; set; }
        public int          Money        { get; set; }
        public int          Age          { get; set; }
        public Animal       Pet          { get; set; }
        public Car          Auto         { get; set; }
        public List<Hotel>  BookedHotels { get; set; }

    public Client(string name, string surname, string login, string password, string sex, int money, int age, Animal pet, Car auto )
        {
            Name = name;
            Surname = surname;
            Login = login;
            Password = password;
            Money = money;
            Sex = sex;
            Age = age;
            Pet = pet;
            Auto = auto;
            BookedHotels = new List<Hotel>();
        }

        public Client(string name, string surname, string login, string password, string sex, int money, int age)
        {
            Name = name;
            Surname = surname;
            Login = login;
            Password = password;
            Money = money;
            Sex = sex;
            Age = age;
        }

        public static bool Registration(string name, string surname, string login, string password, string sex, int money, int age, Animal pet, Car auto)
        {
            if(isUnique(login))
            {
                Client pikamon = new Client(name, surname, login, password, sex, money, age, pet, auto);
                Storage.Clients.Add(pikamon);
                return true;
            }
            return false;
        }

        public static bool Registration(string name, string surname, string login, string password, string sex, int money, int age)
        {
            if (isUnique(login))
            {
                Client pikamon = new Client(name, surname, login, password, sex, money, age);
                Storage.Clients.Add(pikamon);
                return true;
            }
            return false;
        }

        public static bool isUnique(string login)
        {
            foreach(var client in Storage.Clients)
            {
                if (client.Login == login)
                    return false;
            }
            return true;
        }
        
        public bool isThis(string login, string password)
        {
            return (login == Login) && (password == Password);
        }

        public static bool LogIn(string login, string password)
        {
            foreach(Client client in Storage.Clients)
            {
                if(client.isThis(login, password))
                {
                    CurrentUser.getInstance().currentClient = client;
                    return true;
                }
            }
            return false;
        }

        public void Donation(int money)
        {
            Money -= money;
        }
        public static bool pokemon (Hotel hotel)
        {
            Client charizard = CurrentUser.getInstance().currentClient;
            if(hotel.TotalPrice > charizard.Money || hotel.Owner != null)
            {
                return false;
            }
            hotel.Owner = charizard;
            charizard.Money -= hotel.TotalPrice;
            return true;
        }
    }
}

