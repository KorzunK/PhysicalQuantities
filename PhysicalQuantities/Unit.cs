using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
    public abstract class Unit
    {
        public double Value { get; set; }
        public string Name { get; set; }
    }
}
