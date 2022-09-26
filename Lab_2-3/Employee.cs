using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_3
{
    internal class Employee
    {
        private const double minSalary = 6500;
        private const double tax = 0.195;
        private string name = "";
        private string surname = "";
        private string position = "junior";
        private int seniority = 3;
        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public int PositionInt ()
        {
            switch (this.position)
            {
                case "junior":
                    return 0;
                case "middle":
                    return 1;
                case "senior":
                    return 2;
                default: 
                    Console.WriteLine("Incorrect value entered!");
                    return 0;
            }
        }
        public double Salary()
        {
            if (seniority < 2)
            {
                return minSalary + PositionInt() * 5000 + this.seniority * 500;
            }
            else return minSalary + PositionInt() * 5000 + this.seniority * 1000;
        }
        public void AboutEmployee()
        {
            Console.WriteLine($"Name: {name}\n" +
                $"Surname: {surname}\n" +
                $"Position: {position} developer\n" +
                $"Salary: {Salary()} UAH\n" +
                $"Tax: {tax* Salary()} UAH");
        }
    }
}
