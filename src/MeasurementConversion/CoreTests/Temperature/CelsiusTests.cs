using Jdn.Measurement.Core.Interfaces;
using Jdn.Measurement.Core.Temperature;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Tests.Temperature
{
    [TestClass]
    public class CelsiusTests
    {
        [TestMethod]
        public void ToFarenheit()
        {
            var temperature = GetTemperature(100m);
            Assert.IsTrue(temperature.ToFarenheit() == 212m);
        }

        [TestMethod]
        public void ToCelsius()
        {
            var temperature = GetTemperature(150m);
            Assert.IsTrue(temperature.ToCelsius() == 150m);
        }

        [TestMethod]
        public void PluralStringTrue()
        {
            var volume = GetTemperature(2m);
            Assert.IsTrue(volume.DisplayString.EndsWith("s"));
        }

        [TestMethod]
        public void DisplayStringContainsAmount()
        {
            var volume = GetTemperature(1m);
            Assert.IsTrue(volume.DisplayString.StartsWith("1"));
        }

        [TestMethod]
        public void AbbreviatedDisplayStringContainsAmount()
        {
            var volume = GetTemperature(2.5m);
            Assert.IsTrue(volume.AbbreviatedDisplayString.StartsWith("2.5"));
        }

        [TestMethod]
        public void VerifyAmount()
        {
            var volume = GetTemperature(1.5m);
            Assert.IsTrue(volume.Amount == 1.5m);
        }

        [TestMethod]
        public void VerifyUnitOfMeasure()
        {
            var volume = GetTemperature(1.5m);
            Assert.IsTrue(volume.UnitOfMeasure == "Celsius");
        }

        private ITemperature GetTemperature(decimal value)
        {
            return TemperatureFactory.Celsius(value);
        }
    }
}
