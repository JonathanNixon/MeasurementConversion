using Jdn.Measurement.Core.Interfaces;
using Jdn.Measurement.Core.Volume;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Tests.Volume
{
    [TestClass]
    public class TeaspoonTests
    {
        [TestMethod]
        public void ToMililiters()
        {
            var volume = GetVolume(1m);
            Assert.IsTrue(volume.ToMilliliters() == 4.93m);
        }

        [TestMethod]
        public void ToTablespoons()
        {
            var volume = GetVolume(3m);
            Assert.IsTrue(volume.ToTablespoons() == 1m);
        }

        [TestMethod]
        public void ToCups()
        {
            var volume = GetVolume(12m);

            Assert.IsTrue(volume.ToCups() == 0.25m);
        }

        [TestMethod]
        public void ToFluidOunces()
        {
            var volume = GetVolume(6m);

            Assert.IsTrue(volume.ToFluidOunces() == 1m);
        }

        [TestMethod]
        public void ToTeaspoons()
        {
            var volume = GetVolume(1m);

            Assert.IsTrue(volume.ToTeaspoons() == 1m);
        }

        [TestMethod]
        public void ToPints()
        {
            var volume = GetVolume(24m);
            Assert.IsTrue(volume.ToPints() == 0.25m);
        }

        [TestMethod]
        public void ToQuarts()
        {
            var volume = GetVolume(48m);
            Assert.IsTrue(volume.ToQuarts() == 0.25m);
        }

        [TestMethod]
        public void ToGallons()
        {
            var volume = VolumeFactory.Teaspoons(192m);
            Assert.IsTrue(volume.ToGallons() == 0.25m);
        }

        [TestMethod]
        public void PluralStringTrue()
        {
            var volume = VolumeFactory.Teaspoons(2m);
            Assert.IsTrue(volume.DisplayString.EndsWith("s"));
        }

        [TestMethod]
        public void PluralStringFalse()
        {
            var volume = VolumeFactory.Teaspoons(1m);

            Assert.IsFalse(volume.DisplayString.EndsWith("s"));
        }

        [TestMethod]
        public void DisplayStringContainsAmount()
        {
            var volume = VolumeFactory.Teaspoons(1m);

            Assert.IsTrue(volume.DisplayString.StartsWith("1"));
        }

        [TestMethod]
        public void AbbreviatedDisplayStringContainsAmount()
        {
            var volume = GetVolume(2.5m);

            Assert.IsTrue(volume.AbbreviatedDisplayString.StartsWith("2.5"));
        }

        [TestMethod]
        public void VerifyAmount()
        {
            var volume = GetVolume(1.5m);
            Assert.IsTrue(volume.Amount == 1.5m);
        }

        [TestMethod]
        public void VerifyUnitOfMeasure()
        {
            var volume = GetVolume(1.5m);

            Assert.IsTrue(volume.UnitOfMeasure == "Teaspoon");
        }

        [TestMethod]
        public void VerifyMultiply()
        {
            var volume = GetVolume(1.5m);

            Assert.IsTrue(volume.MultiplyBy(4).Amount == 6m);
        }

        private IVolume GetVolume(decimal value)
        {
            return VolumeFactory.Teaspoons(value);
        }
    }
}
