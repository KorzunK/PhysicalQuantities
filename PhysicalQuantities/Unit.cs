using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
    public class Unit
    {
        public double Value { get; set; }
        public string Name { get; set; }

        public Unit(double value, string name)
        {
            Value = value;
            Name = name;
        }

        public static Unit operator +(Unit x, Unit y)
        {
            if (x.Name != y.Name)
                throw new InvalidOperationException("Error");

            return new Unit(x.Value + y.Value, x.Name);
        }

        public static Unit operator -(Unit x, Unit y)
        {
            if (x.Name != y.Name)
                throw new InvalidOperationException("Error");

            return new Unit(x.Value - y.Value, x.Name);
        }

        public static Unit operator *(Unit x, Unit y)
        {
            if ((x.Name != Quantities.Value.Speed.ToString() || x.Name != Quantities.Value.Time.ToString()) && (y.Name != Quantities.Value.Time.ToString() && y.Name!= Quantities.Value.Speed.ToString()))
                throw new InvalidOperationException("Error");

            return new Unit(x.Value * y.Value, x.Name);
        }

        public static Unit operator /(Unit x, Unit y)
        {
            string v = null;

            if ((x.Name == Quantities.Value.Length.ToString() && y.Name == Quantities.Value.Speed.ToString()))
                v = Quantities.Value.Length.ToString();
            else
                throw new InvalidOperationException("Error");

            if ((x.Name == Quantities.Value.Length.ToString() && y.Name == Quantities.Value.Time.ToString()))
                v = Quantities.Value.Speed.ToString();
            else
                throw new InvalidOperationException("Error");

            return new Unit(x.Value / y.Value, v);
        }

        public override string ToString()
        {
            return (String.Format("{0}{1}", Value, Name));
        }
    }
}
