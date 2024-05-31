using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jdn.Measurement.Core.Volume
{
    public abstract class MetricVolume : BaseVolume
    {
        public MetricVolume()
            : base(new SystemOfMeasurement(false))
        {}
    }
}