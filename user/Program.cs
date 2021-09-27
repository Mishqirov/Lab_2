using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Login = "pitrey3467@gmail.com";
            user.Name = "Ivan";
            user.LastName = "Pitreysiop";
            Console.WriteLine($"{user.Login} - {user.Name}, {user.LastName}");
            user.M();
            Console.ReadKey();
        }
    }
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public readonly DateTime dateTime = new DateTime(2022, 10, 10);
        public void M()
        {
            Console.WriteLine($"DateTime = {dateTime}");
        }
    }
}
