using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jdn.Measurement.Core.Weight
{
    public abstract class USCustomaryWeight : BaseWeight
    {
        public USCustomaryWeight()
            : base(new SystemOfMeasurement(true))
        { }
    }
}