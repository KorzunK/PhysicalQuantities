using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH
{
    public class Speed : Unit
    {
        public Speed(double value)
        {
            Value = value;
            Type = "m/s";
        }

        static public Speed operator +(Speed v1, Speed v2)
        {
            return new Speed(v1.Value + v2.Value);
        }

        static public Speed operator -(Speed v1, Speed v2)
        {
            return new Speed(v1.Value - v2.Value);
        }

        public static Acceleration operator /(Speed v, Time t)
        {
            Acceleration acceleration = new Acceleration(v.Value / t.Value);
            return acceleration;
        }
    }
}
