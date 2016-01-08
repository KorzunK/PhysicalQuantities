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
            try
            {
                Time T1 = new Time(14);
                Length S1 = new Length(63);

                Console.WriteLine(S1.Value + "(" + S1.Type + ")");

                var V = S1 / T1;
                var s = S1 - S1;

                Console.WriteLine(V.Value + "(" + V.Type + ")");
                Console.WriteLine(s.Value + "(" + s.Type + ")");

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                Console.ReadLine();
            }
        }
    }
}
