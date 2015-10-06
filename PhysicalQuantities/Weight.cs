using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
    public class Weight : Unit
    {
        public Weight(double value, string name)
        {
            Value = value;
            Name = name;
        }

        public static Weight operator +(Weight x, Weight y)
        {
            return new Weight(x.Value + y.Value, x.Name);
        }

        public static Weight operator -(Weight x, Weight y)
        {
            return new Weight(x.Value - y.Value, x.Name);
        }

        public static Weight operator *(Weight x, Weight y)
        {
            return new Weight(x.Value * y.Value, x.Name);
        }

        public static Weight operator /(Weight x, Weight y)
        {
            return new Weight(x.Value / y.Value, x.Name);
        }

        public override string ToString()
        {
            return (String.Format("{0}{1}", Value, Name));
        }
    }
}
