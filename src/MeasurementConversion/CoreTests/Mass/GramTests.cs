using Jdn.Measurement.Core.Interfaces;
using Jdn.Measurement.Core.Mass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jdn.Measurement.Core.Tests.Mass
{
    [TestClass]
    public class GramTests
    {
        [TestMethod]
        public void ToOunces()
        {
            var mass = this.GetMass(28.3495231m);
            Assert.IsTrue(mass.ToOunces() == 1m);
        }

        [TestMethod]
        public void ToPounds()
        {
            var mass = this.GetMass(28.3495231m);
            Assert.IsTrue(mass.ToPounds() == 0.06m);
        }

        [TestMethod]
        public void ToGrams()
        {
            var mass = this.GetMass(1m);
            Assert.IsTrue(mass.ToGrams() == 1m);
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
            Assert.IsTrue(volume.UnitOfMeasure == "Gram");
        }

        [TestMethod]
        public void VerifyMultiply()
        {
            var volume = GetMass(1.5m);
            Assert.IsTrue(volume.MultiplyBy(4).Amount == 6m);
        }

        private IMass GetMass(decimal value)
        {
            return MassFactory.Grams(value);
        }
    }
}