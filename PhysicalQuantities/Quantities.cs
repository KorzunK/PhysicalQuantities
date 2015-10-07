using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalQuantities
{
    public class Quantities
    {
        public enum Value
        {
            Length,
            Speed,
            Time
        }

        public static List<string> list = new List<string>();

        public string WriteValue(string Something)
        {
            string st = null;

            foreach (var v in list)
            {
                if (list[0] == Something && list[1] == Something)
                {
                    st = Something;
                    break;
                }
            }
            return st;
        }
    }
}
