using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
    public class Length : Unit
    {
        public Length(double value, string name)
        {
            Value = value;
            Name = name;
        }

        public static Length operator +(Length x, Length y)
        {
            return new Length(x.Value + y.Value, x.Name);
        }

        public static Length operator -(Length x, Length y)
        {
            return new Length(x.Value - y.Value, x.Name);
        }

        public static Length operator *(Length x, Length y)
        {
            return new Length(x.Value * y.Value, x.Name);
        }

        public static Length operator /(Length x, Length y)
        {
            return new Length(x.Value / y.Value, x.Name);
        }

        public override string ToString()
        {
            return (String.Format("{0}{1}", Value, Name));
        }
    }
}