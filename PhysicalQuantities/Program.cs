using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
    class Program
    {
        static void Main(string[] args)
        {
            Length k = new Length(200, "км");
            Length g = new Length(145, "км");
            Weight n = new Weight(21, "кг");

            Length sum = k + g;
            Console.WriteLine("Cevvf = {0}",sum.ToString());

            Console.ReadLine();
        }
    }
}
