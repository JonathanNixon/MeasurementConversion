using Jdn.Measurement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Temperature
{
    public class Celsius : ITemperature
    {
        public Celsius(decimal value)
        {
            this.Amount = value;
        }

        public decimal ToFarenheit()
        {
            var nineFiths = decimal.Divide(9, 5);
            var temp = System.Math.Round(this.Amount * nineFiths, 0);

            return temp + 32m;
        }

        public decimal ToCelsius() => this.Amount;

        public decimal Amount { get; set; }

        public string UnitOfMeasure => this.GetType().Name;

        public string AbbreviatedDisplayString => $"{this.Amount}°C";

        public string DisplayString => $"{this.Amount} degrees Celsius";

        public IMeasurement MultiplyBy(decimal value)
        {
            return this;
        }
    }
}
