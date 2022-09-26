using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lab_2_2.Converter converter = new Lab_2_2.Converter(41.8, 40.2, 0.63);
            converter.ChooseCurrencyAndPrintResult();
        }
    }
}
