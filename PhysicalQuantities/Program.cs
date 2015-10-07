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
            Unit Speed = new Unit(45, Quantities.Value.Speed.ToString());
            Unit S = new Unit(45, Quantities.Value.Speed.ToString());
            Unit Length = new Unit(200, Quantities.Value.Length.ToString());
            Unit l = new Unit(200, Quantities.Value.Length.ToString());
            Unit Time = new Unit(63, Quantities.Value.Time.ToString());
            Unit T = new Unit(63, Quantities.Value.Time.ToString());


            Quantities.list.Add("Метр(ов)");
            Quantities.list.Add("Секунд(ы)");
            Quantities.list.Add("Mетры(ов) в секунду");
      

            Unit sum = Time + T;
            Console.WriteLine("Ответ = {0}", sum.ToString());

            Unit dev  = Speed / S;
            Console.WriteLine("Ответ = {0}", dev.ToString());

            Unit tm = Length / Speed;
            Console.WriteLine("Ответ = {0}", tm.ToString());

            Console.ReadLine();
        }
    }
}
