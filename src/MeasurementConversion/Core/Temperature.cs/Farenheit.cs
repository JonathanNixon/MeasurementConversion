using Jdn.Measurement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Temperature
{
    public class Farenheit : ITemperature
    {
        public Farenheit(decimal value)
        {
            this.Amount = value;
        }

        public decimal Amount { get; set; }

        public decimal ToFarenheit() => this.Amount;

        public decimal ToCelsius()
        {
            var temp = this.Amount - 32m;
            var fiveNinths = decimal.Divide(5, 9);
            var celsius = temp * fiveNinths;
            return (decimal)System.Math.Round(celsius, 2);
        }

        public string UnitOfMeasure => "Farenheit";

        public string AbbreviatedDisplayString => $"{this.Amount}°F";

        public string DisplayString => $"{this.Amount} degrees Farenheit";

        public IMeasurement MultiplyBy(decimal value)
        {
            return this;
        }
    }
}
