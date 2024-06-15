using Jdn.Measurement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jdn.Measurement.Core.Volume
{
    public abstract class USCustomaryVolume : BaseVolume, IVolume
    {
        public USCustomaryVolume()
            : base(new SystemOfMeasurement(true))
        {}
    }
}