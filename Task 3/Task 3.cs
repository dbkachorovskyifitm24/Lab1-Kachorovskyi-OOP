using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Employee
    {
        public string LastName { get; }
        public string FirstName { get; }

        public Employee(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        public void CalculateSalary(string position, int experience)
        {
            double baseSalary = 12000;

            position = position.ToLower();
            switch (position)
            {
                case "менеджер":
                    baseSalary = 15000;
                    break;
                case "програміст":
                    baseSalary = 25000;
                    break;
                case "бухгалтер":
                    baseSalary = 18000;
                    break;
            }

            double bonus = experience * 0.05 * baseSalary;
            double salary = baseSalary + bonus;
            double tax = salary * 0.18;

            Console.WriteLine();
            Console.WriteLine("Працiвник: {0} {1}", LastName, FirstName);
            Console.WriteLine("Посада: {0}", position);
            Console.WriteLine("Стаж: {0} років", experience);
            Console.WriteLine("Оклад: {0:F2} грн", salary);
            Console.WriteLine("Податок (18%): {0:F2} грн", tax);
            Console.WriteLine("Чиста зарплата: {0:F2} грн", salary - tax);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Введiть прiзвище: ");
            string lastName = Console.ReadLine();

            Console.Write("Введiть iм’я: ");
            string firstName = Console.ReadLine();

            Console.Write("Введiть посаду: ");
            string position = Console.ReadLine();

            Console.Write("Введiть стаж (рокiв): ");
            int experience = int.Parse(Console.ReadLine());

            Employee employee = new Employee(lastName, firstName);
            employee.CalculateSalary(position, experience);
        }
    }

}
