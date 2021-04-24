using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Interfaces
{
    public interface IMeasurement
    {
        decimal Amount { get; set; }

        string UnitOfMeasure { get; }

        string AbbreviatedDisplayString { get; }

        string DisplayString { get; }

        IMeasurement MultiplyBy(decimal value);
    }
}
