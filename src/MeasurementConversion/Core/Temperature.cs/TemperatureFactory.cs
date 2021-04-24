using Jdn.Measurement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Temperature
{
    public static class TemperatureFactory
    {
        public static ITemperature Farenheit(decimal value)
        {
            return new Farenheit(value);
        }

        public static ITemperature Celsius(decimal value)
        {
            return new Celsius(value);
        }
    }
}
