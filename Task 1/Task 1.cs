using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Address
    {
        public string Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }

        public void Adress()
        {
            Console.WriteLine($"Iндекс: {Index}");
            Console.WriteLine($"Країна: {Country}");
            Console.WriteLine($"Мiсто: {City}");
            Console.WriteLine($"Вулиця: {Street}");
            Console.WriteLine($"Будинок: {House}");
            Console.WriteLine($"Квартира: {Apartment}");
        }
    }

    class Program
    {
        static void Main()
        {
            Address myAddress = new Address
            {
                Index = "79000",
                Country = "Україна",
                City = "Львiв",
                Street = "Шевченка",
                House = "25",
                Apartment = "12"
            };

            Console.WriteLine("Адреса користувача:");
            myAddress.Adress();
        }
    }
}
