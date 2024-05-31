using Jdn.Measurement.Core.Interfaces;
using Jdn.Measurement.Core.Weight;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Tests.Mass
{
    [TestClass]
    public class PoundTests
    {

        [TestMethod]
        public void ToOunces()
        {
            var mass = this.GetMass(1);
            Assert.IsTrue(mass.ToOunces() == 16m);
        }

        [TestMethod]
        public void ToPounds()
        {
            var mass = this.GetMass(1);
            Assert.IsTrue(mass.ToPounds() == 1m);
        }

        [TestMethod]
        public void ToGrams()
        {
            var mass = this.GetMass(3m);
            Assert.IsTrue(mass.ToGrams() == 1360.78m);
        }

        [TestMethod]
        public void PluralStringTrue()
        {
            var volume = GetMass(2m);
            Assert.IsTrue(volume.DisplayString.EndsWith("s"));
        }

        [TestMethod]
        public void PluralStringFalse()
        {
            var volume = GetMass(1m);
            Assert.IsFalse(volume.DisplayString.EndsWith("s"));
        }

        [TestMethod]
        public void DisplayStringContainsAmount()
        {
            var volume = GetMass(1m);
            Assert.IsTrue(volume.DisplayString.StartsWith("1"));
        }

        [TestMethod]
        public void AbbreviatedDisplayStringContainsAmount()
        {
            var volume = GetMass(2.5m);
            Assert.IsTrue(volume.AbbreviatedDisplayString.StartsWith("2.5"));
        }

        [TestMethod]
        public void VerifyAmount()
        {
            var volume = GetMass(1.5m);
            Assert.IsTrue(volume.Amount == 1.5m);
        }

        [TestMethod]
        public void VerifyUnitOfMeasure()
        {
            var volume = GetMass(1.5m);
            Assert.IsTrue(volume.UnitOfMeasure == "Pound");
        }

        [TestMethod]
        public void VerifyMultiply()
        {
            var volume = GetMass(1.5m);
            Assert.IsTrue(volume.MultiplyBy(4).Amount == 6m);
        }

        private IWeight GetMass(decimal value)
        {
            return WeightFactory.Pounds(value);
        }
    }
}
