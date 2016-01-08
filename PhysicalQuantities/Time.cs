using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH
{
    public class Time : Unit
    {
        public Time(double value)
        {
            Value = value;
            Type = "s";
        }

        static public Time operator +(Time t1, Time t2)
        {
            return new Time(t1.Value + t2.Value);
        }

        static public Time operator -(Time t1, Time t2)
        {
            return new Time(t1.Value - t2.Value);
        }

        static public Length operator *(Speed v, Time t)
        {
            return new Length(v.Value * t.Value);
        }

        static public Length operator *(Time t, Speed v)
        {
            return new Length(t.Value * v.Value);
        }
    }
}
