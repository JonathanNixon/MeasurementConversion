using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jdn.Measurement.Core.Interfaces
{
    public interface ISystemOfMeasurement
    {
        bool IsInternationalSystemOfMeasure();

        bool IsUSCustomaryUnits();
    }
}