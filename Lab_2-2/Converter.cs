using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_2
{
    internal class Converter
    {
        private double usd;
        private double eur;
        private double rub;
        public Converter(double usd, double eur, double rub)
        {

            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        public void ChooseCurrencyAndPrintResult()
        {
            Console.WriteLine("Currency converter");
            Console.WriteLine("Write the name of the currency you want to convert \n(usd, eur, rub, uah)");
            string currency = Console.ReadLine();
            Console.WriteLine("Write your amount of money:");
            double money = Convert.ToDouble(Console.ReadLine());
            switch (currency)
            {
                case "usd":
                    {
                        Console.WriteLine($"Result: {money * usd} uah");
                        break;
                    }
                case "eur":
                    {
                        Console.WriteLine($"Result: {money * eur} uah");
                        break;
                    }
                case "rub":
                    {
                        Console.WriteLine($"Result: {money * rub} uah");
                        break;
                    }
                case "uah":
                    {
                        UAHtoCurrency(money);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("This currency is not exist. Try again!");
                        break;
                    }
            }
        }
        public void UAHtoCurrency(double uah)
        {
            Console.WriteLine("Write to which cuurency you want to convert (usd, eur, rub)");
            string toConvertCur = Console.ReadLine();
            switch (toConvertCur)
            {
                case "usd":
                    Console.WriteLine($"Result: {uah / usd} {toConvertCur}");
                    break;
                case "eur":
                    Console.WriteLine($"Result: {uah / eur} {toConvertCur}");
                    break;
                case "rub":
                    Console.WriteLine($"Result: {uah / eur} {toConvertCur}");
                    break;
                default:
                    Console.WriteLine("This currency is not exist. Try again!");
                    break;
            }
        }
    }
}
