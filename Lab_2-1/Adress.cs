using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    class Adress
    {
        private string index, country, city, street;
        private int house, apartment;
        public string Index
        {
            get
            {
                return index;
            }
            set
            {
                index = CheckLength(value);
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = CheckLength(value);
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = CheckLength(value);
            }
        }
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = CheckLength(value);
            }
        }
        public int House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }
        public int Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }
        static string CheckLength(string value)
        {
            if (value.Length <= 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Value can't be less than 1 symbol");
                Console.ResetColor();
                return "?";
            }
            else
            {
                return value;
            }
        }
    }
}