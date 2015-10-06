using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
    public class Speed : Unit
    {
        public Speed(double value, string name)
        {
            Value = value;
            Name = name;
        }

        public static Speed operator +(Speed x, Speed y)
        {
            return new Speed(x.Value + y.Value, x.Name);
        }

        public static Speed operator -(Speed x, Speed y)
        {
            return new Speed(x.Value - y.Value, x.Name);
        }

        public static Speed operator *(Speed x, Speed y)
        {
            return new Speed(x.Value * y.Value, x.Name);
        }

        public static Speed operator /(Speed x, Speed y)
        {
            return new Speed(x.Value / y.Value, x.Name);
        }

        public override string ToString()
        {
            return (String.Format("{0}{1}", Value, Name));
        }
    }
}
