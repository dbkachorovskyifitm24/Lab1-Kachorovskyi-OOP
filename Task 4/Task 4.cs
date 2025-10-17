using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class User
    {
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public readonly DateTime DateCreated;

        public User()
        {
            DateCreated = DateTime.Now;
        }

        public void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Iнформація про користувача:");
            Console.WriteLine("Логiн: {0}", Login);
            Console.WriteLine("Iм’я: {0}", FirstName);
            Console.WriteLine("Прiзвище: {0}", LastName);
            Console.WriteLine("Вiк: {0}", Age);
            Console.WriteLine("Дата заповнення анкети: {0}", DateCreated);
        }
    }

    class Program
    {
        static void Main()
        {
            User user = new User();

            Console.Write("Введiть логiн: ");
            user.Login = Console.ReadLine();

            Console.Write("Введiть iм’я: ");
            user.FirstName = Console.ReadLine();

            Console.Write("Введiть прiзвище: ");
            user.LastName = Console.ReadLine();

            Console.Write("Введiть вiк: ");
            user.Age = int.Parse(Console.ReadLine());

            user.ShowInfo();
        }
    }

}
