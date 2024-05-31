using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jdn.Measurement.Core.Weight
{
    public abstract class MetricWeight : BaseWeight
    {
        public MetricWeight()
            :base(new SystemOfMeasurement(false))
        {}
    }
}