using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Converter
    {
        private double usd;
        private double eur;
        private double pln;

        public Converter(double usd, double eur, double pln)
        {
            this.usd = usd;
            this.eur = eur;
            this.pln = pln;
        }

        public double FromUAH(double amount, string currency)
        {
            currency = currency.ToLower();
            switch (currency)
            {
                case "usd": return amount / usd;
                case "eur": return amount / eur;
                case "pln": return amount / pln;
                default:
                    Console.WriteLine("Невiдома валюта.");
                    return 0;
            }
        }

        public double ToUAH(double amount, string currency)
        {
            currency = currency.ToLower();
            switch (currency)
            {
                case "usd": return amount * usd;
                case "eur": return amount * eur;
                case "pln": return amount * pln;
                default:
                    Console.WriteLine("Невiдома валюта.");
                    return 0;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Converter converter = new Converter(41.2, 44.5, 9.9);

            Console.Write("Введiть тип операцiї (1 - з грн, 2 - в грн): ");
            int type = int.Parse(Console.ReadLine());

            Console.Write("Введiть валюту (usd / eur / pln): ");
            string currency = Console.ReadLine();

            Console.Write("Введiть суму: ");
            double amount = double.Parse(Console.ReadLine());

            if (type == 1)
            {
                double result = converter.FromUAH(amount, currency);
                Console.WriteLine("Результат: {0:F2} {1}", result, currency.ToUpper());
            }
            else if (type == 2)
            {
                double result = converter.ToUAH(amount, currency);
                Console.WriteLine("Результат: {0:F2} грн", result);
            }
            else
            {
                Console.WriteLine("Невiрний вибiр.");
            }
        }
    }

}
