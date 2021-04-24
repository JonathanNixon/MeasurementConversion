using Jdn.Measurement.Core.Interfaces;
using Jdn.Measurement.Core.Volume;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Tests.Volume
{
    [TestClass]
    public class TablespoonTests
    {
        [TestMethod]
        public void ToMililiters()
        {
            var volume = GetVolume(1m);
            Assert.IsTrue(volume.ToMilliliters() == 14.79m);
        }

        [TestMethod]
        public void ToTablespoons()
        {
            var volume = GetVolume(10m);

            Assert.IsTrue(volume.ToTablespoons() == 10m);
        }

        [TestMethod]
        public void ToCups()
        {
            var volume = GetVolume(8m);

            Assert.IsTrue(volume.ToCups() == 0.5m);
        }

        [TestMethod]
        public void ToFluidOunces()
        {
            var volume = GetVolume(8m);

            Assert.IsTrue(volume.ToFluidOunces() == 4m);
        }

        [TestMethod]
        public void ToTeaspoons()
        {
            var volume = GetVolume(2m);

            Assert.IsTrue(volume.ToTeaspoons() == 6m);
        }

        [TestMethod]
        public void ToPints()
        {
            var volume = GetVolume(16m);

            Assert.IsTrue(volume.ToPints() == 0.5m);
        }

        [TestMethod]
        public void ToQuarts()
        {
            var volume = GetVolume(32m);

            Assert.IsTrue(volume.ToQuarts() == 0.5m);
        }

        [TestMethod]
        public void ToGallons()
        {
            var volume = GetVolume(64m);

            Assert.IsTrue(volume.ToGallons() == 0.25m);
        }

        [TestMethod]
        public void PluralStringTrue()
        {
            var volume = GetVolume(2m);

            Assert.IsTrue(volume.DisplayString.EndsWith("s"));
        }

        [TestMethod]
        public void PluralStringFalse()
        {
            var volume = GetVolume(1m);

            Assert.IsFalse(volume.DisplayString.EndsWith("s"));
        }

        [TestMethod]
        public void DisplayStringContainsAmount()
        {
            var volume = GetVolume(1m);

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

            Assert.IsTrue(volume.UnitOfMeasure == "Tablespoon");
        }

        [TestMethod]
        public void VerifyMultiply()
        {
            var volume = GetVolume(1.5m);

            Assert.IsTrue(volume.MultiplyBy(4).Amount == 6m);
        }

        private IVolume GetVolume(decimal value)
        {
            return VolumeFactory.Tablespoons(value);
        }
    }
}
