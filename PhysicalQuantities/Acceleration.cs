using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH
{
    public class Acceleration : Unit
    {
        public Acceleration(double value)
        {
            Value = value;
            Type = "m/s^2";
        }

        static public Acceleration operator +(Acceleration a1, Acceleration a2)
        {
            return new Acceleration(a1.Value + a2.Value);
        }

        static public Acceleration operator -(Acceleration a1, Acceleration a2)
        {
            return new Acceleration(a1.Value - a2.Value);
        }
    }
}
