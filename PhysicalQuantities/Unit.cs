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
        }

        public Unit() { }

        public static Unit operator +(Unit x, Unit y)
        {
            if (x.GetType() == y.GetType())
            {
                return new Unit(x.Value + y.Value);
            }
            else
            {
                throw new InvalidOperationException("Adding Error");
            }
        }

        public static Unit operator -(Unit x, Unit y)
        {
            if (x.GetType() == y.GetType())
            {
                return new Unit(x.Value - y.Value);
            }
            else
            {
                throw new InvalidOperationException("Subtraction Error");
            }
        }

        public static Unit operator *(Unit x, Unit y)
        {
            throw new InvalidOperationException("Multiplication Error");
        }


        public static Unit operator *(Unit x, int number)
        {
            return new Unit(x.Value * number);
        } 

        public static Unit operator *(int number, Unit x)
        {
            return new Unit(number * x.Value);
        }

        public static Unit operator /(Unit x, int number)
        {
            return new Unit(x.Value / number);
        }

        public static Unit operator /(Unit x, Unit y)
        {
            if (x.GetType() == y.GetType())
            {
                return new Unit(x.Value / y.Value);
            }
            else
            {
                throw new InvalidOperationException("Division Error");
            }
        }
    }
}
