using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    internal class Program
    {
        static void Print(Adress adress)
        {
            Console.WriteLine($"{adress.Country}, " +
                $"{adress.City}, " +
                $"{adress.Street} street {adress.House}/{adress.Apartment}, " +
                $"{adress.Index}");
        }
        static void Main(string[] args)
        {
            Adress adress1 = new Adress();
            adress1.Index = "02000";
            adress1.Country = "Ukraine";
            adress1.City = "Kyiv";
            adress1.Street = "Kyoto";
            adress1.House = 19;
            adress1.Apartment = 1;
            Print(adress1);

            Adress adress2 = new Adress();
            adress2.Index = "02080";
            adress2.Country = "Ukraine";
            adress2.City = "Kyiv";
            adress2.Street = "Miliytenka";
            adress2.House = 6;
            adress2.Apartment = 333;
            Print(adress2);
        }
    }
}