using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_4
{
    internal class User
    {
        private readonly DateTime date = DateTime.Now;
        private string login = "admin";
        private string name = "Margo";
        private string surname = "Jones";
        private int age = 35;
        public void InfoAboutUser()
        {
            Console.WriteLine($"Login: {login}\n" +
                $"Name: {name}\n" +
                $"Surname: {surname}\n" +
                $"Age: {age}\n" +
                $"Date of filling: {date}\n");
        }

    }
}
