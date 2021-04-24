using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Interfaces
{
    public interface ITemperature : IMeasurement
    {
        decimal ToFarenheit();

        decimal ToCelsius();
    }
}
