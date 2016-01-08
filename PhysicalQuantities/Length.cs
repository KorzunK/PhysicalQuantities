using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH
{
    public class Length : Unit
    {
        public Length(double value)
        {
            Value = value;
            Type = "m";
        }

        static public Length operator +(Length s1, Length s2)
        {
            return new Length(s1.Value + s2.Value);
        }

        static public Length operator -(Length s1, Length s2)
        {
            return new Length(s1.Value - s2.Value);
        }

        static public Time operator /(Length s, Speed v)
        {
            return new Time(s.Value / v.Value);
        }

        public static Speed operator /(Length s, Time t)
        {
            Speed speed = new Speed(s.Value / t.Value);
            return speed;
        }
    }
}
