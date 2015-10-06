using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
    public class Time : Unit
    {
        public Time(double value, string name)
        {
            Value = value;
            Name = name;
        }

        public static Time operator +(Time x, Time y)
        {
            return new Time(x.Value + y.Value, x.Name);
        }

        public static Time operator -(Time x, Time y)
        {
            return new Time(x.Value - y.Value, x.Name);
        }

        public static Time operator *(Time x, Time y)
        {
            return new Time(x.Value * y.Value, x.Name);
        }

        public static Time operator /(Time x, Time y)
        {
            return new Time(x.Value / y.Value, x.Name);
        }

        public override string ToString()
        {
            return (String.Format("{0}{1}", Value, Name));
        }
    }
}
